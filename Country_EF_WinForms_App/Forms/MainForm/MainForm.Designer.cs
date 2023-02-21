namespace Country_EF_WinForms_App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCountries = new System.Windows.Forms.TabPage();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.btnUpdateCountry = new System.Windows.Forms.Button();
            this.btnCreateCountry = new System.Windows.Forms.Button();
            this.gridCountries = new System.Windows.Forms.DataGridView();
            this.tabPageCities = new System.Windows.Forms.TabPage();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.btnUpdateCity = new System.Windows.Forms.Button();
            this.btnCreateCity = new System.Windows.Forms.Button();
            this.gridCities = new System.Windows.Forms.DataGridView();
            this.tabControlMain.SuspendLayout();
            this.tabPageCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCountries)).BeginInit();
            this.tabPageCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCities)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCountries);
            this.tabControlMain.Controls.Add(this.tabPageCities);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 426);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
            // 
            // tabPageCountries
            // 
            this.tabPageCountries.Controls.Add(this.btnDeleteCountry);
            this.tabPageCountries.Controls.Add(this.btnUpdateCountry);
            this.tabPageCountries.Controls.Add(this.btnCreateCountry);
            this.tabPageCountries.Controls.Add(this.gridCountries);
            this.tabPageCountries.Location = new System.Drawing.Point(4, 24);
            this.tabPageCountries.Name = "tabPageCountries";
            this.tabPageCountries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCountries.Size = new System.Drawing.Size(768, 398);
            this.tabPageCountries.TabIndex = 0;
            this.tabPageCountries.Text = "Страны";
            this.tabPageCountries.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.Location = new System.Drawing.Point(168, 364);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCountry.TabIndex = 3;
            this.btnDeleteCountry.Text = "Удалить";
            this.btnDeleteCountry.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCountry
            // 
            this.btnUpdateCountry.Location = new System.Drawing.Point(87, 364);
            this.btnUpdateCountry.Name = "btnUpdateCountry";
            this.btnUpdateCountry.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCountry.TabIndex = 2;
            this.btnUpdateCountry.Text = "Изменить";
            this.btnUpdateCountry.UseVisualStyleBackColor = true;
            // 
            // btnCreateCountry
            // 
            this.btnCreateCountry.Location = new System.Drawing.Point(6, 364);
            this.btnCreateCountry.Name = "btnCreateCountry";
            this.btnCreateCountry.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCountry.TabIndex = 1;
            this.btnCreateCountry.Text = "Добавить";
            this.btnCreateCountry.UseVisualStyleBackColor = true;
            this.btnCreateCountry.Click += new System.EventHandler(this.BtnCreateCountry_Click);
            // 
            // gridCountries
            // 
            this.gridCountries.AllowUserToAddRows = false;
            this.gridCountries.AllowUserToDeleteRows = false;
            this.gridCountries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCountries.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCountries.Location = new System.Drawing.Point(3, 6);
            this.gridCountries.Name = "gridCountries";
            this.gridCountries.ReadOnly = true;
            this.gridCountries.RowHeadersVisible = false;
            this.gridCountries.RowTemplate.Height = 25;
            this.gridCountries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCountries.Size = new System.Drawing.Size(760, 352);
            this.gridCountries.TabIndex = 0;
            // 
            // tabPageCities
            // 
            this.tabPageCities.Controls.Add(this.btnDeleteCity);
            this.tabPageCities.Controls.Add(this.btnUpdateCity);
            this.tabPageCities.Controls.Add(this.btnCreateCity);
            this.tabPageCities.Controls.Add(this.gridCities);
            this.tabPageCities.Location = new System.Drawing.Point(4, 24);
            this.tabPageCities.Name = "tabPageCities";
            this.tabPageCities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCities.Size = new System.Drawing.Size(768, 398);
            this.tabPageCities.TabIndex = 1;
            this.tabPageCities.Text = "Города";
            this.tabPageCities.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.Location = new System.Drawing.Point(168, 361);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCity.TabIndex = 3;
            this.btnDeleteCity.Text = "Удалить";
            this.btnDeleteCity.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCity
            // 
            this.btnUpdateCity.Location = new System.Drawing.Point(87, 361);
            this.btnUpdateCity.Name = "btnUpdateCity";
            this.btnUpdateCity.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCity.TabIndex = 2;
            this.btnUpdateCity.Text = "Изменить";
            this.btnUpdateCity.UseVisualStyleBackColor = true;
            // 
            // btnCreateCity
            // 
            this.btnCreateCity.Location = new System.Drawing.Point(6, 361);
            this.btnCreateCity.Name = "btnCreateCity";
            this.btnCreateCity.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCity.TabIndex = 1;
            this.btnCreateCity.Text = "Добавить";
            this.btnCreateCity.UseVisualStyleBackColor = true;
            // 
            // gridCities
            // 
            this.gridCities.AllowUserToAddRows = false;
            this.gridCities.AllowUserToDeleteRows = false;
            this.gridCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCities.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCities.Location = new System.Drawing.Point(3, 3);
            this.gridCities.Name = "gridCities";
            this.gridCities.ReadOnly = true;
            this.gridCities.RowHeadersVisible = false;
            this.gridCities.RowTemplate.Height = 25;
            this.gridCities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCities.Size = new System.Drawing.Size(760, 352);
            this.gridCities.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCountries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCountries)).EndInit();
            this.tabPageCities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageCountries;
        private TabPage tabPageCities;
        private DataGridView gridCountries;
        private Button btnDeleteCountry;
        private Button btnUpdateCountry;
        private Button btnCreateCountry;
        private DataGridView gridCities;
        private Button btnCreateCity;
        private Button btnDeleteCity;
        private Button btnUpdateCity;
    }
}