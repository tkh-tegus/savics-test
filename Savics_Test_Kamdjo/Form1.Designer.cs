using System.Collections.Generic;
using System.Windows.Forms;

namespace Savics_Test_Kamdjo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<Patient> medical_registre = new List<Patient>(0);
        private List<Patient> medical_registre_filter = new List<Patient>(0);
        public Form1(List<Patient> registre)
        {
            InitializeComponent();
            this.medical_registre = registre;
            foreach(var item in registre)
            {
                if(item.Age <= 18)
                {
                    medical_registre_filter.Add(item);
                }
            }
            Show(this.medical_registre);
        }
        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public void Show(List<Patient> data)
        {
            grille.Items.Clear();
            foreach(var item in data)
            {
                this.grille.Items.Add(item.ToString());
                this.grille.Items.Add("");
            }
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.unknowRadioButton = new System.Windows.Forms.RadioButton();
            this.ageTextbox = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.femaleCheckBox = new System.Windows.Forms.RadioButton();
            this.maleCheckBox = new System.Windows.Forms.RadioButton();
            this.last_name = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OnlyMinorscheckBox = new System.Windows.Forms.CheckBox();
            this.grille = new System.Windows.Forms.ListBox();
            this.error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.error);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ageTextbox);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.countryComboBox);
            this.panel1.Controls.Add(this.cityComboBox);
            this.panel1.Controls.Add(this.femaleCheckBox);
            this.panel1.Controls.Add(this.maleCheckBox);
            this.panel1.Controls.Add(this.last_name);
            this.panel1.Controls.Add(this.first_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 187);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.yesRadioButton);
            this.panel2.Controls.Add(this.noRadioButton);
            this.panel2.Controls.Add(this.unknowRadioButton);
            this.panel2.Location = new System.Drawing.Point(283, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 30);
            this.panel2.TabIndex = 13;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(3, 7);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(43, 17);
            this.yesRadioButton.TabIndex = 9;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(49, 7);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(39, 17);
            this.noRadioButton.TabIndex = 10;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            // 
            // unknowRadioButton
            // 
            this.unknowRadioButton.AutoSize = true;
            this.unknowRadioButton.Checked = true;
            this.unknowRadioButton.Location = new System.Drawing.Point(97, 7);
            this.unknowRadioButton.Name = "unknowRadioButton";
            this.unknowRadioButton.Size = new System.Drawing.Size(65, 17);
            this.unknowRadioButton.TabIndex = 11;
            this.unknowRadioButton.TabStop = true;
            this.unknowRadioButton.Text = "Unknow";
            this.unknowRadioButton.UseVisualStyleBackColor = true;
            // 
            // ageTextbox
            // 
            this.ageTextbox.Location = new System.Drawing.Point(283, 60);
            this.ageTextbox.Name = "ageTextbox";
            this.ageTextbox.Size = new System.Drawing.Size(120, 20);
            this.ageTextbox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(468, 152);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Living with Diabetes ?";
            // 
            // countryComboBox
            // 
            this.countryComboBox.DisplayMember = "Value";
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            ((object)(resources.GetObject("countryComboBox.Items"))),
            ((object)(resources.GetObject("countryComboBox.Items1"))),
            ((object)(resources.GetObject("countryComboBox.Items2")))});
            this.countryComboBox.Location = new System.Drawing.Point(283, 89);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(260, 21);
            this.countryComboBox.TabIndex = 7;
            this.countryComboBox.ValueMember = "Key";
            // 
            // cityComboBox
            // 
            this.cityComboBox.DisplayMember = "Value";
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            ((object)(resources.GetObject("cityComboBox.Items"))),
            ((object)(resources.GetObject("cityComboBox.Items1"))),
            ((object)(resources.GetObject("cityComboBox.Items2")))});
            this.cityComboBox.Location = new System.Drawing.Point(11, 88);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(260, 21);
            this.cityComboBox.TabIndex = 6;
            this.cityComboBox.ValueMember = "Key";
            // 
            // femaleCheckBox
            // 
            this.femaleCheckBox.AutoSize = true;
            this.femaleCheckBox.Location = new System.Drawing.Point(84, 63);
            this.femaleCheckBox.Name = "femaleCheckBox";
            this.femaleCheckBox.Size = new System.Drawing.Size(59, 17);
            this.femaleCheckBox.TabIndex = 4;
            this.femaleCheckBox.TabStop = true;
            this.femaleCheckBox.Text = "Female";
            this.femaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // maleCheckBox
            // 
            this.maleCheckBox.AutoSize = true;
            this.maleCheckBox.Checked = true;
            this.maleCheckBox.Location = new System.Drawing.Point(11, 63);
            this.maleCheckBox.Name = "maleCheckBox";
            this.maleCheckBox.Size = new System.Drawing.Size(48, 17);
            this.maleCheckBox.TabIndex = 3;
            this.maleCheckBox.TabStop = true;
            this.maleCheckBox.Text = "Male";
            this.maleCheckBox.UseVisualStyleBackColor = true;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(283, 34);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(260, 20);
            this.last_name.TabIndex = 2;
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(11, 34);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(260, 20);
            this.first_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW MEDICAL RECORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "List of medical records";
            // 
            // OnlyMinorscheckBox
            // 
            this.OnlyMinorscheckBox.AutoSize = true;
            this.OnlyMinorscheckBox.Location = new System.Drawing.Point(484, 212);
            this.OnlyMinorscheckBox.Name = "OnlyMinorscheckBox";
            this.OnlyMinorscheckBox.Size = new System.Drawing.Size(80, 17);
            this.OnlyMinorscheckBox.TabIndex = 2;
            this.OnlyMinorscheckBox.Text = "Only minors";
            this.OnlyMinorscheckBox.UseVisualStyleBackColor = true;
            this.OnlyMinorscheckBox.Click += new System.EventHandler(this.onlyMinorsClicked);
            // 
            // grille
            // 
            this.grille.FormattingEnabled = true;
            this.grille.Location = new System.Drawing.Point(16, 284);
            this.grille.Name = "grille";
            this.grille.Size = new System.Drawing.Size(539, 160);
            this.grille.TabIndex = 3;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.DarkRed;
            this.error.Location = new System.Drawing.Point(14, 161);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.grille);
            this.Controls.Add(this.OnlyMinorscheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Medical Record";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageTextbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton unknowRadioButton;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.RadioButton femaleCheckBox;
        private System.Windows.Forms.RadioButton maleCheckBox;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox OnlyMinorscheckBox;
        private NumericUpDown ageTextbox;
        private Panel panel2;
        private ListBox grille;
        private Label error;
    }
}

