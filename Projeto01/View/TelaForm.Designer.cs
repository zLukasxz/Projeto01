namespace Projeto01.View
{
    partial class TelaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaForm));
            label1 = new Label();
            lbl_Valor1 = new Label();
            lbl_Valor2 = new Label();
            lbl_Valor3 = new Label();
            tbx_Valor1 = new TextBox();
            tbx_Valor2 = new TextBox();
            tbx_Valor3 = new TextBox();
            btn_Calcular = new Button();
            lbl_Resultado = new Label();
            btn_Limpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Louis George Cafe", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(197, 9);
            label1.Name = "label1";
            label1.Size = new Size(414, 41);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Valor Maior";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Valor1
            // 
            lbl_Valor1.AutoSize = true;
            lbl_Valor1.BackColor = Color.Transparent;
            lbl_Valor1.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Valor1.ForeColor = SystemColors.ControlLight;
            lbl_Valor1.Location = new Point(169, 77);
            lbl_Valor1.Name = "lbl_Valor1";
            lbl_Valor1.Size = new Size(124, 17);
            lbl_Valor1.TabIndex = 1;
            lbl_Valor1.Text = "Primeiro Valor :";
            // 
            // lbl_Valor2
            // 
            lbl_Valor2.AutoSize = true;
            lbl_Valor2.BackColor = Color.Transparent;
            lbl_Valor2.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Valor2.ForeColor = SystemColors.ControlLight;
            lbl_Valor2.Location = new Point(169, 110);
            lbl_Valor2.Name = "lbl_Valor2";
            lbl_Valor2.Size = new Size(124, 17);
            lbl_Valor2.TabIndex = 2;
            lbl_Valor2.Text = "Segundo Valor :";
            // 
            // lbl_Valor3
            // 
            lbl_Valor3.AutoSize = true;
            lbl_Valor3.BackColor = Color.Transparent;
            lbl_Valor3.Font = new Font("Louis George Cafe", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Valor3.ForeColor = SystemColors.ControlLight;
            lbl_Valor3.Location = new Point(169, 143);
            lbl_Valor3.Name = "lbl_Valor3";
            lbl_Valor3.Size = new Size(120, 17);
            lbl_Valor3.TabIndex = 3;
            lbl_Valor3.Text = "Terceiro Valor :";
            // 
            // tbx_Valor1
            // 
            tbx_Valor1.Font = new Font("Louis George Cafe", 12F, FontStyle.Italic, GraphicsUnit.Point);
            tbx_Valor1.Location = new Point(310, 72);
            tbx_Valor1.Name = "tbx_Valor1";
            tbx_Valor1.Size = new Size(318, 26);
            tbx_Valor1.TabIndex = 5;
            // 
            // tbx_Valor2
            // 
            tbx_Valor2.Font = new Font("Louis George Cafe", 12F, FontStyle.Italic, GraphicsUnit.Point);
            tbx_Valor2.Location = new Point(310, 105);
            tbx_Valor2.Name = "tbx_Valor2";
            tbx_Valor2.Size = new Size(318, 26);
            tbx_Valor2.TabIndex = 6;
            // 
            // tbx_Valor3
            // 
            tbx_Valor3.Font = new Font("Louis George Cafe", 12F, FontStyle.Italic, GraphicsUnit.Point);
            tbx_Valor3.Location = new Point(310, 138);
            tbx_Valor3.Name = "tbx_Valor3";
            tbx_Valor3.Size = new Size(318, 26);
            tbx_Valor3.TabIndex = 7;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Calcular.Location = new Point(169, 182);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(208, 36);
            btn_Calcular.TabIndex = 8;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.BackColor = SystemColors.Control;
            lbl_Resultado.Location = new Point(169, 247);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(459, 93);
            lbl_Resultado.TabIndex = 9;
            lbl_Resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Limpar
            // 
            btn_Limpar.Font = new Font("Louis George Cafe", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpar.Location = new Point(420, 182);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(208, 36);
            btn_Limpar.TabIndex = 10;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click_1;
            // 
            // TelaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 361);
            Controls.Add(btn_Limpar);
            Controls.Add(lbl_Resultado);
            Controls.Add(btn_Calcular);
            Controls.Add(tbx_Valor3);
            Controls.Add(tbx_Valor2);
            Controls.Add(tbx_Valor1);
            Controls.Add(lbl_Valor3);
            Controls.Add(lbl_Valor2);
            Controls.Add(lbl_Valor1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "TelaForm";
            ShowIcon = false;
            Text = "TelaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_Valor1;
        private Label lbl_Valor2;
        private Label lbl_Valor3;
        private TextBox tbx_Valor1;
        private TextBox tbx_Valor2;
        private TextBox tbx_Valor3;
        private Button btn_Calcular;
        private Label lbl_Resultado;
        private Button btn_Limpar;
    }
}