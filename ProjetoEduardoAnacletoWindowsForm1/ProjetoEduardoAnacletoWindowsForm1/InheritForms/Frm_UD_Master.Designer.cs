namespace ProjetoEduardoAnacletoWindowsForm1.InheritForms
{
    partial class Frm_UD_Master
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.edt_id = new System.Windows.Forms.TextBox();
            this.lbl_dateCreated = new System.Windows.Forms.Label();
            this.lbl_dateUpdated = new System.Windows.Forms.Label();
            this.mbox_dateCreated = new System.Windows.Forms.MaskedTextBox();
            this.mbox_dateUpdated = new System.Windows.Forms.MaskedTextBox();
            this.gbox_date = new System.Windows.Forms.GroupBox();
            this.gbox_date.SuspendLayout();
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
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(622, 415);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(541, 415);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Upd&ate";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 16);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "ID";
            // 
            // edt_id
            // 
            this.edt_id.Enabled = false;
            this.edt_id.Location = new System.Drawing.Point(15, 28);
            this.edt_id.Name = "edt_id";
            this.edt_id.Size = new System.Drawing.Size(71, 22);
            this.edt_id.TabIndex = 4;
            this.edt_id.TabStop = false;
            // 
            // lbl_dateCreated
            // 
            this.lbl_dateCreated.AutoSize = true;
            this.lbl_dateCreated.Location = new System.Drawing.Point(3, 27);
            this.lbl_dateCreated.Name = "lbl_dateCreated";
            this.lbl_dateCreated.Size = new System.Drawing.Size(76, 16);
            this.lbl_dateCreated.TabIndex = 5;
            this.lbl_dateCreated.Text = "Created on:";
            // 
            // lbl_dateUpdated
            // 
            this.lbl_dateUpdated.AutoSize = true;
            this.lbl_dateUpdated.Location = new System.Drawing.Point(104, 27);
            this.lbl_dateUpdated.Name = "lbl_dateUpdated";
            this.lbl_dateUpdated.Size = new System.Drawing.Size(81, 16);
            this.lbl_dateUpdated.TabIndex = 6;
            this.lbl_dateUpdated.Text = "Updated on:";
            // 
            // mbox_dateCreated
            // 
            this.mbox_dateCreated.Enabled = false;
            this.mbox_dateCreated.Location = new System.Drawing.Point(6, 46);
            this.mbox_dateCreated.Mask = "00/00/0000";
            this.mbox_dateCreated.Name = "mbox_dateCreated";
            this.mbox_dateCreated.Size = new System.Drawing.Size(95, 22);
            this.mbox_dateCreated.TabIndex = 7;
            this.mbox_dateCreated.TabStop = false;
            this.mbox_dateCreated.ValidatingType = typeof(System.DateTime);
            // 
            // mbox_dateUpdated
            // 
            this.mbox_dateUpdated.Enabled = false;
            this.mbox_dateUpdated.Location = new System.Drawing.Point(107, 46);
            this.mbox_dateUpdated.Mask = "00/00/0000";
            this.mbox_dateUpdated.Name = "mbox_dateUpdated";
            this.mbox_dateUpdated.Size = new System.Drawing.Size(78, 22);
            this.mbox_dateUpdated.TabIndex = 8;
            this.mbox_dateUpdated.TabStop = false;
            this.mbox_dateUpdated.ValidatingType = typeof(System.DateTime);
            // 
            // gbox_date
            // 
            this.gbox_date.Controls.Add(this.lbl_dateCreated);
            this.gbox_date.Controls.Add(this.lbl_dateUpdated);
            this.gbox_date.Controls.Add(this.mbox_dateUpdated);
            this.gbox_date.Controls.Add(this.mbox_dateCreated);
            this.gbox_date.Enabled = false;
            this.gbox_date.Location = new System.Drawing.Point(15, 363);
            this.gbox_date.Name = "gbox_date";
            this.gbox_date.Size = new System.Drawing.Size(198, 75);
            this.gbox_date.TabIndex = 9;
            this.gbox_date.TabStop = false;
            // 
            // Frm_UD_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbox_date);
            this.Controls.Add(this.edt_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_exit);
            this.Name = "Frm_UD_Master";
            this.Text = "Frm_UD_Master";
            this.gbox_date.ResumeLayout(false);
            this.gbox_date.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_dateCreated;
        private System.Windows.Forms.Label lbl_dateUpdated;
        private System.Windows.Forms.GroupBox gbox_date;
        protected System.Windows.Forms.MaskedTextBox mbox_dateCreated;
        protected System.Windows.Forms.MaskedTextBox mbox_dateUpdated;
        protected System.Windows.Forms.TextBox edt_id;
    }
}