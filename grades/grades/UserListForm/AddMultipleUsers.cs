using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grades
{
    public partial class AddMultipleUsers : Form
    {
        private Context _context;

        private string _filePath = string.Empty;
        public AddMultipleUsers(Context context)
        {
            InitializeComponent();

            _context = context;

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ControlBox = false;
        }

        private void AddMultipleUsers_Load(object sender, EventArgs e)
        {

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(_filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();

                while (csv.Read())
                {
                    string firstName = csv.GetField<String>("FirstName");
                    string surName = csv.GetField<String>("SurName");
                    string middleName = csv.GetField<String>("MidleName");
                    string phoneNumber = csv.GetField<String>("PhoneNumber");
                    string homeAddress = csv.GetField<String>("HomeAddress");
                    string login = csv.GetField<String>("Login");
                    string password = csv.GetField<String>("Password");
                    int positionId = csv.GetField<int>("PositionId");
                    string positionName = _context.Positions.Where(x => x.PositionId == positionId).Select(x => x.Name).Single();

                    if (positionName == "Ученик")
                    {
                        Student record = new Student
                        {
                            FirstName = firstName,
                            SurName = surName,
                            MiddleName = middleName,
                            PhoneNumber = phoneNumber,
                            HomeAddress = homeAddress,
                            Login = login,
                            Password = password,
                            PositionId = positionId
                        };

                        record.Position = _context.Positions.Where(x => x.PositionId == record.PositionId).Select(x => x).Single();
                        _context.Persons.Add(record);
                    }
                    else
                    {
                        Staff record = new Staff
                        {
                            FirstName = firstName,
                            SurName = surName,
                            MiddleName = middleName,
                            PhoneNumber = phoneNumber,
                            HomeAddress = homeAddress,
                            Login = login,
                            Password = password,
                            PositionId = positionId
                        };

                        record.Position = _context.Positions.Where(x => x.PositionId == record.PositionId).Select(x => x).Single();
                        _context.Persons.Add(record);
                    }

                }
            }

            _context.SaveChanges();

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileDialogButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _filePath = openFileDialog.FileName;
                    pathBox.Text = _filePath;
                }
            }
        }
    }
}
