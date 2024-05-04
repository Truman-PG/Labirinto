namespace Labirinto
{
    partial class frmSalaUm
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
            btnSetaDireita = new Button();
            btnSetaCima = new Button();
            btnLimbo = new Button();
            btnSetaBaixo = new Button();
            SuspendLayout();
            // 
            // btnSetaDireita
            // 
            btnSetaDireita.Cursor = Cursors.Hand;
            btnSetaDireita.Location = new Point(619, 166);
            btnSetaDireita.Name = "btnSetaDireita";
            btnSetaDireita.Size = new Size(169, 102);
            btnSetaDireita.TabIndex = 0;
            btnSetaDireita.Text = "⮕";
            btnSetaDireita.UseVisualStyleBackColor = true;
            btnSetaDireita.Click += btnSetaDireita_Click;
            // 
            // btnSetaCima
            // 
            btnSetaCima.Cursor = Cursors.Hand;
            btnSetaCima.Location = new Point(320, 12);
            btnSetaCima.Name = "btnSetaCima";
            btnSetaCima.Size = new Size(167, 123);
            btnSetaCima.TabIndex = 1;
            btnSetaCima.Text = "⬆";
            btnSetaCima.UseVisualStyleBackColor = true;
            btnSetaCima.Click += btnSetaCima_Click;
            // 
            // btnLimbo
            // 
            btnLimbo.Cursor = Cursors.Hand;
            btnLimbo.Location = new Point(12, 166);
            btnLimbo.Name = "btnLimbo";
            btnLimbo.Size = new Size(173, 101);
            btnLimbo.TabIndex = 2;
            btnLimbo.Text = "???";
            btnLimbo.UseVisualStyleBackColor = true;
            btnLimbo.Click += btnLimbo_Click;
            // 
            // btnSetaBaixo
            // 
            btnSetaBaixo.Cursor = Cursors.Hand;
            btnSetaBaixo.Location = new Point(320, 312);
            btnSetaBaixo.Name = "btnSetaBaixo";
            btnSetaBaixo.Size = new Size(171, 111);
            btnSetaBaixo.TabIndex = 3;
            btnSetaBaixo.Text = "⬇";
            btnSetaBaixo.UseVisualStyleBackColor = true;
            btnSetaBaixo.Click += btnSetaBaixo_Click;
            // 
            // frmSalaUm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSetaBaixo);
            Controls.Add(btnLimbo);
            Controls.Add(btnSetaCima);
            Controls.Add(btnSetaDireita);
            Name = "frmSalaUm";
            Text = "frmSalaUm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSetaDireita;
        private Button btnSetaCima;
        private Button btnLimbo;
        private Button btnSetaBaixo;
    }
}