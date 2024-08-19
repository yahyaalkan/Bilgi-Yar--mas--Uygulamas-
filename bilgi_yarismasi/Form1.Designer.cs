namespace bilgi_yarismasi
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
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            lblSoru2 = new Label();
            lblDogru2 = new Label();
            lblYanlis2 = new Label();
            btnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblSoru = new Label();
            lblDogru = new Label();
            lblYanlis = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(39, 47);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(504, 232);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(58, 318);
            btnA.Name = "btnA";
            btnA.Size = new Size(193, 42);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(302, 318);
            btnB.Name = "btnB";
            btnB.Size = new Size(193, 42);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(58, 395);
            btnC.Name = "btnC";
            btnC.Size = new Size(193, 42);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(302, 395);
            btnD.Name = "btnD";
            btnD.Size = new Size(193, 42);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // lblSoru2
            // 
            lblSoru2.AutoSize = true;
            lblSoru2.Location = new Point(585, 71);
            lblSoru2.Name = "lblSoru2";
            lblSoru2.Size = new Size(78, 23);
            lblSoru2.TabIndex = 5;
            lblSoru2.Text = "Soru No:";
            // 
            // lblDogru2
            // 
            lblDogru2.AutoSize = true;
            lblDogru2.Location = new Point(585, 114);
            lblDogru2.Name = "lblDogru2";
            lblDogru2.Size = new Size(64, 23);
            lblDogru2.TabIndex = 6;
            lblDogru2.Text = "Doğru:";
            // 
            // lblYanlis2
            // 
            lblYanlis2.AutoSize = true;
            lblYanlis2.Location = new Point(586, 169);
            lblYanlis2.Name = "lblYanlis2";
            lblYanlis2.Size = new Size(60, 23);
            lblYanlis2.TabIndex = 7;
            lblYanlis2.Text = "Yanlış:";
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(586, 226);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(193, 42);
            btnSonraki.TabIndex = 8;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(585, 310);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(777, 310);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(98, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(669, 71);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(20, 23);
            lblSoru.TabIndex = 11;
            lblSoru.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(669, 114);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(20, 23);
            lblDogru.TabIndex = 12;
            lblDogru.Text = "0";
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(669, 169);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(20, 23);
            lblYanlis.TabIndex = 13;
            lblYanlis.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 516);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 14;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 518);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 15;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 690);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblYanlis);
            Controls.Add(lblDogru);
            Controls.Add(lblSoru);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSonraki);
            Controls.Add(lblYanlis2);
            Controls.Add(lblDogru2);
            Controls.Add(lblSoru2);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label lblSoru2;
        private Label lblDogru2;
        private Label lblYanlis2;
        private Button btnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblSoru;
        private Label lblDogru;
        private Label lblYanlis;
        private Label label1;
        private Label label2;
    }
}
