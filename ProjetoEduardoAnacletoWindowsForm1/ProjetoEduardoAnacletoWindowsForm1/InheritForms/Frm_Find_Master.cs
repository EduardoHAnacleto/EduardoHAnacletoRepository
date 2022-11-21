using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.InheritForms
{
    public partial class Frm_Find_Master : Form
    {
        public Frm_Find_Master()
        {
            InitializeComponent();
        }

        public void Exit()
        {
            Close();
        }

        public virtual void Select()
        {
           //Select
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            Select();
        }
    }
}
