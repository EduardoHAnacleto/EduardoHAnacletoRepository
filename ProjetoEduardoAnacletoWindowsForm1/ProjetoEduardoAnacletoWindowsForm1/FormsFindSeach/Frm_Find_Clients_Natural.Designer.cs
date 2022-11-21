namespace ProjetoEduardoAnacletoWindowsForm1.FormsFindSeach
{
    partial class Frm_Find_Clients_Natural
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.medt_regNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbl_regNumber = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.edt_lastName = new System.Windows.Forms.TextBox();
            this.edt_firstName = new System.Windows.Forms.TextBox();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_client_natural = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client_natural)).BeginInit();
            this.SuspendLayout();
            // 
            // medt_regNumber
            // 
            this.medt_regNumber.Location = new System.Drawing.Point(432, 28);
            this.medt_regNumber.Mask = "000.000.000-00";
            this.medt_regNumber.Name = "medt_regNumber";
            this.medt_regNumber.Size = new System.Drawing.Size(127, 22);
            this.medt_regNumber.TabIndex = 36;
            this.medt_regNumber.ValidatingType = typeof(int);
            // 
            // lbl_regNumber
            // 
            this.lbl_regNumber.AutoSize = true;
            this.lbl_regNumber.Location = new System.Drawing.Point(429, 9);
            this.lbl_regNumber.Name = "lbl_regNumber";
            this.lbl_regNumber.Size = new System.Drawing.Size(130, 16);
            this.lbl_regNumber.TabIndex = 35;
            this.lbl_regNumber.Text = "Registration Number";
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(246, 9);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(69, 16);
            this.lbl_lastName.TabIndex = 29;
            this.lbl_lastName.Text = "Last name";
            // 
            // edt_lastName
            // 
            this.edt_lastName.Location = new System.Drawing.Point(249, 28);
            this.edt_lastName.Name = "edt_lastName";
            this.edt_lastName.Size = new System.Drawing.Size(165, 22);
            this.edt_lastName.TabIndex = 27;
            // 
            // edt_firstName
            // 
            this.edt_firstName.Location = new System.Drawing.Point(91, 28);
            this.edt_firstName.Name = "edt_firstName";
            this.edt_firstName.Size = new System.Drawing.Size(152, 22);
            this.edt_firstName.TabIndex = 25;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(88, 9);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(69, 16);
            this.lbl_firstName.TabIndex = 24;
            this.lbl_firstName.Text = "First name";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(565, 27);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 37;
            this.btn_search.Text = "&Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_client_natural
            // 
            this.dgv_client_natural.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client_natural.Location = new System.Drawing.Point(15, 88);
            this.dgv_client_natural.Name = "dgv_client_natural";
            this.dgv_client_natural.RowHeadersWidth = 51;
            this.dgv_client_natural.RowTemplate.Height = 24;
            this.dgv_client_natural.Size = new System.Drawing.Size(773, 321);
            this.dgv_client_natural.TabIndex = 38;
            // 
            // Frm_Find_Clients_Natural
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_client_natural);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.medt_regNumber);
            this.Controls.Add(this.lbl_regNumber);
            this.Controls.Add(this.lbl_lastName);
            this.Controls.Add(this.edt_lastName);
            this.Controls.Add(this.edt_firstName);
            this.Controls.Add(this.lbl_firstName);
            this.Name = "Frm_Find_Clients_Natural";
            this.Controls.SetChildIndex(this.lbl_firstName, 0);
            this.Controls.SetChildIndex(this.edt_firstName, 0);
            this.Controls.SetChildIndex(this.edt_lastName, 0);
            this.Controls.SetChildIndex(this.lbl_lastName, 0);
            this.Controls.SetChildIndex(this.lbl_regNumber, 0);
            this.Controls.SetChildIndex(this.medt_regNumber, 0);
            this.Controls.SetChildIndex(this.btn_search, 0);
            this.Controls.SetChildIndex(this.dgv_client_natural, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client_natural)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox medt_regNumber;
        private System.Windows.Forms.Label lbl_regNumber;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox edt_lastName;
        private System.Windows.Forms.TextBox edt_firstName;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_client_natural;
    }
}
