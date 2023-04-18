namespace WindowsFormsApp1
{
    partial class tabpageCADASTRAR
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
            this.groupBoxGENERO = new System.Windows.Forms.GroupBox();
            this.radioButtonfeminino = new System.Windows.Forms.RadioButton();
            this.radioButtonmasculino = new System.Windows.Forms.RadioButton();
            this.comboBoxESTADO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelobs = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerdata = new System.Windows.Forms.DateTimePicker();
            this.checkBoxCASADO = new System.Windows.Forms.CheckBox();
            this.checkBoxSOLTEIRO = new System.Windows.Forms.CheckBox();
            this.checkBoxVIUVO = new System.Windows.Forms.CheckBox();
            this.tabpageLIMPAR = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonLIMPAR = new System.Windows.Forms.Button();
            this.groupBoxGENERO.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabpageLIMPAR.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGENERO
            // 
            this.groupBoxGENERO.Controls.Add(this.radioButtonfeminino);
            this.groupBoxGENERO.Controls.Add(this.radioButtonmasculino);
            this.groupBoxGENERO.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGENERO.Name = "groupBoxGENERO";
            this.groupBoxGENERO.Size = new System.Drawing.Size(200, 100);
            this.groupBoxGENERO.TabIndex = 0;
            this.groupBoxGENERO.TabStop = false;
            this.groupBoxGENERO.Text = "genero";
            // 
            // radioButtonfeminino
            // 
            this.radioButtonfeminino.AutoSize = true;
            this.radioButtonfeminino.Location = new System.Drawing.Point(99, 47);
            this.radioButtonfeminino.Name = "radioButtonfeminino";
            this.radioButtonfeminino.Size = new System.Drawing.Size(64, 17);
            this.radioButtonfeminino.TabIndex = 1;
            this.radioButtonfeminino.TabStop = true;
            this.radioButtonfeminino.Text = "feminino";
            this.radioButtonfeminino.UseVisualStyleBackColor = true;
            // 
            // radioButtonmasculino
            // 
            this.radioButtonmasculino.AutoSize = true;
            this.radioButtonmasculino.Location = new System.Drawing.Point(7, 47);
            this.radioButtonmasculino.Name = "radioButtonmasculino";
            this.radioButtonmasculino.Size = new System.Drawing.Size(72, 17);
            this.radioButtonmasculino.TabIndex = 0;
            this.radioButtonmasculino.TabStop = true;
            this.radioButtonmasculino.Text = "masculino";
            this.radioButtonmasculino.UseVisualStyleBackColor = true;
            // 
            // comboBoxESTADO
            // 
            this.comboBoxESTADO.FormattingEnabled = true;
            this.comboBoxESTADO.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.comboBoxESTADO.Location = new System.Drawing.Point(12, 181);
            this.comboBoxESTADO.Name = "comboBoxESTADO";
            this.comboBoxESTADO.Size = new System.Drawing.Size(200, 21);
            this.comboBoxESTADO.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.labelobs);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 116);
            this.panel1.TabIndex = 3;
            // 
            // labelobs
            // 
            this.labelobs.AutoSize = true;
            this.labelobs.Location = new System.Drawing.Point(4, 100);
            this.labelobs.Name = "labelobs";
            this.labelobs.Size = new System.Drawing.Size(68, 13);
            this.labelobs.TabIndex = 4;
            this.labelobs.Text = "observações";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 94);
            this.textBox1.TabIndex = 0;
            // 
            // dateTimePickerdata
            // 
            this.dateTimePickerdata.Location = new System.Drawing.Point(383, 59);
            this.dateTimePickerdata.Name = "dateTimePickerdata";
            this.dateTimePickerdata.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerdata.TabIndex = 4;
            // 
            // checkBoxCASADO
            // 
            this.checkBoxCASADO.AutoSize = true;
            this.checkBoxCASADO.Location = new System.Drawing.Point(383, 94);
            this.checkBoxCASADO.Name = "checkBoxCASADO";
            this.checkBoxCASADO.Size = new System.Drawing.Size(73, 17);
            this.checkBoxCASADO.TabIndex = 5;
            this.checkBoxCASADO.Text = "casado(a)";
            this.checkBoxCASADO.UseVisualStyleBackColor = true;
            this.checkBoxCASADO.CheckedChanged += new System.EventHandler(this.checkBoxCASADO_CheckedChanged);
            // 
            // checkBoxSOLTEIRO
            // 
            this.checkBoxSOLTEIRO.AutoSize = true;
            this.checkBoxSOLTEIRO.Location = new System.Drawing.Point(383, 118);
            this.checkBoxSOLTEIRO.Name = "checkBoxSOLTEIRO";
            this.checkBoxSOLTEIRO.Size = new System.Drawing.Size(71, 17);
            this.checkBoxSOLTEIRO.TabIndex = 6;
            this.checkBoxSOLTEIRO.Text = "solteiro(a)";
            this.checkBoxSOLTEIRO.UseVisualStyleBackColor = true;
            this.checkBoxSOLTEIRO.CheckedChanged += new System.EventHandler(this.checkBoxSOLTEIRO_CheckedChanged);
            // 
            // checkBoxVIUVO
            // 
            this.checkBoxVIUVO.AutoSize = true;
            this.checkBoxVIUVO.Location = new System.Drawing.Point(383, 142);
            this.checkBoxVIUVO.Name = "checkBoxVIUVO";
            this.checkBoxVIUVO.Size = new System.Drawing.Size(64, 17);
            this.checkBoxVIUVO.TabIndex = 7;
            this.checkBoxVIUVO.Text = "viuvo(a)";
            this.checkBoxVIUVO.UseVisualStyleBackColor = true;
            this.checkBoxVIUVO.CheckedChanged += new System.EventHandler(this.checkBoxVIUVO_CheckedChanged);
            // 
            // tabpageLIMPAR
            // 
            this.tabpageLIMPAR.Controls.Add(this.tabPage1);
            this.tabpageLIMPAR.Controls.Add(this.tabPage2);
            this.tabpageLIMPAR.Location = new System.Drawing.Point(383, 181);
            this.tabpageLIMPAR.Name = "tabpageLIMPAR";
            this.tabpageLIMPAR.SelectedIndex = 0;
            this.tabpageLIMPAR.Size = new System.Drawing.Size(200, 104);
            this.tabpageLIMPAR.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.buttonCADASTRAR);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 78);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "cadastrar";
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Location = new System.Drawing.Point(55, 28);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(75, 23);
            this.buttonCADASTRAR.TabIndex = 0;
            this.buttonCADASTRAR.Text = "cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.buttonLIMPAR);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 78);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "limpar";
            // 
            // buttonLIMPAR
            // 
            this.buttonLIMPAR.Location = new System.Drawing.Point(54, 28);
            this.buttonLIMPAR.Name = "buttonLIMPAR";
            this.buttonLIMPAR.Size = new System.Drawing.Size(75, 23);
            this.buttonLIMPAR.TabIndex = 0;
            this.buttonLIMPAR.Text = "limpar";
            this.buttonLIMPAR.UseVisualStyleBackColor = true;
            // 
            // tabpageCADASTRAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabpageLIMPAR);
            this.Controls.Add(this.checkBoxVIUVO);
            this.Controls.Add(this.checkBoxSOLTEIRO);
            this.Controls.Add(this.checkBoxCASADO);
            this.Controls.Add(this.dateTimePickerdata);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxESTADO);
            this.Controls.Add(this.groupBoxGENERO);
            this.Name = "tabpageCADASTRAR";
            this.Text = "Form1";
            this.groupBoxGENERO.ResumeLayout(false);
            this.groupBoxGENERO.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabpageLIMPAR.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGENERO;
        private System.Windows.Forms.RadioButton radioButtonfeminino;
        private System.Windows.Forms.RadioButton radioButtonmasculino;
        private System.Windows.Forms.ComboBox comboBoxESTADO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelobs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerdata;
        private System.Windows.Forms.CheckBox checkBoxCASADO;
        private System.Windows.Forms.CheckBox checkBoxSOLTEIRO;
        private System.Windows.Forms.CheckBox checkBoxVIUVO;
        private System.Windows.Forms.TabControl tabpageLIMPAR;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.Button buttonLIMPAR;
    }
}

