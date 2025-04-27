namespace PRELABORATORIO_I___PRACTICA_SUPERVISADA
{
    partial class CREDITOS
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oswald", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 51);
            label1.Name = "label1";
            label1.Size = new Size(310, 29);
            label1.TabIndex = 0;
            label1.Text = "Miguel Leonardo de León Quiñonez";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_04_27_154152;
            pictureBox1.Location = new Point(191, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 268);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CREDITOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 363);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "CREDITOS";
            Text = "CREDITOS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
    }
}