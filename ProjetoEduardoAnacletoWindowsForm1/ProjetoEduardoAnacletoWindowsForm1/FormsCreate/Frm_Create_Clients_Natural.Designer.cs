namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    partial class Frm_Create_Clients_Natural
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.edt_firstName = new System.Windows.Forms.TextBox();
            this.edt_middleName = new System.Windows.Forms.TextBox();
            this.edt_lastName = new System.Windows.Forms.TextBox();
            this.lbl_middleName = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.gb_gender = new System.Windows.Forms.GroupBox();
            this.rbtn_otherGender = new System.Windows.Forms.RadioButton();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.edt_age = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.medt_dob = new System.Windows.Forms.MaskedTextBox();
            this.lbl_regNumber = new System.Windows.Forms.Label();
            this.medt_regNumber = new System.Windows.Forms.MaskedTextBox();
            this.gb_phones = new System.Windows.Forms.GroupBox();
            this.cbox_phone3 = new System.Windows.Forms.ComboBox();
            this.cbox_phone2 = new System.Windows.Forms.ComboBox();
            this.medt_phone3 = new System.Windows.Forms.MaskedTextBox();
            this.medt_phone2 = new System.Windows.Forms.MaskedTextBox();
            this.cbox_phone1 = new System.Windows.Forms.ComboBox();
            this.medt_phone1 = new System.Windows.Forms.MaskedTextBox();
            this.gb_address = new System.Windows.Forms.GroupBox();
            this.btn_findState = new System.Windows.Forms.Button();
            this.cbox_state = new System.Windows.Forms.ComboBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.lbl_homeType = new System.Windows.Forms.Label();
            this.cbox_homeType = new System.Windows.Forms.ComboBox();
            this.btn_findCity = new System.Windows.Forms.Button();
            this.lbl_city = new System.Windows.Forms.Label();
            this.cbox_city = new System.Windows.Forms.ComboBox();
            this.edt_complement = new System.Windows.Forms.TextBox();
            this.Complement = new System.Windows.Forms.Label();
            this.edt_district = new System.Windows.Forms.TextBox();
            this.lbl_district = new System.Windows.Forms.Label();
            this.edt_houseNumber = new System.Windows.Forms.TextBox();
            this.lbl_houseNumber = new System.Windows.Forms.Label();
            this.lbl_street = new System.Windows.Forms.Label();
            this.edt_street = new System.Windows.Forms.TextBox();
            this.lbl_zipCode = new System.Windows.Forms.Label();
            this.medt_zipCode = new System.Windows.Forms.MaskedTextBox();
            this.edt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.cbox_country = new System.Windows.Forms.ComboBox();
            this.gb_gender.SuspendLayout();
            this.gb_phones.SuspendLayout();
            this.gb_address.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(92, 9);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(69, 16);
            this.lbl_firstName.TabIndex = 4;
            this.lbl_firstName.Text = "First name";
            // 
            // edt_firstName
            // 
            this.edt_firstName.Location = new System.Drawing.Point(95, 28);
            this.edt_firstName.Name = "edt_firstName";
            this.edt_firstName.Size = new System.Drawing.Size(152, 22);
            this.edt_firstName.TabIndex = 5;
            // 
            // edt_middleName
            // 
            this.edt_middleName.Location = new System.Drawing.Point(253, 28);
            this.edt_middleName.Name = "edt_middleName";
            this.edt_middleName.Size = new System.Drawing.Size(152, 22);
            this.edt_middleName.TabIndex = 6;
            // 
            // edt_lastName
            // 
            this.edt_lastName.Location = new System.Drawing.Point(411, 28);
            this.edt_lastName.Name = "edt_lastName";
            this.edt_lastName.Size = new System.Drawing.Size(165, 22);
            this.edt_lastName.TabIndex = 7;
            // 
            // lbl_middleName
            // 
            this.lbl_middleName.AutoSize = true;
            this.lbl_middleName.Location = new System.Drawing.Point(250, 9);
            this.lbl_middleName.Name = "lbl_middleName";
            this.lbl_middleName.Size = new System.Drawing.Size(85, 16);
            this.lbl_middleName.TabIndex = 8;
            this.lbl_middleName.Text = "Middle name";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(408, 9);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(69, 16);
            this.lbl_lastName.TabIndex = 9;
            this.lbl_lastName.Text = "Last name";
            // 
            // gb_gender
            // 
            this.gb_gender.Controls.Add(this.rbtn_otherGender);
            this.gb_gender.Controls.Add(this.rbtn_female);
            this.gb_gender.Controls.Add(this.rbtn_male);
            this.gb_gender.Location = new System.Drawing.Point(623, 17);
            this.gb_gender.Name = "gb_gender";
            this.gb_gender.Size = new System.Drawing.Size(165, 71);
            this.gb_gender.TabIndex = 10;
            this.gb_gender.TabStop = false;
            this.gb_gender.Text = "Gender";
            // 
            // rbtn_otherGender
            // 
            this.rbtn_otherGender.AutoSize = true;
            this.rbtn_otherGender.Location = new System.Drawing.Point(86, 47);
            this.rbtn_otherGender.Name = "rbtn_otherGender";
            this.rbtn_otherGender.Size = new System.Drawing.Size(60, 20);
            this.rbtn_otherGender.TabIndex = 2;
            this.rbtn_otherGender.TabStop = true;
            this.rbtn_otherGender.Text = "Other";
            this.rbtn_otherGender.UseVisualStyleBackColor = true;
            this.rbtn_otherGender.CheckedChanged += new System.EventHandler(this.rbtn_otherGender_CheckedChanged);
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(85, 21);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(74, 20);
            this.rbtn_female.TabIndex = 1;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "Female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            this.rbtn_female.CheckedChanged += new System.EventHandler(this.rbtn_female_CheckedChanged);
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(17, 21);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(58, 20);
            this.rbtn_male.TabIndex = 0;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            this.rbtn_male.CheckedChanged += new System.EventHandler(this.rbtn_male_CheckedChanged);
            // 
            // edt_age
            // 
            this.edt_age.Location = new System.Drawing.Point(504, 91);
            this.edt_age.Name = "edt_age";
            this.edt_age.Size = new System.Drawing.Size(40, 22);
            this.edt_age.TabIndex = 11;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(501, 72);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(32, 16);
            this.lbl_age.TabIndex = 12;
            this.lbl_age.Text = "Age";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(408, 72);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(78, 16);
            this.lbl_dob.TabIndex = 14;
            this.lbl_dob.Text = "Date of birth";
            // 
            // medt_dob
            // 
            this.medt_dob.Location = new System.Drawing.Point(411, 91);
            this.medt_dob.Mask = "00/00/0000";
            this.medt_dob.Name = "medt_dob";
            this.medt_dob.Size = new System.Drawing.Size(87, 22);
            this.medt_dob.TabIndex = 15;
            this.medt_dob.ValidatingType = typeof(System.DateTime);
            this.medt_dob.Leave += new System.EventHandler(this.medt_dob_Leave);
            // 
            // lbl_regNumber
            // 
            this.lbl_regNumber.AutoSize = true;
            this.lbl_regNumber.Location = new System.Drawing.Point(9, 72);
            this.lbl_regNumber.Name = "lbl_regNumber";
            this.lbl_regNumber.Size = new System.Drawing.Size(130, 16);
            this.lbl_regNumber.TabIndex = 17;
            this.lbl_regNumber.Text = "Registration Number";
            // 
            // medt_regNumber
            // 
            this.medt_regNumber.Location = new System.Drawing.Point(12, 91);
            this.medt_regNumber.Mask = "000.000.000-00";
            this.medt_regNumber.Name = "medt_regNumber";
            this.medt_regNumber.Size = new System.Drawing.Size(127, 22);
            this.medt_regNumber.TabIndex = 18;
            this.medt_regNumber.ValidatingType = typeof(int);
            // 
            // gb_phones
            // 
            this.gb_phones.Controls.Add(this.cbox_phone3);
            this.gb_phones.Controls.Add(this.cbox_phone2);
            this.gb_phones.Controls.Add(this.medt_phone3);
            this.gb_phones.Controls.Add(this.medt_phone2);
            this.gb_phones.Controls.Add(this.cbox_phone1);
            this.gb_phones.Controls.Add(this.medt_phone1);
            this.gb_phones.Location = new System.Drawing.Point(12, 136);
            this.gb_phones.Name = "gb_phones";
            this.gb_phones.Size = new System.Drawing.Size(235, 157);
            this.gb_phones.TabIndex = 20;
            this.gb_phones.TabStop = false;
            this.gb_phones.Text = "Contact Information";
            // 
            // cbox_phone3
            // 
            this.cbox_phone3.FormattingEnabled = true;
            this.cbox_phone3.Location = new System.Drawing.Point(133, 109);
            this.cbox_phone3.Name = "cbox_phone3";
            this.cbox_phone3.Size = new System.Drawing.Size(80, 24);
            this.cbox_phone3.TabIndex = 5;
            // 
            // cbox_phone2
            // 
            this.cbox_phone2.FormattingEnabled = true;
            this.cbox_phone2.Location = new System.Drawing.Point(133, 71);
            this.cbox_phone2.Name = "cbox_phone2";
            this.cbox_phone2.Size = new System.Drawing.Size(80, 24);
            this.cbox_phone2.TabIndex = 4;
            // 
            // medt_phone3
            // 
            this.medt_phone3.Location = new System.Drawing.Point(6, 111);
            this.medt_phone3.Mask = "(000) 00000-0000";
            this.medt_phone3.Name = "medt_phone3";
            this.medt_phone3.Size = new System.Drawing.Size(121, 22);
            this.medt_phone3.TabIndex = 3;
            // 
            // medt_phone2
            // 
            this.medt_phone2.Location = new System.Drawing.Point(6, 71);
            this.medt_phone2.Mask = "(000) 00000-0000";
            this.medt_phone2.Name = "medt_phone2";
            this.medt_phone2.Size = new System.Drawing.Size(121, 22);
            this.medt_phone2.TabIndex = 2;
            // 
            // cbox_phone1
            // 
            this.cbox_phone1.FormattingEnabled = true;
            this.cbox_phone1.Location = new System.Drawing.Point(133, 33);
            this.cbox_phone1.Name = "cbox_phone1";
            this.cbox_phone1.Size = new System.Drawing.Size(80, 24);
            this.cbox_phone1.TabIndex = 1;
            // 
            // medt_phone1
            // 
            this.medt_phone1.Location = new System.Drawing.Point(6, 33);
            this.medt_phone1.Mask = "(000) 00000-0000";
            this.medt_phone1.Name = "medt_phone1";
            this.medt_phone1.Size = new System.Drawing.Size(121, 22);
            this.medt_phone1.TabIndex = 0;
            // 
            // gb_address
            // 
            this.gb_address.Controls.Add(this.lbl_country);
            this.gb_address.Controls.Add(this.btn_findState);
            this.gb_address.Controls.Add(this.cbox_country);
            this.gb_address.Controls.Add(this.cbox_state);
            this.gb_address.Controls.Add(this.lbl_state);
            this.gb_address.Controls.Add(this.lbl_homeType);
            this.gb_address.Controls.Add(this.cbox_homeType);
            this.gb_address.Controls.Add(this.btn_findCity);
            this.gb_address.Controls.Add(this.lbl_city);
            this.gb_address.Controls.Add(this.cbox_city);
            this.gb_address.Controls.Add(this.edt_complement);
            this.gb_address.Controls.Add(this.Complement);
            this.gb_address.Controls.Add(this.edt_district);
            this.gb_address.Controls.Add(this.lbl_district);
            this.gb_address.Controls.Add(this.edt_houseNumber);
            this.gb_address.Controls.Add(this.lbl_houseNumber);
            this.gb_address.Controls.Add(this.lbl_street);
            this.gb_address.Controls.Add(this.edt_street);
            this.gb_address.Controls.Add(this.lbl_zipCode);
            this.gb_address.Controls.Add(this.medt_zipCode);
            this.gb_address.Location = new System.Drawing.Point(253, 145);
            this.gb_address.Name = "gb_address";
            this.gb_address.Size = new System.Drawing.Size(535, 264);
            this.gb_address.TabIndex = 21;
            this.gb_address.TabStop = false;
            this.gb_address.Text = "Address";
            // 
            // btn_findState
            // 
            this.btn_findState.Location = new System.Drawing.Point(418, 158);
            this.btn_findState.Name = "btn_findState";
            this.btn_findState.Size = new System.Drawing.Size(78, 24);
            this.btn_findState.TabIndex = 17;
            this.btn_findState.Text = "&Search";
            this.btn_findState.UseVisualStyleBackColor = true;
            // 
            // cbox_state
            // 
            this.cbox_state.FormattingEnabled = true;
            this.cbox_state.Location = new System.Drawing.Point(283, 159);
            this.cbox_state.Name = "cbox_state";
            this.cbox_state.Size = new System.Drawing.Size(129, 24);
            this.cbox_state.TabIndex = 16;
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(280, 140);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(38, 16);
            this.lbl_state.TabIndex = 15;
            this.lbl_state.Text = "State";
            // 
            // lbl_homeType
            // 
            this.lbl_homeType.AutoSize = true;
            this.lbl_homeType.Location = new System.Drawing.Point(6, 140);
            this.lbl_homeType.Name = "lbl_homeType";
            this.lbl_homeType.Size = new System.Drawing.Size(73, 16);
            this.lbl_homeType.TabIndex = 14;
            this.lbl_homeType.Text = "Home type";
            // 
            // cbox_homeType
            // 
            this.cbox_homeType.FormattingEnabled = true;
            this.cbox_homeType.Location = new System.Drawing.Point(9, 159);
            this.cbox_homeType.Name = "cbox_homeType";
            this.cbox_homeType.Size = new System.Drawing.Size(109, 24);
            this.cbox_homeType.TabIndex = 13;
            // 
            // btn_findCity
            // 
            this.btn_findCity.Location = new System.Drawing.Point(418, 218);
            this.btn_findCity.Name = "btn_findCity";
            this.btn_findCity.Size = new System.Drawing.Size(78, 24);
            this.btn_findCity.TabIndex = 12;
            this.btn_findCity.Text = "&Search";
            this.btn_findCity.UseVisualStyleBackColor = true;
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(6, 200);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(29, 16);
            this.lbl_city.TabIndex = 11;
            this.lbl_city.Text = "City";
            // 
            // cbox_city
            // 
            this.cbox_city.FormattingEnabled = true;
            this.cbox_city.Location = new System.Drawing.Point(9, 219);
            this.cbox_city.Name = "cbox_city";
            this.cbox_city.Size = new System.Drawing.Size(403, 24);
            this.cbox_city.TabIndex = 10;
            // 
            // edt_complement
            // 
            this.edt_complement.Location = new System.Drawing.Point(259, 109);
            this.edt_complement.Name = "edt_complement";
            this.edt_complement.Size = new System.Drawing.Size(224, 22);
            this.edt_complement.TabIndex = 9;
            // 
            // Complement
            // 
            this.Complement.AutoSize = true;
            this.Complement.Location = new System.Drawing.Point(256, 90);
            this.Complement.Name = "Complement";
            this.Complement.Size = new System.Drawing.Size(83, 16);
            this.Complement.TabIndex = 8;
            this.Complement.Text = "Complement";
            // 
            // edt_district
            // 
            this.edt_district.Location = new System.Drawing.Point(88, 109);
            this.edt_district.Name = "edt_district";
            this.edt_district.Size = new System.Drawing.Size(159, 22);
            this.edt_district.TabIndex = 7;
            // 
            // lbl_district
            // 
            this.lbl_district.AutoSize = true;
            this.lbl_district.Location = new System.Drawing.Point(85, 90);
            this.lbl_district.Name = "lbl_district";
            this.lbl_district.Size = new System.Drawing.Size(47, 16);
            this.lbl_district.TabIndex = 6;
            this.lbl_district.Text = "District";
            // 
            // edt_houseNumber
            // 
            this.edt_houseNumber.Location = new System.Drawing.Point(9, 109);
            this.edt_houseNumber.Name = "edt_houseNumber";
            this.edt_houseNumber.Size = new System.Drawing.Size(58, 22);
            this.edt_houseNumber.TabIndex = 5;
            // 
            // lbl_houseNumber
            // 
            this.lbl_houseNumber.AutoSize = true;
            this.lbl_houseNumber.Location = new System.Drawing.Point(6, 90);
            this.lbl_houseNumber.Name = "lbl_houseNumber";
            this.lbl_houseNumber.Size = new System.Drawing.Size(55, 16);
            this.lbl_houseNumber.TabIndex = 4;
            this.lbl_houseNumber.Text = "Number";
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.Location = new System.Drawing.Point(146, 25);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(79, 16);
            this.lbl_street.TabIndex = 3;
            this.lbl_street.Text = "Street name";
            // 
            // edt_street
            // 
            this.edt_street.Location = new System.Drawing.Point(149, 44);
            this.edt_street.Name = "edt_street";
            this.edt_street.Size = new System.Drawing.Size(334, 22);
            this.edt_street.TabIndex = 2;
            // 
            // lbl_zipCode
            // 
            this.lbl_zipCode.AutoSize = true;
            this.lbl_zipCode.Location = new System.Drawing.Point(6, 25);
            this.lbl_zipCode.Name = "lbl_zipCode";
            this.lbl_zipCode.Size = new System.Drawing.Size(63, 16);
            this.lbl_zipCode.TabIndex = 1;
            this.lbl_zipCode.Text = "ZIP Code";
            // 
            // medt_zipCode
            // 
            this.medt_zipCode.Location = new System.Drawing.Point(9, 44);
            this.medt_zipCode.Mask = "0000000000";
            this.medt_zipCode.Name = "medt_zipCode";
            this.medt_zipCode.Size = new System.Drawing.Size(100, 22);
            this.medt_zipCode.TabIndex = 0;
            this.medt_zipCode.ValidatingType = typeof(int);
            // 
            // edt_email
            // 
            this.edt_email.Location = new System.Drawing.Point(165, 91);
            this.edt_email.Name = "edt_email";
            this.edt_email.Size = new System.Drawing.Size(230, 22);
            this.edt_email.TabIndex = 22;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(162, 72);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(45, 16);
            this.lbl_email.TabIndex = 23;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Location = new System.Drawing.Point(121, 140);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(52, 16);
            this.lbl_country.TabIndex = 25;
            this.lbl_country.Text = "Country";
            // 
            // cbox_country
            // 
            this.cbox_country.FormattingEnabled = true;
            this.cbox_country.Location = new System.Drawing.Point(124, 159);
            this.cbox_country.Name = "cbox_country";
            this.cbox_country.Size = new System.Drawing.Size(153, 24);
            this.cbox_country.TabIndex = 24;
            // 
            // Frm_Create_Clients_Natural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.edt_email);
            this.Controls.Add(this.gb_address);
            this.Controls.Add(this.gb_phones);
            this.Controls.Add(this.medt_regNumber);
            this.Controls.Add(this.lbl_regNumber);
            this.Controls.Add(this.medt_dob);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.edt_age);
            this.Controls.Add(this.gb_gender);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.lbl_middleName);
            this.Controls.Add(this.edt_lastName);
            this.Controls.Add(this.edt_middleName);
            this.Controls.Add(this.edt_firstName);
            this.Controls.Add(this.lbl_firstName);
            this.Name = "Frm_Create_Clients_Natural";
            this.Controls.SetChildIndex(this.lbl_firstName, 0);
            this.Controls.SetChildIndex(this.edt_firstName, 0);
            this.Controls.SetChildIndex(this.edt_middleName, 0);
            this.Controls.SetChildIndex(this.edt_lastName, 0);
            this.Controls.SetChildIndex(this.lbl_middleName, 0);
            this.Controls.SetChildIndex(this.lbl_lastName, 0);
            this.Controls.SetChildIndex(this.gb_gender, 0);
            this.Controls.SetChildIndex(this.edt_age, 0);
            this.Controls.SetChildIndex(this.lbl_age, 0);
            this.Controls.SetChildIndex(this.lbl_dob, 0);
            this.Controls.SetChildIndex(this.medt_dob, 0);
            this.Controls.SetChildIndex(this.lbl_regNumber, 0);
            this.Controls.SetChildIndex(this.medt_regNumber, 0);
            this.Controls.SetChildIndex(this.gb_phones, 0);
            this.Controls.SetChildIndex(this.gb_address, 0);
            this.Controls.SetChildIndex(this.edt_email, 0);
            this.Controls.SetChildIndex(this.lbl_email, 0);
            this.gb_gender.ResumeLayout(false);
            this.gb_gender.PerformLayout();
            this.gb_phones.ResumeLayout(false);
            this.gb_phones.PerformLayout();
            this.gb_address.ResumeLayout(false);
            this.gb_address.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.TextBox edt_firstName;
        private System.Windows.Forms.TextBox edt_middleName;
        private System.Windows.Forms.TextBox edt_lastName;
        private System.Windows.Forms.Label lbl_middleName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.GroupBox gb_gender;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.RadioButton rbtn_female;
        private System.Windows.Forms.RadioButton rbtn_otherGender;
        private System.Windows.Forms.TextBox edt_age;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.MaskedTextBox medt_dob;
        private System.Windows.Forms.Label lbl_regNumber;
        private System.Windows.Forms.MaskedTextBox medt_regNumber;
        private System.Windows.Forms.GroupBox gb_phones;
        private System.Windows.Forms.ComboBox cbox_phone3;
        private System.Windows.Forms.ComboBox cbox_phone2;
        private System.Windows.Forms.MaskedTextBox medt_phone3;
        private System.Windows.Forms.MaskedTextBox medt_phone2;
        private System.Windows.Forms.ComboBox cbox_phone1;
        private System.Windows.Forms.MaskedTextBox medt_phone1;
        private System.Windows.Forms.GroupBox gb_address;
        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.TextBox edt_street;
        private System.Windows.Forms.Label lbl_zipCode;
        private System.Windows.Forms.MaskedTextBox medt_zipCode;
        private System.Windows.Forms.Label lbl_houseNumber;
        private System.Windows.Forms.Label lbl_homeType;
        private System.Windows.Forms.ComboBox cbox_homeType;
        private System.Windows.Forms.Button btn_findCity;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.ComboBox cbox_city;
        private System.Windows.Forms.TextBox edt_complement;
        private System.Windows.Forms.Label Complement;
        private System.Windows.Forms.TextBox edt_district;
        private System.Windows.Forms.Label lbl_district;
        private System.Windows.Forms.TextBox edt_houseNumber;
        private System.Windows.Forms.TextBox edt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.ComboBox cbox_state;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Button btn_findState;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.ComboBox cbox_country;
    }
}
