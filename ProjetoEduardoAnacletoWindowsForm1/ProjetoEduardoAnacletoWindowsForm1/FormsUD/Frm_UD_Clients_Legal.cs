using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsUD
{
    public partial class Frm_UD_Clients_Legal : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_UD_Master
    {
        public Frm_UD_Clients_Legal()
        {
            InitializeComponent();
        }

        private void check_noAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (check_noAddress.Checked)
                gb_address.Enabled = false;
            if (!check_noAddress.Checked)
                gb_address.Enabled = true;
        }
    }
}
