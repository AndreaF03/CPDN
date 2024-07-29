namespace sign_in
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
            panel1 = new Panel();
            button1 = new Button();
            label4 = new Label();
            checkBox1 = new CheckBox();
            loginbutton = new Button();
            label3 = new Label();
            passwordtxt = new TextBox();
            label2 = new Label();
            emailtxt = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(loginbutton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(passwordtxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(emailtxt);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(212, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(563, 485);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(203, 418);
            button1.Name = "button1";
            button1.Size = new Size(152, 51);
            button1.TabIndex = 8;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(260, 361);
            label4.Name = "label4";
            label4.Size = new Size(48, 32);
            label4.TabIndex = 7;
            label4.Text = "OR";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(360, 249);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.Yellow;
            loginbutton.Location = new Point(203, 286);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(152, 51);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Log in";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(47, 211);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 4;
            label3.Text = "Password  :";
            label3.Click += label3_Click;
            // 
            // passwordtxt
            // 
            passwordtxt.Location = new Point(154, 205);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new Size(273, 31);
            passwordtxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(47, 137);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 2;
            label2.Text = "Email         :";
            label2.Click += label2_Click;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(154, 131);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(273, 31);
            emailtxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 29);
            label1.Name = "label1";
            label1.Size = new Size(160, 55);
            label1.TabIndex = 0;
            label1.Text = "Sign in";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1025, 701);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Expell";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox emailtxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox passwordtxt;
        private Button loginbutton;
        private CheckBox checkBox1;
        private Button button1;
        private Label label4;
    }
}
