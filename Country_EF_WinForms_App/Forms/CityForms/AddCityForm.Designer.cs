namespace Country_EF_WinForms_App.Forms.CityForms
{
    partial class AddCityForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.numericPopulation = new System.Windows.Forms.NumericUpDown();
            this.labelCountry = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.radioBtnYes = new System.Windows.Forms.RadioButton();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPopulation = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCountry = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxIsCapital = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCountry)).BeginInit();
            this.groupBoxIsCapital.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(18, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 21);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtName_Validating);
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(12, 35);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(61, 13);
            this.labelPopulation.TabIndex = 2;
            this.labelPopulation.Text = "Население";
            // 
            // numericPopulation
            // 
            this.numericPopulation.Location = new System.Drawing.Point(79, 33);
            this.numericPopulation.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericPopulation.Name = "numericPopulation";
            this.numericPopulation.Size = new System.Drawing.Size(199, 21);
            this.numericPopulation.TabIndex = 3;
            this.numericPopulation.Validating += new System.ComponentModel.CancelEventHandler(this.NumericPopulation_Validating);
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(29, 63);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(44, 13);
            this.labelCountry.TabIndex = 4;
            this.labelCountry.Text = "Страна";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(79, 60);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(199, 21);
            this.comboBoxCountry.TabIndex = 5;
            this.comboBoxCountry.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxCountry_Validating);
            // 
            // radioBtnYes
            // 
            this.radioBtnYes.AutoSize = true;
            this.radioBtnYes.Location = new System.Drawing.Point(6, 20);
            this.radioBtnYes.Name = "radioBtnYes";
            this.radioBtnYes.Size = new System.Drawing.Size(39, 17);
            this.radioBtnYes.TabIndex = 7;
            this.radioBtnYes.Text = "Да";
            this.radioBtnYes.UseVisualStyleBackColor = true;
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Checked = true;
            this.radioBtnNo.Location = new System.Drawing.Point(51, 20);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(44, 17);
            this.radioBtnNo.TabIndex = 8;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "Нет";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(79, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 25);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(208, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 25);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorPopulation
            // 
            this.errorPopulation.ContainerControl = this;
            // 
            // errorCountry
            // 
            this.errorCountry.ContainerControl = this;
            // 
            // groupBoxIsCapital
            // 
            this.groupBoxIsCapital.Controls.Add(this.radioBtnYes);
            this.groupBoxIsCapital.Controls.Add(this.radioBtnNo);
            this.groupBoxIsCapital.Location = new System.Drawing.Point(79, 87);
            this.groupBoxIsCapital.Name = "groupBoxIsCapital";
            this.groupBoxIsCapital.Size = new System.Drawing.Size(199, 49);
            this.groupBoxIsCapital.TabIndex = 11;
            this.groupBoxIsCapital.TabStop = false;
            this.groupBoxIsCapital.Text = "Является столицей";
            // 
            // AddCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 170);
            this.Controls.Add(this.groupBoxIsCapital);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.numericPopulation);
            this.Controls.Add(this.labelPopulation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Name = "AddCityForm";
            this.Text = "Добавление города";
            ((System.ComponentModel.ISupportInitialize)(this.numericPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCountry)).EndInit();
            this.groupBoxIsCapital.ResumeLayout(false);
            this.groupBoxIsCapital.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelName;
        private TextBox txtName;
        private Label labelPopulation;
        private NumericUpDown numericPopulation;
        private Label labelCountry;
        private ComboBox comboBoxCountry;
        private RadioButton radioBtnYes;
        private RadioButton radioBtnNo;
        private Button btnAdd;
        private Button btnCancel;
        private ErrorProvider errorName;
        private ErrorProvider errorPopulation;
        private ErrorProvider errorCountry;
        private GroupBox groupBoxIsCapital;
    }
}