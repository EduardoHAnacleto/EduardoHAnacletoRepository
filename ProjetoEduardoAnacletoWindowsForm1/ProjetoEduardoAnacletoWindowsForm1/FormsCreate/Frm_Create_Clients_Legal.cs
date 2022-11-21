using ProjetoEduardoAnacletoWindowsForm1.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsCreate
{
    public partial class Frm_Create_Clients_Legal : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Create_Master
    {
        public Frm_Create_Clients_Legal()
        {
            InitializeComponent();
        }
        
        public override void Save()
        {
            ValidateCamps();
            base.Save();
        }

        private void check_noAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (check_noAddress.Checked)
                gb_address.Enabled = false;
            else if (!check_noAddress.Checked)
                gb_address.Enabled = true;
        }

        public void ShowStates()
        {
            if (cbox_country.SelectedValue != null)
            {
                btn_findState.Enabled = true;
                cbox_state.Enabled = true; 
                cbox_state.DataSource = cbox_country.SelectedValue.ToString();
            }
        }

        public void ShowCities() //?
        {
            if (cbox_state.SelectedValue != null)
            {
                btn_findCity.Enabled = true;
                cbox_city.Enabled = true;
                cbox_city.DataSource = cbox_state.SelectedValue.ToString();
            }
        }

        public void Msgbox(string message, string caption, MessageBoxButtons buttons) {
            MessageBox.Show(message, caption, buttons); 
        }

        public void ValidateCamps()
        {
            if (edt_compName.Text.Trim() == "") {
                string message = "Company name text camp is empty.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                edt_compName.Focus();
            }


            else if (!Validator.isEmail(edt_email.Text)){
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

            else if (medt_regNumber.Text.Trim() == "")
            {
                string message = "Registration number text camp is empty.";
                string caption = "Required camp is empty.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                this.Msgbox(message, caption, buttons);
                medt_regNumber.Focus();
            }

            else if (!check_noAddress.Checked) {
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

                else if (cbox_country.Text == null)
                {
                    string message = "Country camp must be selected.";
                    string caption = "Required camp is empty.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    this.Msgbox(message, caption, buttons);
                    cbox_country.Focus();
                }
            }
        }
    }
}
