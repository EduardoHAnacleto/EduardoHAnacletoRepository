using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Create_Clients_Natural : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_Clients_Natural()
        {
            InitializeComponent();
        }

        public override void Save()
        {
            ValidateCamps();
            base.Save();
        }

        private void rbtn_otherGender_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_female.Checked = false;
            rbtn_male.Checked = false;
        }

        private void medt_dob_Leave(object sender, EventArgs e)
        {
            //edt_age.Text = medt_dob.TextMaskFormat - DateTime.Now;
        }

        private void rbtn_male_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_female.Checked = false;
            rbtn_otherGender.Checked = false;
        }

        private void rbtn_female_CheckedChanged(object sender, EventArgs e)
        {
            rbtn_male.Checked = false;
            rbtn_otherGender.Checked = false;
        }

        public void Msgbox(string message, string caption, MessageBoxButtons buttons)
        {
            MessageBox.Show(message, caption, buttons);
        }

        public void ValidateCamps()
        {
            if (edt_firstName.Text.Trim() == "")
            {
                string message = "First name text camp is empty.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                edt_firstName.Focus();
            }

            else if (edt_lastName.Text.Trim() == "")
            {
                string message = "Last name camp is empty.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                edt_lastName.Focus();
            }

            else if (!Validator.isEmail(edt_email.Text))
            {
                string message = "Email text camp is invalid.";
                string caption = "Required camp is invalid.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                edt_email.Focus();
            }

            else if (edt_houseNumber.Text.Trim() == "")
            {
                string message = "Building number text camp is empty.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                edt_houseNumber.Focus();
            }

            else if (medt_phone1.Text.Trim() == "")
            {
                string message = "Phone text camp is empty.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                medt_phone1.Focus();
            }

            else if (cbox_phone1.Text == null)
            {
                string message = "Phone type is empty.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                cbox_phone1.Focus();
            }

            else if (!Validator.IsCpf(medt_regNumber.Text))
            {
                string message = "Registration number text camp is empty.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                medt_regNumber.Focus();
            }

            if (edt_district.Text.Trim() == "")
            {
                string message = "District text camp is empty.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                edt_district.Focus();
            }

            else if (edt_street.Text.Trim() == "")
            {
                string message = "Street name text camp is empty.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                edt_street.Focus();
            }

            else if (medt_zipCode.Text.Trim() == "")
            {
                string message = "ZIP Code text camp is empty.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                medt_zipCode.Focus();
            }

            else if (cbox_city.Text == null)
            {
                string message = "City camp must be selected.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                cbox_city.Focus();
            }

            else if (cbox_homeType.Text == null)
            {
                string message = "Home type camp must be selected.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                cbox_homeType.Focus();
            }

            else if (cbox_state.Text == null)
            {
                string message = "State camp must be selected.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                cbox_state.Focus();
            }

        }
    }
}
