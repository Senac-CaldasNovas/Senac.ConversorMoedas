﻿namespace Senac.ConversorMoedas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            buttonConverter = new Button();
            panel4 = new Panel();
            textBoxValorDestino = new TextBox();
            panel6 = new Panel();
            comboBoxMoedaDestino = new ComboBox();
            pictureBoxImagemDestino = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            textBoxValorOrigem = new TextBox();
            panel5 = new Panel();
            comboBoxMoedaOrigem = new ComboBox();
            label2 = new Label();
            pictureBoxImagemOrigem = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripLabelValorMoedas = new ToolStripLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagemDestino).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagemOrigem).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(326, 15);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 0;
            label1.Text = "Converter Moedas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(buttonConverter);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 400);
            panel2.TabIndex = 0;
            // 
            // buttonConverter
            // 
            buttonConverter.Image = (Image)resources.GetObject("buttonConverter.Image");
            buttonConverter.Location = new Point(375, 178);
            buttonConverter.Name = "buttonConverter";
            buttonConverter.Size = new Size(50, 50);
            buttonConverter.TabIndex = 2;
            buttonConverter.UseVisualStyleBackColor = true;
            buttonConverter.Click += buttonConverter_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(textBoxValorDestino);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(488, 78);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 250);
            panel4.TabIndex = 1;
            // 
            // textBoxValorDestino
            // 
            textBoxValorDestino.Enabled = false;
            textBoxValorDestino.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxValorDestino.Location = new Point(16, 121);
            textBoxValorDestino.Name = "textBoxValorDestino";
            textBoxValorDestino.Size = new Size(269, 29);
            textBoxValorDestino.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(comboBoxMoedaDestino);
            panel6.Controls.Add(pictureBoxImagemDestino);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 50);
            panel6.TabIndex = 0;
            // 
            // comboBoxMoedaDestino
            // 
            comboBoxMoedaDestino.FormattingEnabled = true;
            comboBoxMoedaDestino.Items.AddRange(new object[] { "Bitcoin", "Dólar", "Euro", "Iene", "Real" });
            comboBoxMoedaDestino.Location = new Point(202, 18);
            comboBoxMoedaDestino.Name = "comboBoxMoedaDestino";
            comboBoxMoedaDestino.Size = new Size(83, 23);
            comboBoxMoedaDestino.TabIndex = 5;
            comboBoxMoedaDestino.SelectedIndexChanged += comboBoxMoedaDestino_SelectedIndexChanged;
            // 
            // pictureBoxImagemDestino
            // 
            pictureBoxImagemDestino.Location = new Point(3, 7);
            pictureBoxImagemDestino.Name = "pictureBoxImagemDestino";
            pictureBoxImagemDestino.Size = new Size(40, 40);
            pictureBoxImagemDestino.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagemDestino.TabIndex = 3;
            pictureBoxImagemDestino.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(49, 16);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 4;
            label3.Text = "Moeda destino";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(textBoxValorOrigem);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(12, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 250);
            panel3.TabIndex = 0;
            // 
            // textBoxValorOrigem
            // 
            textBoxValorOrigem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxValorOrigem.Location = new Point(17, 121);
            textBoxValorOrigem.Name = "textBoxValorOrigem";
            textBoxValorOrigem.Size = new Size(269, 29);
            textBoxValorOrigem.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(comboBoxMoedaOrigem);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(pictureBoxImagemOrigem);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 50);
            panel5.TabIndex = 0;
            // 
            // comboBoxMoedaOrigem
            // 
            comboBoxMoedaOrigem.FormattingEnabled = true;
            comboBoxMoedaOrigem.Items.AddRange(new object[] { "Bitcoin", "Dólar", "Euro", "Iene", "Real" });
            comboBoxMoedaOrigem.Location = new Point(203, 16);
            comboBoxMoedaOrigem.Name = "comboBoxMoedaOrigem";
            comboBoxMoedaOrigem.Size = new Size(83, 23);
            comboBoxMoedaOrigem.TabIndex = 2;
            comboBoxMoedaOrigem.SelectedIndexChanged += comboBoxMoedaOrigem_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(49, 16);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 1;
            label2.Text = "Moeda origem";
            // 
            // pictureBoxImagemOrigem
            // 
            pictureBoxImagemOrigem.ErrorImage = null;
            pictureBoxImagemOrigem.Location = new Point(3, 7);
            pictureBoxImagemOrigem.Name = "pictureBoxImagemOrigem";
            pictureBoxImagemOrigem.Size = new Size(40, 40);
            pictureBoxImagemOrigem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagemOrigem.TabIndex = 0;
            pictureBoxImagemOrigem.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabelValorMoedas });
            toolStrip1.Location = new Point(0, 425);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelValorMoedas
            // 
            toolStripLabelValorMoedas.Name = "toolStripLabelValorMoedas";
            toolStripLabelValorMoedas.Size = new Size(12, 22);
            toolStripLabelValorMoedas.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Senac - Conversor de Moedas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagemDestino).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagemOrigem).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private Label label1;
        private Panel panel4;
        private Panel panel6;
        private Panel panel3;
        private Panel panel5;
        private ComboBox comboBoxMoedaDestino;
        private PictureBox pictureBoxImagemDestino;
        private Label label3;
        private ComboBox comboBoxMoedaOrigem;
        private Label label2;
        private PictureBox pictureBoxImagemOrigem;
        private Button buttonConverter;
        private Label labelValorMoedaDestino;
        private TextBox textBoxValorDestino;
        private Label labelValorMoedaOrigem;
        private TextBox textBoxValorOrigem;
        private ToolStripLabel toolStripLabelValorMoedas;
    }
}
