namespace ProjetoEduardoAnacletoWindowsForm1.FormsFindSeach
{
    partial class Frm_Find_Clients_Legal
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
            this.dgv_client_legal = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.medt_regNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbl_regNumber = new System.Windows.Forms.Label();
            this.edt_compName = new System.Windows.Forms.TextBox();
            this.lbl_compName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client_legal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_client_legal
            // 
            this.dgv_client_legal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client_legal.Location = new System.Drawing.Point(12, 88);
            this.dgv_client_legal.Name = "dgv_client_legal";
            this.dgv_client_legal.RowHeadersWidth = 51;
            this.dgv_client_legal.RowTemplate.Height = 24;
            this.dgv_client_legal.Size = new System.Drawing.Size(773, 321);
            this.dgv_client_legal.TabIndex = 44;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(514, 28);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 43;
            this.btn_search.Text = "&Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // medt_regNumber
            // 
            this.medt_regNumber.Location = new System.Drawing.Point(381, 28);
            this.medt_regNumber.Mask = "000.000.000-00";
            this.medt_regNumber.Name = "medt_regNumber";
            this.medt_regNumber.Size = new System.Drawing.Size(127, 22);
            this.medt_regNumber.TabIndex = 42;
            this.medt_regNumber.ValidatingType = typeof(int);
            // 
            // lbl_regNumber
            // 
            this.lbl_regNumber.AutoSize = true;
            this.lbl_regNumber.Location = new System.Drawing.Point(378, 9);
            this.lbl_regNumber.Name = "lbl_regNumber";
            this.lbl_regNumber.Size = new System.Drawing.Size(130, 16);
            this.lbl_regNumber.TabIndex = 41;
            this.lbl_regNumber.Text = "Registration Number";
            // 
            // edt_compName
            // 
            this.edt_compName.Location = new System.Drawing.Point(88, 28);
            this.edt_compName.Name = "edt_compName";
            this.edt_compName.Size = new System.Drawing.Size(287, 22);
            this.edt_compName.TabIndex = 40;
            // 
            // lbl_compName
            // 
            this.lbl_compName.AutoSize = true;
            this.lbl_compName.Location = new System.Drawing.Point(85, 9);
            this.lbl_compName.Name = "lbl_compName";
            this.lbl_compName.Size = new System.Drawing.Size(102, 16);
            this.lbl_compName.TabIndex = 39;
            this.lbl_compName.Text = "Company name";
            // 
            // Frm_Find_Clients_Legal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_client_legal);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.medt_regNumber);
            this.Controls.Add(this.lbl_regNumber);
            this.Controls.Add(this.edt_compName);
            this.Controls.Add(this.lbl_compName);
            this.Name = "Frm_Find_Clients_Legal";
            this.Controls.SetChildIndex(this.lbl_compName, 0);
            this.Controls.SetChildIndex(this.edt_compName, 0);
            this.Controls.SetChildIndex(this.lbl_regNumber, 0);
            this.Controls.SetChildIndex(this.medt_regNumber, 0);
            this.Controls.SetChildIndex(this.btn_search, 0);
            this.Controls.SetChildIndex(this.dgv_client_legal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client_legal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_client_legal;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.MaskedTextBox medt_regNumber;
        private System.Windows.Forms.Label lbl_regNumber;
        private System.Windows.Forms.TextBox edt_compName;
        private System.Windows.Forms.Label lbl_compName;
    }
}
