namespace Labirinto
{
    partial class frmPortal
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
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Cyan;
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.Location = new Point(285, 134);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(256, 180);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Começar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // frmPortal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnIniciar);
            Name = "frmPortal";
            Text = "frmPortal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
    }
}