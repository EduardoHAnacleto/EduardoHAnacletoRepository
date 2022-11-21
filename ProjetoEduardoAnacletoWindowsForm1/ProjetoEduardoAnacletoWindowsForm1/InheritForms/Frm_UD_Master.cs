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
    public partial class Frm_UD_Master : Form
    {
        public Frm_UD_Master()
        {
            InitializeComponent();
        }

        public virtual void Delete()
        {

        }

        public virtual void Update()
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
