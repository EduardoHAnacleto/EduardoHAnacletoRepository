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
    public partial class Frm_Create_Master : Form
    {
        public Frm_Create_Master()
        {
            InitializeComponent();
        }

        public virtual void Save()
        {

        }

        public void Exit()
        {
            Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
