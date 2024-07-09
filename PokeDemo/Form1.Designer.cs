namespace PokeDemo
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
            lblPoke1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblPoke2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblPoke1
            // 
            lblPoke1.AutoSize = true;
            lblPoke1.Location = new Point(75, 244);
            lblPoke1.Name = "lblPoke1";
            lblPoke1.Size = new Size(57, 15);
            lblPoke1.TabIndex = 0;
            lblPoke1.Text = "Charizard";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(75, 273);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(545, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblPoke2
            // 
            lblPoke2.AutoSize = true;
            lblPoke2.Location = new Point(545, 80);
            lblPoke2.Name = "lblPoke2";
            lblPoke2.Size = new Size(55, 15);
            lblPoke2.TabIndex = 3;
            lblPoke2.Text = "Venusaur";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPoke2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblPoke1);
            Name = "Form1";
            Text = "Poke Demo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPoke1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblPoke2;
    }
}
