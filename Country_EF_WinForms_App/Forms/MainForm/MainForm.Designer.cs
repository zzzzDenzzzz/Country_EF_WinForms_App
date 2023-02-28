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
            this.tabPageQueries = new System.Windows.Forms.TabPage();
            this.btnGetCapitalContainsLetter = new System.Windows.Forms.Button();
            this.btnGetEuropianCountries = new System.Windows.Forms.Button();
            this.btnGetCapitalsSetPopulation = new System.Windows.Forms.Button();
            this.btnGetCapital = new System.Windows.Forms.Button();
            this.btnGetCapitalStartWithLetter = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCountries)).BeginInit();
            this.tabPageCities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCities)).BeginInit();
            this.tabPageQueries.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCountries);
            this.tabControlMain.Controls.Add(this.tabPageCities);
            this.tabControlMain.Controls.Add(this.tabPageQueries);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(776, 426);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.MainForm_Load);
            // 
            // tabPageCountries
            // 
            this.tabPageCountries.Controls.Add(this.btnDeleteCountry);
            this.tabPageCountries.Controls.Add(this.btnUpdateCountry);
            this.tabPageCountries.Controls.Add(this.btnCreateCountry);
            this.tabPageCountries.Controls.Add(this.gridCountries);
            this.tabPageCountries.Location = new System.Drawing.Point(4, 24);
            this.tabPageCountries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCountries.Name = "tabPageCountries";
            this.tabPageCountries.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCountries.Size = new System.Drawing.Size(768, 398);
            this.tabPageCountries.TabIndex = 0;
            this.tabPageCountries.Text = "Страны";
            this.tabPageCountries.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.Location = new System.Drawing.Point(168, 363);
            this.btnDeleteCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCountry.TabIndex = 3;
            this.btnDeleteCountry.Text = "Удалить";
            this.btnDeleteCountry.UseVisualStyleBackColor = true;
            this.btnDeleteCountry.Click += new System.EventHandler(this.BtnDeleteCountry_Click);
            // 
            // btnUpdateCountry
            // 
            this.btnUpdateCountry.Location = new System.Drawing.Point(88, 363);
            this.btnUpdateCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateCountry.Name = "btnUpdateCountry";
            this.btnUpdateCountry.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCountry.TabIndex = 2;
            this.btnUpdateCountry.Text = "Изменить";
            this.btnUpdateCountry.UseVisualStyleBackColor = true;
            this.btnUpdateCountry.Click += new System.EventHandler(this.BtnUpdateCountry_Click);
            // 
            // btnCreateCountry
            // 
            this.btnCreateCountry.Location = new System.Drawing.Point(6, 363);
            this.btnCreateCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.gridCountries.Location = new System.Drawing.Point(4, 6);
            this.gridCountries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.tabPageCities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCities.Name = "tabPageCities";
            this.tabPageCities.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageCities.Size = new System.Drawing.Size(768, 398);
            this.tabPageCities.TabIndex = 1;
            this.tabPageCities.Text = "Города";
            this.tabPageCities.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.Location = new System.Drawing.Point(168, 361);
            this.btnDeleteCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCity.TabIndex = 3;
            this.btnDeleteCity.Text = "Удалить";
            this.btnDeleteCity.UseVisualStyleBackColor = true;
            this.btnDeleteCity.Click += new System.EventHandler(this.BtnDeleteCity_Click);
            // 
            // btnUpdateCity
            // 
            this.btnUpdateCity.Location = new System.Drawing.Point(88, 361);
            this.btnUpdateCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateCity.Name = "btnUpdateCity";
            this.btnUpdateCity.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCity.TabIndex = 2;
            this.btnUpdateCity.Text = "Изменить";
            this.btnUpdateCity.UseVisualStyleBackColor = true;
            this.btnUpdateCity.Click += new System.EventHandler(this.BtnUpdateCity_Click);
            // 
            // btnCreateCity
            // 
            this.btnCreateCity.Location = new System.Drawing.Point(6, 361);
            this.btnCreateCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateCity.Name = "btnCreateCity";
            this.btnCreateCity.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCity.TabIndex = 1;
            this.btnCreateCity.Text = "Добавить";
            this.btnCreateCity.UseVisualStyleBackColor = true;
            this.btnCreateCity.Click += new System.EventHandler(this.BtnCreateCity_Click);
            // 
            // gridCities
            // 
            this.gridCities.AllowUserToAddRows = false;
            this.gridCities.AllowUserToDeleteRows = false;
            this.gridCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCities.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridCities.Location = new System.Drawing.Point(4, 3);
            this.gridCities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gridCities.Name = "gridCities";
            this.gridCities.ReadOnly = true;
            this.gridCities.RowHeadersVisible = false;
            this.gridCities.RowTemplate.Height = 25;
            this.gridCities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCities.Size = new System.Drawing.Size(760, 352);
            this.gridCities.TabIndex = 0;
            // 
            // tabPageQueries
            // 
            this.tabPageQueries.Controls.Add(this.btnGetCapitalStartWithLetter);
            this.tabPageQueries.Controls.Add(this.btnGetCapitalContainsLetter);
            this.tabPageQueries.Controls.Add(this.btnGetEuropianCountries);
            this.tabPageQueries.Controls.Add(this.btnGetCapitalsSetPopulation);
            this.tabPageQueries.Controls.Add(this.btnGetCapital);
            this.tabPageQueries.Location = new System.Drawing.Point(4, 24);
            this.tabPageQueries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageQueries.Name = "tabPageQueries";
            this.tabPageQueries.Size = new System.Drawing.Size(768, 398);
            this.tabPageQueries.TabIndex = 2;
            this.tabPageQueries.Text = "Запросы";
            this.tabPageQueries.UseVisualStyleBackColor = true;
            // 
            // btnGetCapitalContainsLetter
            // 
            this.btnGetCapitalContainsLetter.AutoSize = true;
            this.btnGetCapitalContainsLetter.Location = new System.Drawing.Point(4, 186);
            this.btnGetCapitalContainsLetter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetCapitalContainsLetter.Name = "btnGetCapitalContainsLetter";
            this.btnGetCapitalContainsLetter.Size = new System.Drawing.Size(191, 55);
            this.btnGetCapitalContainsLetter.TabIndex = 3;
            this.btnGetCapitalContainsLetter.Text = "Отобразить все столицы,\r\nу которых в названии\r\nесть буквы а, р";
            this.btnGetCapitalContainsLetter.UseVisualStyleBackColor = true;
            this.btnGetCapitalContainsLetter.Click += new System.EventHandler(this.BtnGetCapitalContainsLetter_Click);
            // 
            // btnGetEuropianCountries
            // 
            this.btnGetEuropianCountries.AutoSize = true;
            this.btnGetEuropianCountries.Location = new System.Drawing.Point(4, 125);
            this.btnGetEuropianCountries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetEuropianCountries.Name = "btnGetEuropianCountries";
            this.btnGetEuropianCountries.Size = new System.Drawing.Size(191, 55);
            this.btnGetEuropianCountries.TabIndex = 2;
            this.btnGetEuropianCountries.Text = "Отобразить названия\r\nвсех европейских\r\nстран";
            this.btnGetEuropianCountries.UseVisualStyleBackColor = true;
            this.btnGetEuropianCountries.Click += new System.EventHandler(this.BtnGetEuropianCountries_Click);
            // 
            // btnGetCapitalsSetPopulation
            // 
            this.btnGetCapitalsSetPopulation.AutoSize = true;
            this.btnGetCapitalsSetPopulation.Location = new System.Drawing.Point(4, 64);
            this.btnGetCapitalsSetPopulation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetCapitalsSetPopulation.Name = "btnGetCapitalsSetPopulation";
            this.btnGetCapitalsSetPopulation.Size = new System.Drawing.Size(191, 55);
            this.btnGetCapitalsSetPopulation.TabIndex = 1;
            this.btnGetCapitalsSetPopulation.Text = "отобразить названия\r\nстолиц с количеством\r\nжителей больше 5 млн.";
            this.btnGetCapitalsSetPopulation.UseVisualStyleBackColor = true;
            this.btnGetCapitalsSetPopulation.Click += new System.EventHandler(this.BtnGetCapitalsSetPopulation_Click);
            // 
            // btnGetCapital
            // 
            this.btnGetCapital.AutoSize = true;
            this.btnGetCapital.Location = new System.Drawing.Point(4, 3);
            this.btnGetCapital.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetCapital.Name = "btnGetCapital";
            this.btnGetCapital.Size = new System.Drawing.Size(191, 55);
            this.btnGetCapital.TabIndex = 0;
            this.btnGetCapital.Text = "Отобразить названия\r\n столиц";
            this.btnGetCapital.UseVisualStyleBackColor = true;
            this.btnGetCapital.Click += new System.EventHandler(this.BtnGetCapital_Click);
            // 
            // btnGetCapitalStartWithLetter
            // 
            this.btnGetCapitalStartWithLetter.AutoSize = true;
            this.btnGetCapitalStartWithLetter.Location = new System.Drawing.Point(4, 247);
            this.btnGetCapitalStartWithLetter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGetCapitalStartWithLetter.Name = "btnGetCapitalStartWithLetter";
            this.btnGetCapitalStartWithLetter.Size = new System.Drawing.Size(191, 55);
            this.btnGetCapitalStartWithLetter.TabIndex = 4;
            this.btnGetCapitalStartWithLetter.Text = "Отобразить все столицы,\r\nу которых название\r\nначинается с буквы к";
            this.btnGetCapitalStartWithLetter.UseVisualStyleBackColor = true;
            this.btnGetCapitalStartWithLetter.Click += new System.EventHandler(this.BtnGetCapitalStartWithLetter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCountries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCountries)).EndInit();
            this.tabPageCities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCities)).EndInit();
            this.tabPageQueries.ResumeLayout(false);
            this.tabPageQueries.PerformLayout();
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
        private TabPage tabPageQueries;
        private Button btnGetCapital;
        private Button btnGetCapitalsSetPopulation;
        private Button btnGetEuropianCountries;
        private Button btnGetCapitalContainsLetter;
        private Button btnGetCapitalStartWithLetter;
    }
}