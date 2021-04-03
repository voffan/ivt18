using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computers.Modules.Employee
{
    public interface IEmployeeView
    {
        IEmployeeInteractor Interactor { get; set; }
        void Close();
    }

    class EmployeeView : View, IEmployeeView
    {
        public IEmployeeInteractor Interactor { get; set; }

        private readonly Panel panel = new Panel();

        private readonly Label surnameLabel = new Label();
        private readonly Label nameLabel = new Label();
        private readonly Label patronymicNameLabel = new Label();
        private readonly Label roomLabel = new Label();

        private readonly TextBox surnameTextBox = new TextBox();
        private readonly TextBox nameTextBox = new TextBox();
        private readonly TextBox patronymicNameTextBox = new TextBox();
        private readonly TextBox roomTextBox = new TextBox();
        private readonly Button submitButton = new Button();
        private readonly Button cancelButton = new Button();

        private readonly Size panelSize = new Size(300, 300);
        private readonly Size labelSize = new Size(280, 20);

        public override void SetupView()
        {
            base.SetupView();
            Text = "Добавление сотрудника";
            Size = new Size(320, 345);
        }

        public override void ViewDidLoad(object sender, EventArgs e)
        {
            base.ViewDidLoad(sender, e);
            surnameLabel.Text = "Фамилия";
            nameLabel.Text = "Имя";
            patronymicNameLabel.Text = "Отчество";
            roomLabel.Text = "Кабинет";
            submitButton.Text = "Добавить";
            cancelButton.Text = "Отмена";
            panel.BorderStyle = BorderStyle.FixedSingle;
            submitButton.Click += SubmitButtonClicked;
            cancelButton.Click += CancelButtonClicked;

            surnameTextBox.TextChanged += SurnameTextBoxChanged;
            nameTextBox.TextChanged += NameTextBoxChanged;
            patronymicNameTextBox.TextChanged += PatronymicNameTextBoxChanged;
            roomTextBox.TextChanged += RoomTextBoxChanged;

            panel.Controls.Add(surnameLabel);
            panel.Controls.Add(surnameTextBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(nameTextBox);
            panel.Controls.Add(patronymicNameLabel);
            panel.Controls.Add(patronymicNameTextBox);
            panel.Controls.Add(roomLabel);
            panel.Controls.Add(roomTextBox);
            panel.Controls.Add(submitButton);
            panel.Controls.Add(cancelButton);

            Controls.Add(panel);
        }

        public override void SetupLayout(object sender, EventArgs e)
        {
            base.SetupLayout(sender, e);
            panel.Size = panelSize;
            panel.Location = new Point(ClientSize.Width / 2 - panel.Size.Width / 2, ClientSize.Height / 2 - panel.Size.Height / 2);

            surnameLabel.Size = labelSize;
            surnameLabel.Location = new Point(10, 10);

            surnameTextBox.Size = labelSize;
            surnameTextBox.Location = new Point(10, 30);

            nameLabel.Size = labelSize;
            nameLabel.Location = new Point(10, 60);

            nameTextBox.Size = labelSize;
            nameTextBox.Location = new Point(10, 80);

            patronymicNameLabel.Size = labelSize;
            patronymicNameLabel.Location = new Point(10, 110);

            patronymicNameTextBox.Size = labelSize;
            patronymicNameTextBox.Location = new Point(10, 130);

            roomLabel.Size = labelSize;
            roomLabel.Location = new Point(10, 160);

            roomTextBox.Size = labelSize;
            roomTextBox.Location = new Point(10, 180);

            submitButton.Size = new Size(70, 25);
            submitButton.Location = new Point(140, 265);

            cancelButton.Size = new Size(70, 25);
            cancelButton.Location = new Point(220, 265);
        }
        private void SurnameTextBoxChanged(object sender, EventArgs e) { Interactor.SetSurname(surnameTextBox.Text); }
        private void NameTextBoxChanged(object sender, EventArgs e) { Interactor.SetName(nameTextBox.Text); }
        private void PatronymicNameTextBoxChanged(object sender, EventArgs e) { Interactor.SetPatronymicName(patronymicNameTextBox.Text); }
        private void RoomTextBoxChanged(object sender, EventArgs e) { Interactor.SetRoom(roomTextBox.Text); }
        private void SubmitButtonClicked(object sender, EventArgs e) { Interactor.Submit(); }
        private void CancelButtonClicked(object sender, EventArgs e) { Interactor.Cancel(); }
    }
}
