namespace SimplePaint
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCorDaCaneta = new System.Windows.Forms.Button();
            this.CorDaCaneta = new System.Windows.Forms.Label();
            this.comboBoxEspessuraDaCaneta = new System.Windows.Forms.ComboBox();
            this.EspessuraDaCaneta = new System.Windows.Forms.Label();
            this.buttonBorracha = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.panelPintura = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.buttonBorracha);
            this.groupBox1.Controls.Add(this.EspessuraDaCaneta);
            this.groupBox1.Controls.Add(this.comboBoxEspessuraDaCaneta);
            this.groupBox1.Controls.Add(this.CorDaCaneta);
            this.groupBox1.Controls.Add(this.buttonCorDaCaneta);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personalizar";
            // 
            // buttonCorDaCaneta
            // 
            this.buttonCorDaCaneta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCorDaCaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorDaCaneta.Location = new System.Drawing.Point(113, 53);
            this.buttonCorDaCaneta.Name = "buttonCorDaCaneta";
            this.buttonCorDaCaneta.Size = new System.Drawing.Size(75, 23);
            this.buttonCorDaCaneta.TabIndex = 0;
            this.buttonCorDaCaneta.UseVisualStyleBackColor = false;
            this.buttonCorDaCaneta.Click += new System.EventHandler(this.buttonCorDaCaneta_Click);
            // 
            // CorDaCaneta
            // 
            this.CorDaCaneta.AutoSize = true;
            this.CorDaCaneta.Location = new System.Drawing.Point(18, 56);
            this.CorDaCaneta.Name = "CorDaCaneta";
            this.CorDaCaneta.Size = new System.Drawing.Size(89, 16);
            this.CorDaCaneta.TabIndex = 1;
            this.CorDaCaneta.Text = "Cor da caneta";
            // 
            // comboBoxEspessuraDaCaneta
            // 
            this.comboBoxEspessuraDaCaneta.FormattingEnabled = true;
            this.comboBoxEspessuraDaCaneta.Location = new System.Drawing.Point(343, 52);
            this.comboBoxEspessuraDaCaneta.Name = "comboBoxEspessuraDaCaneta";
            this.comboBoxEspessuraDaCaneta.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEspessuraDaCaneta.TabIndex = 2;
            // 
            // EspessuraDaCaneta
            // 
            this.EspessuraDaCaneta.AutoSize = true;
            this.EspessuraDaCaneta.Location = new System.Drawing.Point(206, 56);
            this.EspessuraDaCaneta.Name = "EspessuraDaCaneta";
            this.EspessuraDaCaneta.Size = new System.Drawing.Size(131, 16);
            this.EspessuraDaCaneta.TabIndex = 3;
            this.EspessuraDaCaneta.Text = "Espessura da caneta";
            // 
            // buttonBorracha
            // 
            this.buttonBorracha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorracha.Location = new System.Drawing.Point(481, 53);
            this.buttonBorracha.Name = "buttonBorracha";
            this.buttonBorracha.Size = new System.Drawing.Size(75, 23);
            this.buttonBorracha.TabIndex = 4;
            this.buttonBorracha.Text = "Borracha";
            this.buttonBorracha.UseVisualStyleBackColor = true;
            this.buttonBorracha.Click += new System.EventHandler(this.buttonBorracha_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Location = new System.Drawing.Point(562, 53);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 5;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(684, 21);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // panelPintura
            // 
            this.panelPintura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPintura.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPintura.Location = new System.Drawing.Point(12, 106);
            this.panelPintura.Name = "panelPintura";
            this.panelPintura.Size = new System.Drawing.Size(776, 340);
            this.panelPintura.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPintura);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.Text = "Simple Paint";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CorDaCaneta;
        private System.Windows.Forms.Button buttonCorDaCaneta;
        private System.Windows.Forms.ComboBox comboBoxEspessuraDaCaneta;
        private System.Windows.Forms.Label EspessuraDaCaneta;
        private System.Windows.Forms.Button buttonBorracha;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Panel panelPintura;
    }
}

