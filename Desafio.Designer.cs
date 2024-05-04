namespace Labirinto
{
    partial class frmDesafio
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
            label1 = new Label();
            vasco = new Label();
            numResultadoDesafio = new NumericUpDown();
            btnResposta = new Button();
            ((System.ComponentModel.ISupportInitialize)numResultadoDesafio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("Goudy Stout", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(55, -4);
            label1.Name = "label1";
            label1.Size = new Size(664, 39);
            label1.TabIndex = 0;
            label1.Text = "MASMORRA DA SOLIDÂO";
            // 
            // vasco
            // 
            vasco.AutoSize = true;
            vasco.BackColor = Color.FromArgb(224, 224, 224);
            vasco.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vasco.Location = new Point(192, 62);
            vasco.Name = "vasco";
            vasco.Size = new Size(437, 39);
            vasco.TabIndex = 1;
            vasco.Text = "QUANTO È: 90+(7*8)+(24**2)/4";
            // 
            // numResultadoDesafio
            // 
            numResultadoDesafio.Location = new Point(312, 117);
            numResultadoDesafio.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numResultadoDesafio.Name = "numResultadoDesafio";
            numResultadoDesafio.Size = new Size(180, 31);
            numResultadoDesafio.TabIndex = 2;
            numResultadoDesafio.UpDownAlign = LeftRightAlignment.Left;
            // 
            // btnResposta
            // 
            btnResposta.BackColor = Color.FromArgb(128, 255, 128);
            btnResposta.Cursor = Cursors.Hand;
            btnResposta.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResposta.Location = new Point(325, 176);
            btnResposta.Name = "btnResposta";
            btnResposta.Size = new Size(155, 54);
            btnResposta.TabIndex = 3;
            btnResposta.Text = "RESPONDER!!!";
            btnResposta.UseVisualStyleBackColor = false;
            btnResposta.Click += btnResposta_Click;
            // 
            // frmDesafio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Dica_de_mestre___Masmorras;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnResposta);
            Controls.Add(numResultadoDesafio);
            Controls.Add(vasco);
            Controls.Add(label1);
            Name = "frmDesafio";
            Text = "Desafio";
            ((System.ComponentModel.ISupportInitialize)numResultadoDesafio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label vasco;
        private NumericUpDown numResultadoDesafio;
        private Button btnResposta;
    }
}