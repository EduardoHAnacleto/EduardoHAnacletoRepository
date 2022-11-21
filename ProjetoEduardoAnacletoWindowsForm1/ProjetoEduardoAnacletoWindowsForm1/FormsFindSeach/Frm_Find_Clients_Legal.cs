using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsFindSeach
{
    public partial class Frm_Find_Clients_Legal : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_Clients_Legal()
        {
            InitializeComponent();
        }

        public override void Select()
        {
            //Select
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            if ((edt_compName.Text.Trim() == "") && (medt_regNumber.Text.Trim() == ""))
            {
                MessageBox.Show("Camps are empty.", "Required camps are empty.", MessageBoxButtons.OK);
            }
            
            else if (!string.IsNullOrEmpty(edt_compName.Text.Trim()) || (!string.IsNullOrWhiteSpace(edt_compName.Text.Trim())))
            {
                //PesquisaNome
            }

            else if (!string.IsNullOrEmpty(medt_regNumber.Text.Trim()) || (!string.IsNullOrWhiteSpace(medt_regNumber.Text.Trim())))
            {
                //PesquisaRegistro
            }
        }

    }
}
