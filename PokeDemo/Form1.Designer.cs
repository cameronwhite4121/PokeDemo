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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblPoke2 = new Label();
            progressBar2 = new ProgressBar();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 309);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 142);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(373, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(151, 143);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblPoke2
            // 
            lblPoke2.AutoSize = true;
            lblPoke2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPoke2.Location = new Point(259, 69);
            lblPoke2.Name = "lblPoke2";
            lblPoke2.Size = new Size(68, 20);
            lblPoke2.TabIndex = 3;
            lblPoke2.Text = "Venusaur";
            // 
            // progressBar2
            // 
            progressBar2.ForeColor = Color.Lime;
            progressBar2.Location = new Point(259, 101);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(100, 23);
            progressBar2.TabIndex = 5;
            progressBar2.Value = 100;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Lime;
            progressBar1.Location = new Point(216, 341);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 8;
            progressBar1.Value = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, 309);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 7;
            label1.Text = "Charizard";
            // 
            // button1
            // 
            button1.Location = new Point(21, 32);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 10;
            button1.Text = "Flamethrower";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(21, 61);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 11;
            button2.Text = "Air Slash";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(129, 32);
            button3.Name = "button3";
            button3.Size = new Size(96, 23);
            button3.TabIndex = 12;
            button3.Text = "Smokescreen";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(129, 61);
            button4.Name = "button4";
            button4.Size = new Size(96, 23);
            button4.TabIndex = 13;
            button4.Text = "Fire Spin";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(340, 309);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 100);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Moves";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 450);
            Controls.Add(groupBox1);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(progressBar2);
            Controls.Add(lblPoke2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Poke Demo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblPoke2;
        private ProgressBar progressBar2;
        private ProgressBar progressBar1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
    }
}
