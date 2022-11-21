namespace ProjetoEduardoAnacletoWindowsForm1.InheritForms
{
    partial class Frm_Create_Master
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
            this.edt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edt_id
            // 
            this.edt_id.Enabled = false;
            this.edt_id.Location = new System.Drawing.Point(12, 28);
            this.edt_id.Name = "edt_id";
            this.edt_id.Size = new System.Drawing.Size(60, 22);
            this.edt_id.TabIndex = 0;
            this.edt_id.TabStop = false;
            this.edt_id.Visible = false;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(9, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 16);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(713, 415);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(623, 415);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Frm_Create_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.edt_id);
            this.Name = "Frm_Create_Master";
            this.Text = "Frm_Create_Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_exit;
        protected System.Windows.Forms.Button btn_save;
    }
}