using ProjetoEduardoAnacletoWindowsForm1.FormsUD;
using ProjetoEduardoAnacletoWindowsForm1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.FormsFindSeach
{
    public partial class Frm_Find_Clients_Natural : ProjetoEduardoAnacletoWindowsForm1.InheritForms.Frm_Find_Master
    {
        public Frm_Find_Clients_Natural()
        {
            InitializeComponent();
        }

        public bool CheckCamps()
        {
            if (edt_firstName.Text == string.Empty &&
                edt_lastName.Text == string.Empty &&
                medt_regNumber.Text == string.Empty)
                return false;

            else return true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckCamps())
                {
                    string searchValue = null;
                    int cellNum = 0;
                    if (medt_regNumber != null)
                    {
                        searchValue = medt_regNumber.Text;
                        cellNum = 1;
                    }
                    else if (edt_firstName != null)
                    {
                        searchValue = edt_firstName.Text;
                        cellNum = 2;
                    }
                    else
                    {
                        searchValue = edt_lastName.Text;
                        cellNum = 3;
                    }

                    foreach (DataGridViewRow row in dgv_client_natural.Rows)
                    {
                        if (row.Cells[cellNum].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        public override void Select()
        {
            string selectedRow = dgv_client_natural.SelectedCells[1].Value.ToString();
            Clients client = new Clients();
            client = (Clients)dgv_client_natural.CurrentRow.DataBoundItem;
            Frm_UD_Clients_Natural frm_UD_Clients_Natural = new Frm_UD_Clients_Natural(client);
            frm_UD_Clients_Natural.ShowDialog();
        }
    }
}
