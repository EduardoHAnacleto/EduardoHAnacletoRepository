namespace ProjetoEduardoAnacletoWindowsForm1.InheritForms
{
    partial class Frm_Find_Master
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.edt_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(713, 415);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exi&t";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(622, 415);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "Sele&ct";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 16);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "ID";
            // 
            // edt_id
            // 
            this.edt_id.Enabled = false;
            this.edt_id.Location = new System.Drawing.Point(15, 28);
            this.edt_id.Name = "edt_id";
            this.edt_id.Size = new System.Drawing.Size(67, 22);
            this.edt_id.TabIndex = 3;
            // 
            // Frm_Find_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_exit);
            this.Name = "Frm_Find_Master";
            this.Text = "Frm_Find_Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox edt_id;
        protected System.Windows.Forms.Button btn_select;
    }
}