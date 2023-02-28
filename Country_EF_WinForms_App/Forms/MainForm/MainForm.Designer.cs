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
            this.btnShowPopulation = new System.Windows.Forms.Button();
            this.numericMinPopulation = new System.Windows.Forms.NumericUpDown();
            this.labelMinPopulation = new System.Windows.Forms.Label();
            this.btnShowArea = new System.Windows.Forms.Button();
            this.numericMaxArea = new System.Windows.Forms.NumericUpDown();
            this.labelMaxArea = new System.Windows.Forms.Label();
            this.numericMinArea = new System.Windows.Forms.NumericUpDown();
            this.labelMinArea = new System.Windows.Forms.Label();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.btnUpdateCountry = new System.Windows.Forms.Button();
            this.btnCreateCountry = new System.Windows.Forms.Button();
            this.gridCountries = new System.Windows.Forms.DataGridView();
            this.tabPageCities = new System.Windows.Forms.TabPage();
            this.comboBoxContries = new System.Windows.Forms.ComboBox();
            this.labelCountries = new System.Windows.Forms.Label();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.btnUpdateCity = new System.Windows.Forms.Button();
            this.btnCreateCity = new System.Windows.Forms.Button();
            this.gridCities = new System.Windows.Forms.DataGridView();
            this.tabPageQueries = new System.Windows.Forms.TabPage();
            this.btnGetCountrySmallestAreaEuropa = new System.Windows.Forms.Button();
            this.btnGetCapitalLargestPopulation = new System.Windows.Forms.Button();
            this.btnGetCountryLargestArea = new System.Windows.Forms.Button();
            this.btnGetCapitalTopPopulation = new System.Windows.Forms.Button();
            this.btnGetCountryTopArea = new System.Windows.Forms.Button();
            this.btnGetCapitalStartWithLetter = new System.Windows.Forms.Button();
            this.btnGetCapitalContainsLetter = new System.Windows.Forms.Button();
            this.btnGetEuropianCountries = new System.Windows.Forms.Button();
            this.btnGetCapitalsSetPopulation = new System.Windows.Forms.Button();
            this.btnGetCapital = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinArea)).BeginInit();
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
            this.tabControlMain.Location = new System.Drawing.Point(10, 10);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(665, 408);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.MainForm_Load);
            // 
            // tabPageCountries
            // 
            this.tabPageCountries.Controls.Add(this.btnShowPopulation);
            this.tabPageCountries.Controls.Add(this.numericMinPopulation);
            this.tabPageCountries.Controls.Add(this.labelMinPopulation);
            this.tabPageCountries.Controls.Add(this.btnShowArea);
            this.tabPageCountries.Controls.Add(this.numericMaxArea);
            this.tabPageCountries.Controls.Add(this.labelMaxArea);
            this.tabPageCountries.Controls.Add(this.numericMinArea);
            this.tabPageCountries.Controls.Add(this.labelMinArea);
            this.tabPageCountries.Controls.Add(this.btnDeleteCountry);
            this.tabPageCountries.Controls.Add(this.btnUpdateCountry);
            this.tabPageCountries.Controls.Add(this.btnCreateCountry);
            this.tabPageCountries.Controls.Add(this.gridCountries);
            this.tabPageCountries.Location = new System.Drawing.Point(4, 22);
            this.tabPageCountries.Name = "tabPageCountries";
            this.tabPageCountries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCountries.Size = new System.Drawing.Size(657, 382);
            this.tabPageCountries.TabIndex = 0;
            this.tabPageCountries.Text = "Страны";
            this.tabPageCountries.UseVisualStyleBackColor = true;
            // 
            // btnShowPopulation
            // 
            this.btnShowPopulation.AutoSize = true;
            this.btnShowPopulation.Location = new System.Drawing.Point(467, 353);
            this.btnShowPopulation.Name = "btnShowPopulation";
            this.btnShowPopulation.Size = new System.Drawing.Size(78, 25);
            this.btnShowPopulation.TabIndex = 11;
            this.btnShowPopulation.Text = "Отобразить";
            this.btnShowPopulation.UseVisualStyleBackColor = true;
            this.btnShowPopulation.Click += new System.EventHandler(this.BtnShowPopulation_Click);
            // 
            // numericMinPopulation
            // 
            this.numericMinPopulation.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericMinPopulation.Location = new System.Drawing.Point(325, 355);
            this.numericMinPopulation.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericMinPopulation.Name = "numericMinPopulation";
            this.numericMinPopulation.Size = new System.Drawing.Size(136, 21);
            this.numericMinPopulation.TabIndex = 10;
            // 
            // labelMinPopulation
            // 
            this.labelMinPopulation.AutoSize = true;
            this.labelMinPopulation.Location = new System.Drawing.Point(234, 359);
            this.labelMinPopulation.Name = "labelMinPopulation";
            this.labelMinPopulation.Size = new System.Drawing.Size(87, 13);
            this.labelMinPopulation.TabIndex = 9;
            this.labelMinPopulation.Text = "Мин. население";
            // 
            // btnShowArea
            // 
            this.btnShowArea.AutoSize = true;
            this.btnShowArea.Location = new System.Drawing.Point(467, 3);
            this.btnShowArea.Name = "btnShowArea";
            this.btnShowArea.Size = new System.Drawing.Size(78, 25);
            this.btnShowArea.TabIndex = 8;
            this.btnShowArea.Text = "Отобразить";
            this.btnShowArea.UseVisualStyleBackColor = true;
            this.btnShowArea.Click += new System.EventHandler(this.BtnShowArea_Click);
            // 
            // numericMaxArea
            // 
            this.numericMaxArea.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericMaxArea.Location = new System.Drawing.Point(325, 6);
            this.numericMaxArea.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericMaxArea.Name = "numericMaxArea";
            this.numericMaxArea.Size = new System.Drawing.Size(136, 21);
            this.numericMaxArea.TabIndex = 7;
            // 
            // labelMaxArea
            // 
            this.labelMaxArea.AutoSize = true;
            this.labelMaxArea.Location = new System.Drawing.Point(234, 8);
            this.labelMaxArea.Name = "labelMaxArea";
            this.labelMaxArea.Size = new System.Drawing.Size(85, 13);
            this.labelMaxArea.TabIndex = 6;
            this.labelMaxArea.Text = "Макс. площадь";
            // 
            // numericMinArea
            // 
            this.numericMinArea.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericMinArea.Location = new System.Drawing.Point(92, 6);
            this.numericMinArea.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericMinArea.Name = "numericMinArea";
            this.numericMinArea.Size = new System.Drawing.Size(136, 21);
            this.numericMinArea.TabIndex = 5;
            // 
            // labelMinArea
            // 
            this.labelMinArea.AutoSize = true;
            this.labelMinArea.Location = new System.Drawing.Point(6, 8);
            this.labelMinArea.Name = "labelMinArea";
            this.labelMinArea.Size = new System.Drawing.Size(80, 13);
            this.labelMinArea.TabIndex = 4;
            this.labelMinArea.Text = "Мин. площадь";
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.AutoSize = true;
            this.btnDeleteCountry.Location = new System.Drawing.Point(158, 353);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(70, 25);
            this.btnDeleteCountry.TabIndex = 3;
            this.btnDeleteCountry.Text = "Удалить";
            this.btnDeleteCountry.UseVisualStyleBackColor = true;
            this.btnDeleteCountry.Click += new System.EventHandler(this.BtnDeleteCountry_Click);
            // 
            // btnUpdateCountry
            // 
            this.btnUpdateCountry.AutoSize = true;
            this.btnUpdateCountry.Location = new System.Drawing.Point(82, 353);
            this.btnUpdateCountry.Name = "btnUpdateCountry";
            this.btnUpdateCountry.Size = new System.Drawing.Size(70, 25);
            this.btnUpdateCountry.TabIndex = 2;
            this.btnUpdateCountry.Text = "Изменить";
            this.btnUpdateCountry.UseVisualStyleBackColor = true;
            this.btnUpdateCountry.Click += new System.EventHandler(this.BtnUpdateCountry_Click);
            // 
            // btnCreateCountry
            // 
            this.btnCreateCountry.AutoSize = true;
            this.btnCreateCountry.Location = new System.Drawing.Point(6, 353);
            this.btnCreateCountry.Name = "btnCreateCountry";
            this.btnCreateCountry.Size = new System.Drawing.Size(70, 25);
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
            this.gridCountries.Location = new System.Drawing.Point(3, 34);
            this.gridCountries.Name = "gridCountries";
            this.gridCountries.ReadOnly = true;
            this.gridCountries.RowHeadersVisible = false;
            this.gridCountries.RowTemplate.Height = 25;
            this.gridCountries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCountries.Size = new System.Drawing.Size(651, 313);
            this.gridCountries.TabIndex = 0;
            // 
            // tabPageCities
            // 
            this.tabPageCities.Controls.Add(this.comboBoxContries);
            this.tabPageCities.Controls.Add(this.labelCountries);
            this.tabPageCities.Controls.Add(this.btnDeleteCity);
            this.tabPageCities.Controls.Add(this.btnUpdateCity);
            this.tabPageCities.Controls.Add(this.btnCreateCity);
            this.tabPageCities.Controls.Add(this.gridCities);
            this.tabPageCities.Location = new System.Drawing.Point(4, 22);
            this.tabPageCities.Name = "tabPageCities";
            this.tabPageCities.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCities.Size = new System.Drawing.Size(657, 382);
            this.tabPageCities.TabIndex = 1;
            this.tabPageCities.Text = "Города";
            this.tabPageCities.UseVisualStyleBackColor = true;
            // 
            // comboBoxContries
            // 
            this.comboBoxContries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContries.FormattingEnabled = true;
            this.comboBoxContries.Location = new System.Drawing.Point(58, 6);
            this.comboBoxContries.Name = "comboBoxContries";
            this.comboBoxContries.Size = new System.Drawing.Size(170, 21);
            this.comboBoxContries.TabIndex = 5;
            this.comboBoxContries.SelectedIndexChanged += new System.EventHandler(this.ComboBoxContries_SelectedIndexChanged);
            // 
            // labelCountries
            // 
            this.labelCountries.AutoSize = true;
            this.labelCountries.Location = new System.Drawing.Point(6, 9);
            this.labelCountries.Name = "labelCountries";
            this.labelCountries.Size = new System.Drawing.Size(46, 13);
            this.labelCountries.TabIndex = 4;
            this.labelCountries.Text = "Страны";
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.AutoSize = true;
            this.btnDeleteCity.Location = new System.Drawing.Point(158, 351);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(70, 25);
            this.btnDeleteCity.TabIndex = 3;
            this.btnDeleteCity.Text = "Удалить";
            this.btnDeleteCity.UseVisualStyleBackColor = true;
            this.btnDeleteCity.Click += new System.EventHandler(this.BtnDeleteCity_Click);
            // 
            // btnUpdateCity
            // 
            this.btnUpdateCity.AutoSize = true;
            this.btnUpdateCity.Location = new System.Drawing.Point(82, 351);
            this.btnUpdateCity.Name = "btnUpdateCity";
            this.btnUpdateCity.Size = new System.Drawing.Size(70, 25);
            this.btnUpdateCity.TabIndex = 2;
            this.btnUpdateCity.Text = "Изменить";
            this.btnUpdateCity.UseVisualStyleBackColor = true;
            this.btnUpdateCity.Click += new System.EventHandler(this.BtnUpdateCity_Click);
            // 
            // btnCreateCity
            // 
            this.btnCreateCity.AutoSize = true;
            this.btnCreateCity.Location = new System.Drawing.Point(6, 351);
            this.btnCreateCity.Name = "btnCreateCity";
            this.btnCreateCity.Size = new System.Drawing.Size(70, 25);
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
            this.gridCities.Location = new System.Drawing.Point(3, 33);
            this.gridCities.Name = "gridCities";
            this.gridCities.ReadOnly = true;
            this.gridCities.RowHeadersVisible = false;
            this.gridCities.RowTemplate.Height = 25;
            this.gridCities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCities.Size = new System.Drawing.Size(651, 312);
            this.gridCities.TabIndex = 0;
            // 
            // tabPageQueries
            // 
            this.tabPageQueries.Controls.Add(this.btnGetCountrySmallestAreaEuropa);
            this.tabPageQueries.Controls.Add(this.btnGetCapitalLargestPopulation);
            this.tabPageQueries.Controls.Add(this.btnGetCountryLargestArea);
            this.tabPageQueries.Controls.Add(this.btnGetCapitalTopPopulation);
            this.tabPageQueries.Controls.Add(this.btnGetCountryTopArea);
            this.tabPageQueries.Controls.Add(this.btnGetCapitalStartWithLetter);
            this.tabPageQueries.Controls.Add(this.btnGetCapitalContainsLetter);
            this.tabPageQueries.Controls.Add(this.btnGetEuropianCountries);
            this.tabPageQueries.Controls.Add(this.btnGetCapitalsSetPopulation);
            this.tabPageQueries.Controls.Add(this.btnGetCapital);
            this.tabPageQueries.Location = new System.Drawing.Point(4, 22);
            this.tabPageQueries.Name = "tabPageQueries";
            this.tabPageQueries.Size = new System.Drawing.Size(657, 382);
            this.tabPageQueries.TabIndex = 2;
            this.tabPageQueries.Text = "Запросы";
            this.tabPageQueries.UseVisualStyleBackColor = true;
            // 
            // btnGetCountrySmallestAreaEuropa
            // 
            this.btnGetCountrySmallestAreaEuropa.AutoSize = true;
            this.btnGetCountrySmallestAreaEuropa.Location = new System.Drawing.Point(173, 175);
            this.btnGetCountrySmallestAreaEuropa.Name = "btnGetCountrySmallestAreaEuropa";
            this.btnGetCountrySmallestAreaEuropa.Size = new System.Drawing.Size(164, 49);
            this.btnGetCountrySmallestAreaEuropa.TabIndex = 9;
            this.btnGetCountrySmallestAreaEuropa.Text = "Показать страну с самой\r\n маленькой площадью\r\n в Европе";
            this.btnGetCountrySmallestAreaEuropa.UseVisualStyleBackColor = true;
            this.btnGetCountrySmallestAreaEuropa.Click += new System.EventHandler(this.BtnGetCountrySmallestAreaEuropa_Click);
            // 
            // btnGetCapitalLargestPopulation
            // 
            this.btnGetCapitalLargestPopulation.AutoSize = true;
            this.btnGetCapitalLargestPopulation.Location = new System.Drawing.Point(173, 120);
            this.btnGetCapitalLargestPopulation.Name = "btnGetCapitalLargestPopulation";
            this.btnGetCapitalLargestPopulation.Size = new System.Drawing.Size(164, 49);
            this.btnGetCapitalLargestPopulation.TabIndex = 8;
            this.btnGetCapitalLargestPopulation.Text = "Показать столицу с самым\r\n большим количеством\r\n жителей";
            this.btnGetCapitalLargestPopulation.UseVisualStyleBackColor = true;
            this.btnGetCapitalLargestPopulation.Click += new System.EventHandler(this.BtnGetCapitalLargestPopulation_Click);
            // 
            // btnGetCountryLargestArea
            // 
            this.btnGetCountryLargestArea.AutoSize = true;
            this.btnGetCountryLargestArea.Location = new System.Drawing.Point(173, 65);
            this.btnGetCountryLargestArea.Name = "btnGetCountryLargestArea";
            this.btnGetCountryLargestArea.Size = new System.Drawing.Size(164, 49);
            this.btnGetCountryLargestArea.TabIndex = 7;
            this.btnGetCountryLargestArea.Text = "Показать страну с самой\r\n большой площадью";
            this.btnGetCountryLargestArea.UseVisualStyleBackColor = true;
            this.btnGetCountryLargestArea.Click += new System.EventHandler(this.BtnGetCountryLargestArea_Click);
            // 
            // btnGetCapitalTopPopulation
            // 
            this.btnGetCapitalTopPopulation.AutoSize = true;
            this.btnGetCapitalTopPopulation.Location = new System.Drawing.Point(173, 10);
            this.btnGetCapitalTopPopulation.Name = "btnGetCapitalTopPopulation";
            this.btnGetCapitalTopPopulation.Size = new System.Drawing.Size(164, 49);
            this.btnGetCapitalTopPopulation.TabIndex = 6;
            this.btnGetCapitalTopPopulation.Text = "Показать топ-5\r\n столиц по количеству \r\nжителей";
            this.btnGetCapitalTopPopulation.UseVisualStyleBackColor = true;
            this.btnGetCapitalTopPopulation.Click += new System.EventHandler(this.BtnGetCapitalTopPopulation_Click);
            // 
            // btnGetCountryTopArea
            // 
            this.btnGetCountryTopArea.AutoSize = true;
            this.btnGetCountryTopArea.Location = new System.Drawing.Point(3, 285);
            this.btnGetCountryTopArea.Name = "btnGetCountryTopArea";
            this.btnGetCountryTopArea.Size = new System.Drawing.Size(164, 49);
            this.btnGetCountryTopArea.TabIndex = 5;
            this.btnGetCountryTopArea.Text = "Показать топ-5\r\n стран по площади";
            this.btnGetCountryTopArea.UseVisualStyleBackColor = true;
            this.btnGetCountryTopArea.Click += new System.EventHandler(this.BtnGetCountryTopArea_Click);
            // 
            // btnGetCapitalStartWithLetter
            // 
            this.btnGetCapitalStartWithLetter.AutoSize = true;
            this.btnGetCapitalStartWithLetter.Location = new System.Drawing.Point(3, 230);
            this.btnGetCapitalStartWithLetter.Name = "btnGetCapitalStartWithLetter";
            this.btnGetCapitalStartWithLetter.Size = new System.Drawing.Size(164, 49);
            this.btnGetCapitalStartWithLetter.TabIndex = 4;
            this.btnGetCapitalStartWithLetter.Text = "Отобразить все столицы, \r\nу которых название\r\n начинается с буквы к";
            this.btnGetCapitalStartWithLetter.UseVisualStyleBackColor = true;
            this.btnGetCapitalStartWithLetter.Click += new System.EventHandler(this.BtnGetCapitalStartWithLetter_Click);
            // 
            // btnGetCapitalContainsLetter
            // 
            this.btnGetCapitalContainsLetter.AutoSize = true;
            this.btnGetCapitalContainsLetter.Location = new System.Drawing.Point(3, 175);
            this.btnGetCapitalContainsLetter.Name = "btnGetCapitalContainsLetter";
            this.btnGetCapitalContainsLetter.Size = new System.Drawing.Size(164, 49);
            this.btnGetCapitalContainsLetter.TabIndex = 3;
            this.btnGetCapitalContainsLetter.Text = "Отобразить все столицы, \r\nу которых в названии\r\n есть буквы а, р";
            this.btnGetCapitalContainsLetter.UseVisualStyleBackColor = true;
            this.btnGetCapitalContainsLetter.Click += new System.EventHandler(this.BtnGetCapitalContainsLetter_Click);
            // 
            // btnGetEuropianCountries
            // 
            this.btnGetEuropianCountries.AutoSize = true;
            this.btnGetEuropianCountries.Location = new System.Drawing.Point(3, 120);
            this.btnGetEuropianCountries.Name = "btnGetEuropianCountries";
            this.btnGetEuropianCountries.Size = new System.Drawing.Size(164, 49);
            this.btnGetEuropianCountries.TabIndex = 2;
            this.btnGetEuropianCountries.Text = "Отобразить названия\r\n всех европейских\r\n стран";
            this.btnGetEuropianCountries.UseVisualStyleBackColor = true;
            this.btnGetEuropianCountries.Click += new System.EventHandler(this.BtnGetEuropianCountries_Click);
            // 
            // btnGetCapitalsSetPopulation
            // 
            this.btnGetCapitalsSetPopulation.AutoSize = true;
            this.btnGetCapitalsSetPopulation.Location = new System.Drawing.Point(3, 65);
            this.btnGetCapitalsSetPopulation.Name = "btnGetCapitalsSetPopulation";
            this.btnGetCapitalsSetPopulation.Size = new System.Drawing.Size(164, 49);
            this.btnGetCapitalsSetPopulation.TabIndex = 1;
            this.btnGetCapitalsSetPopulation.Text = "отобразить названия\r\n столиц с количеством\r\n жителей больше 5 млн.";
            this.btnGetCapitalsSetPopulation.UseVisualStyleBackColor = true;
            this.btnGetCapitalsSetPopulation.Click += new System.EventHandler(this.BtnGetCapitalsSetPopulation_Click);
            // 
            // btnGetCapital
            // 
            this.btnGetCapital.AutoSize = true;
            this.btnGetCapital.Location = new System.Drawing.Point(3, 11);
            this.btnGetCapital.Name = "btnGetCapital";
            this.btnGetCapital.Size = new System.Drawing.Size(164, 48);
            this.btnGetCapital.TabIndex = 0;
            this.btnGetCapital.Text = "Отобразить названия\r\n столиц";
            this.btnGetCapital.UseVisualStyleBackColor = true;
            this.btnGetCapital.Click += new System.EventHandler(this.BtnGetCapital_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 423);
            this.Controls.Add(this.tabControlMain);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCountries.ResumeLayout(false);
            this.tabPageCountries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCountries)).EndInit();
            this.tabPageCities.ResumeLayout(false);
            this.tabPageCities.PerformLayout();
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
        private Button btnGetCountryTopArea;
        private Button btnGetCapitalTopPopulation;
        private Button btnGetCountryLargestArea;
        private Button btnGetCapitalLargestPopulation;
        private Button btnGetCountrySmallestAreaEuropa;
        private ComboBox comboBoxContries;
        private Label labelCountries;
        private NumericUpDown numericMinArea;
        private Label labelMinArea;
        private Label labelMaxArea;
        private NumericUpDown numericMaxArea;
        private Button btnShowArea;
        private Button btnShowPopulation;
        private NumericUpDown numericMinPopulation;
        private Label labelMinPopulation;
    }
}