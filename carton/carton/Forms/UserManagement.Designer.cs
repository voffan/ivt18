
namespace carton
{
    partial class UserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.addUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addFactoryDirectorIdField = new System.Windows.Forms.TextBox();
            this.addFactoryIdField = new System.Windows.Forms.TextBox();
            this.addStorageIdField = new System.Windows.Forms.TextBox();
            this.addAddressField = new System.Windows.Forms.TextBox();
            this.addContactPhoneField = new System.Windows.Forms.TextBox();
            this.addStatusIdField = new System.Windows.Forms.TextBox();
            this.addPositionIdField = new System.Windows.Forms.TextBox();
            this.addPasswordField = new System.Windows.Forms.TextBox();
            this.addLoginField = new System.Windows.Forms.TextBox();
            this.addFathernameField = new System.Windows.Forms.TextBox();
            this.addNameField = new System.Windows.Forms.TextBox();
            this.addSurnameField = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.editFactoryDirectorIdField = new System.Windows.Forms.TextBox();
            this.editFactoryIdField = new System.Windows.Forms.TextBox();
            this.editStorageIdField = new System.Windows.Forms.TextBox();
            this.editAddressField = new System.Windows.Forms.TextBox();
            this.editContactPhoneField = new System.Windows.Forms.TextBox();
            this.editStatusIdField = new System.Windows.Forms.TextBox();
            this.editPositionIdField = new System.Windows.Forms.TextBox();
            this.editPasswordField = new System.Windows.Forms.TextBox();
            this.editLoginField = new System.Windows.Forms.TextBox();
            this.editFathernameField = new System.Windows.Forms.TextBox();
            this.editNameField = new System.Windows.Forms.TextBox();
            this.editSurnameField = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.editUserIdField = new System.Windows.Forms.TextBox();
            this.deleteUserIdField = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersGridView
            // 
            this.usersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Location = new System.Drawing.Point(12, 12);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.Size = new System.Drawing.Size(806, 360);
            this.usersGridView.TabIndex = 0;
            this.usersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellContentClick);
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addUserButton.Location = new System.Drawing.Point(49, 710);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(84, 30);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Добавить";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editUserButton.Location = new System.Drawing.Point(345, 736);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(84, 30);
            this.editUserButton.TabIndex = 2;
            this.editUserButton.Text = "Изменить";
            this.editUserButton.UseVisualStyleBackColor = true;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteUserButton.Location = new System.Drawing.Point(677, 424);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(84, 29);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "Удалить";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(173, 687);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "ID директора фабрики";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 661);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "ID фабрики";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 635);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "ID склада";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 609);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Адрес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 583);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Контактный телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "ID статуса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "ID должности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Фамилия";
            // 
            // addFactoryDirectorIdField
            // 
            this.addFactoryDirectorIdField.Location = new System.Drawing.Point(12, 684);
            this.addFactoryDirectorIdField.Name = "addFactoryDirectorIdField";
            this.addFactoryDirectorIdField.Size = new System.Drawing.Size(155, 20);
            this.addFactoryDirectorIdField.TabIndex = 36;
            // 
            // addFactoryIdField
            // 
            this.addFactoryIdField.Location = new System.Drawing.Point(12, 658);
            this.addFactoryIdField.Name = "addFactoryIdField";
            this.addFactoryIdField.Size = new System.Drawing.Size(155, 20);
            this.addFactoryIdField.TabIndex = 35;
            // 
            // addStorageIdField
            // 
            this.addStorageIdField.Location = new System.Drawing.Point(12, 632);
            this.addStorageIdField.Name = "addStorageIdField";
            this.addStorageIdField.Size = new System.Drawing.Size(155, 20);
            this.addStorageIdField.TabIndex = 34;
            // 
            // addAddressField
            // 
            this.addAddressField.Location = new System.Drawing.Point(12, 606);
            this.addAddressField.Name = "addAddressField";
            this.addAddressField.Size = new System.Drawing.Size(155, 20);
            this.addAddressField.TabIndex = 33;
            // 
            // addContactPhoneField
            // 
            this.addContactPhoneField.Location = new System.Drawing.Point(12, 580);
            this.addContactPhoneField.Name = "addContactPhoneField";
            this.addContactPhoneField.Size = new System.Drawing.Size(155, 20);
            this.addContactPhoneField.TabIndex = 32;
            // 
            // addStatusIdField
            // 
            this.addStatusIdField.Location = new System.Drawing.Point(12, 554);
            this.addStatusIdField.Name = "addStatusIdField";
            this.addStatusIdField.Size = new System.Drawing.Size(155, 20);
            this.addStatusIdField.TabIndex = 31;
            // 
            // addPositionIdField
            // 
            this.addPositionIdField.Location = new System.Drawing.Point(12, 528);
            this.addPositionIdField.Name = "addPositionIdField";
            this.addPositionIdField.Size = new System.Drawing.Size(155, 20);
            this.addPositionIdField.TabIndex = 30;
            // 
            // addPasswordField
            // 
            this.addPasswordField.Location = new System.Drawing.Point(12, 502);
            this.addPasswordField.Name = "addPasswordField";
            this.addPasswordField.Size = new System.Drawing.Size(155, 20);
            this.addPasswordField.TabIndex = 29;
            // 
            // addLoginField
            // 
            this.addLoginField.Location = new System.Drawing.Point(12, 476);
            this.addLoginField.Name = "addLoginField";
            this.addLoginField.Size = new System.Drawing.Size(155, 20);
            this.addLoginField.TabIndex = 28;
            // 
            // addFathernameField
            // 
            this.addFathernameField.Location = new System.Drawing.Point(12, 450);
            this.addFathernameField.Name = "addFathernameField";
            this.addFathernameField.Size = new System.Drawing.Size(155, 20);
            this.addFathernameField.TabIndex = 27;
            // 
            // addNameField
            // 
            this.addNameField.Location = new System.Drawing.Point(12, 424);
            this.addNameField.Name = "addNameField";
            this.addNameField.Size = new System.Drawing.Size(155, 20);
            this.addNameField.TabIndex = 26;
            // 
            // addSurnameField
            // 
            this.addSurnameField.Location = new System.Drawing.Point(12, 398);
            this.addSurnameField.Name = "addSurnameField";
            this.addSurnameField.Size = new System.Drawing.Size(155, 20);
            this.addSurnameField.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(471, 713);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "ID директора фабрики";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(471, 687);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 71;
            this.label14.Text = "ID фабрики";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(471, 661);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 70;
            this.label15.Text = "ID склада";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(471, 635);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 69;
            this.label16.Text = "Адрес";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(471, 609);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 13);
            this.label17.TabIndex = 68;
            this.label17.Text = "Контактный телефон";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(471, 583);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 67;
            this.label18.Text = "ID статуса";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(471, 557);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 66;
            this.label19.Text = "ID должности";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(471, 531);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 65;
            this.label20.Text = "Пароль";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(471, 505);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 64;
            this.label21.Text = "Логин";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(471, 479);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 63;
            this.label22.Text = "Отчество";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(471, 453);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 62;
            this.label23.Text = "Имя";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(471, 427);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 13);
            this.label24.TabIndex = 61;
            this.label24.Text = "Фамилия";
            // 
            // editFactoryDirectorIdField
            // 
            this.editFactoryDirectorIdField.Location = new System.Drawing.Point(310, 710);
            this.editFactoryDirectorIdField.Name = "editFactoryDirectorIdField";
            this.editFactoryDirectorIdField.Size = new System.Drawing.Size(155, 20);
            this.editFactoryDirectorIdField.TabIndex = 60;
            // 
            // editFactoryIdField
            // 
            this.editFactoryIdField.Location = new System.Drawing.Point(310, 684);
            this.editFactoryIdField.Name = "editFactoryIdField";
            this.editFactoryIdField.Size = new System.Drawing.Size(155, 20);
            this.editFactoryIdField.TabIndex = 59;
            // 
            // editStorageIdField
            // 
            this.editStorageIdField.Location = new System.Drawing.Point(310, 658);
            this.editStorageIdField.Name = "editStorageIdField";
            this.editStorageIdField.Size = new System.Drawing.Size(155, 20);
            this.editStorageIdField.TabIndex = 58;
            // 
            // editAddressField
            // 
            this.editAddressField.Location = new System.Drawing.Point(310, 632);
            this.editAddressField.Name = "editAddressField";
            this.editAddressField.Size = new System.Drawing.Size(155, 20);
            this.editAddressField.TabIndex = 57;
            // 
            // editContactPhoneField
            // 
            this.editContactPhoneField.Location = new System.Drawing.Point(310, 606);
            this.editContactPhoneField.Name = "editContactPhoneField";
            this.editContactPhoneField.Size = new System.Drawing.Size(155, 20);
            this.editContactPhoneField.TabIndex = 56;
            // 
            // editStatusIdField
            // 
            this.editStatusIdField.Location = new System.Drawing.Point(310, 580);
            this.editStatusIdField.Name = "editStatusIdField";
            this.editStatusIdField.Size = new System.Drawing.Size(155, 20);
            this.editStatusIdField.TabIndex = 55;
            // 
            // editPositionIdField
            // 
            this.editPositionIdField.Location = new System.Drawing.Point(310, 554);
            this.editPositionIdField.Name = "editPositionIdField";
            this.editPositionIdField.Size = new System.Drawing.Size(155, 20);
            this.editPositionIdField.TabIndex = 54;
            // 
            // editPasswordField
            // 
            this.editPasswordField.Location = new System.Drawing.Point(310, 528);
            this.editPasswordField.Name = "editPasswordField";
            this.editPasswordField.Size = new System.Drawing.Size(155, 20);
            this.editPasswordField.TabIndex = 53;
            // 
            // editLoginField
            // 
            this.editLoginField.Location = new System.Drawing.Point(310, 502);
            this.editLoginField.Name = "editLoginField";
            this.editLoginField.Size = new System.Drawing.Size(155, 20);
            this.editLoginField.TabIndex = 52;
            // 
            // editFathernameField
            // 
            this.editFathernameField.Location = new System.Drawing.Point(310, 476);
            this.editFathernameField.Name = "editFathernameField";
            this.editFathernameField.Size = new System.Drawing.Size(155, 20);
            this.editFathernameField.TabIndex = 51;
            // 
            // editNameField
            // 
            this.editNameField.Location = new System.Drawing.Point(310, 450);
            this.editNameField.Name = "editNameField";
            this.editNameField.Size = new System.Drawing.Size(155, 20);
            this.editNameField.TabIndex = 50;
            // 
            // editSurnameField
            // 
            this.editSurnameField.Location = new System.Drawing.Point(310, 424);
            this.editSurnameField.Name = "editSurnameField";
            this.editSurnameField.Size = new System.Drawing.Size(155, 20);
            this.editSurnameField.TabIndex = 49;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(471, 401);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 13);
            this.label25.TabIndex = 74;
            this.label25.Text = "ID пользователя";
            // 
            // editUserIdField
            // 
            this.editUserIdField.Location = new System.Drawing.Point(310, 398);
            this.editUserIdField.Name = "editUserIdField";
            this.editUserIdField.Size = new System.Drawing.Size(155, 20);
            this.editUserIdField.TabIndex = 73;
            // 
            // deleteUserIdField
            // 
            this.deleteUserIdField.Location = new System.Drawing.Point(630, 398);
            this.deleteUserIdField.Name = "deleteUserIdField";
            this.deleteUserIdField.Size = new System.Drawing.Size(155, 20);
            this.deleteUserIdField.TabIndex = 75;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(791, 401);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(18, 13);
            this.label26.TabIndex = 76;
            this.label26.Text = "ID";
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 782);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.deleteUserIdField);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.editUserIdField);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.editFactoryDirectorIdField);
            this.Controls.Add(this.editFactoryIdField);
            this.Controls.Add(this.editStorageIdField);
            this.Controls.Add(this.editAddressField);
            this.Controls.Add(this.editContactPhoneField);
            this.Controls.Add(this.editStatusIdField);
            this.Controls.Add(this.editPositionIdField);
            this.Controls.Add(this.editPasswordField);
            this.Controls.Add(this.editLoginField);
            this.Controls.Add(this.editFathernameField);
            this.Controls.Add(this.editNameField);
            this.Controls.Add(this.editSurnameField);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addFactoryDirectorIdField);
            this.Controls.Add(this.addFactoryIdField);
            this.Controls.Add(this.addStorageIdField);
            this.Controls.Add(this.addAddressField);
            this.Controls.Add(this.addContactPhoneField);
            this.Controls.Add(this.addStatusIdField);
            this.Controls.Add(this.addPositionIdField);
            this.Controls.Add(this.addPasswordField);
            this.Controls.Add(this.addLoginField);
            this.Controls.Add(this.addFathernameField);
            this.Controls.Add(this.addNameField);
            this.Controls.Add(this.addSurnameField);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.usersGridView);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addFactoryDirectorIdField;
        private System.Windows.Forms.TextBox addFactoryIdField;
        private System.Windows.Forms.TextBox addStorageIdField;
        private System.Windows.Forms.TextBox addAddressField;
        private System.Windows.Forms.TextBox addContactPhoneField;
        private System.Windows.Forms.TextBox addStatusIdField;
        private System.Windows.Forms.TextBox addPositionIdField;
        private System.Windows.Forms.TextBox addPasswordField;
        private System.Windows.Forms.TextBox addLoginField;
        private System.Windows.Forms.TextBox addFathernameField;
        private System.Windows.Forms.TextBox addNameField;
        private System.Windows.Forms.TextBox addSurnameField;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox editFactoryDirectorIdField;
        private System.Windows.Forms.TextBox editFactoryIdField;
        private System.Windows.Forms.TextBox editStorageIdField;
        private System.Windows.Forms.TextBox editAddressField;
        private System.Windows.Forms.TextBox editContactPhoneField;
        private System.Windows.Forms.TextBox editStatusIdField;
        private System.Windows.Forms.TextBox editPositionIdField;
        private System.Windows.Forms.TextBox editPasswordField;
        private System.Windows.Forms.TextBox editLoginField;
        private System.Windows.Forms.TextBox editFathernameField;
        private System.Windows.Forms.TextBox editNameField;
        private System.Windows.Forms.TextBox editSurnameField;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox editUserIdField;
        private System.Windows.Forms.TextBox deleteUserIdField;
        private System.Windows.Forms.Label label26;
    }
}