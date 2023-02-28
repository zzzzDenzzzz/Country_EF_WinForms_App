namespace Country_EF_WinForms_App.Forms
{
    partial class QueryForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.gridQuery = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(12, 415);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // gridQuery
            // 
            this.gridQuery.AllowUserToAddRows = false;
            this.gridQuery.AllowUserToDeleteRows = false;
            this.gridQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQuery.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridQuery.Location = new System.Drawing.Point(12, 12);
            this.gridQuery.Name = "gridQuery";
            this.gridQuery.ReadOnly = true;
            this.gridQuery.RowHeadersVisible = false;
            this.gridQuery.RowTemplate.Height = 23;
            this.gridQuery.Size = new System.Drawing.Size(776, 397);
            this.gridQuery.TabIndex = 1;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridQuery);
            this.Controls.Add(this.btnOk);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOk;
        public DataGridView gridQuery;
    }
}