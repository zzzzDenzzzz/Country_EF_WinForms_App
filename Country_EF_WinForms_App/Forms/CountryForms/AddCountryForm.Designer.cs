namespace Country_EF_WinForms_App.Forms.CountryForms
{
    partial class AddCountryForm
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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.numericArea = new System.Windows.Forms.NumericUpDown();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.numericPopulationCountry = new System.Windows.Forms.NumericUpDown();
            this.labelPartOfTheWorld = new System.Windows.Forms.Label();
            this.comboBoxPartOfTheWorld = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorArea = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPopulation = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPartOfTheWorld = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulationCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPartOfTheWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(88, 6);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(262, 23);
            this.txtCountryName.TabIndex = 1;
            this.txtCountryName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCountryName_Validating);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(23, 37);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(59, 15);
            this.labelArea.TabIndex = 2;
            this.labelArea.Text = "Площадь";
            // 
            // numericArea
            // 
            this.numericArea.Location = new System.Drawing.Point(88, 35);
            this.numericArea.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericArea.Name = "numericArea";
            this.numericArea.Size = new System.Drawing.Size(262, 23);
            this.numericArea.TabIndex = 3;
            this.numericArea.Validating += new System.ComponentModel.CancelEventHandler(this.NumericArea_Validating);
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(15, 66);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(67, 15);
            this.labelPopulation.TabIndex = 4;
            this.labelPopulation.Text = "Население";
            // 
            // numericPopulationCountry
            // 
            this.numericPopulationCountry.Location = new System.Drawing.Point(88, 64);
            this.numericPopulationCountry.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericPopulationCountry.Name = "numericPopulationCountry";
            this.numericPopulationCountry.Size = new System.Drawing.Size(262, 23);
            this.numericPopulationCountry.TabIndex = 5;
            this.numericPopulationCountry.Validating += new System.ComponentModel.CancelEventHandler(this.NumericPopulationCountry_Validating);
            // 
            // labelPartOfTheWorld
            // 
            this.labelPartOfTheWorld.AutoSize = true;
            this.labelPartOfTheWorld.Location = new System.Drawing.Point(12, 96);
            this.labelPartOfTheWorld.Name = "labelPartOfTheWorld";
            this.labelPartOfTheWorld.Size = new System.Drawing.Size(70, 15);
            this.labelPartOfTheWorld.TabIndex = 6;
            this.labelPartOfTheWorld.Text = "Часть света";
            // 
            // comboBoxPartOfTheWorld
            // 
            this.comboBoxPartOfTheWorld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPartOfTheWorld.FormattingEnabled = true;
            this.comboBoxPartOfTheWorld.Location = new System.Drawing.Point(88, 93);
            this.comboBoxPartOfTheWorld.Name = "comboBoxPartOfTheWorld";
            this.comboBoxPartOfTheWorld.Size = new System.Drawing.Size(262, 23);
            this.comboBoxPartOfTheWorld.TabIndex = 7;
            this.comboBoxPartOfTheWorld.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxPartOfTheWorld_Validating);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(88, 122);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Добавить";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(275, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorName
            // 
            this.errorName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorName.ContainerControl = this;
            // 
            // errorArea
            // 
            this.errorArea.ContainerControl = this;
            // 
            // errorPopulation
            // 
            this.errorPopulation.ContainerControl = this;
            // 
            // errorPartOfTheWorld
            // 
            this.errorPartOfTheWorld.ContainerControl = this;
            // 
            // AddCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 165);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.comboBoxPartOfTheWorld);
            this.Controls.Add(this.labelPartOfTheWorld);
            this.Controls.Add(this.numericPopulationCountry);
            this.Controls.Add(this.labelPopulation);
            this.Controls.Add(this.numericArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.labelName);
            this.Name = "AddCountryForm";
            this.Text = "Добавление страны";
            ((System.ComponentModel.ISupportInitialize)(this.numericArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulationCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPartOfTheWorld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelName;
        private TextBox txtCountryName;
        private Label labelArea;
        private NumericUpDown numericArea;
        private Label labelPopulation;
        private NumericUpDown numericPopulationCountry;
        private Label labelPartOfTheWorld;
        private ComboBox comboBoxPartOfTheWorld;
        private Button btnOk;
        private Button btnCancel;
        private ErrorProvider errorName;
        private ErrorProvider errorArea;
        private ErrorProvider errorPopulation;
        private ErrorProvider errorPartOfTheWorld;
    }
}