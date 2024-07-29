namespace sign_in
{
    partial class Form6
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
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            label4 = new Label();
            textBox1 = new TextBox();
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
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(loginbutton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(passwordtxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(emailtxt);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(166, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 427);
            panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(388, 295);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(162, 29);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AliceBlue;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(23, 249);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(213, 240);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(273, 39);
            textBox1.TabIndex = 6;
            // 
            // loginbutton
            // 
            loginbutton.BackColor = Color.Yellow;
            loginbutton.Location = new Point(213, 351);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(152, 51);
            loginbutton.TabIndex = 5;
            loginbutton.Text = "Sign up";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(23, 182);
            label3.Name = "label3";
            label3.Size = new Size(184, 30);
            label3.TabIndex = 4;
            label3.Text = "Create Password :";
            // 
            // passwordtxt
            // 
            passwordtxt.Font = new Font("Segoe UI", 12F);
            passwordtxt.Location = new Point(213, 177);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new Size(273, 39);
            passwordtxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(23, 122);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 2;
            label2.Text = "Enter Email :";
            // 
            // emailtxt
            // 
            emailtxt.Font = new Font("Segoe UI", 12F);
            emailtxt.Location = new Point(213, 117);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(273, 39);
            emailtxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 28);
            label1.Name = "label1";
            label1.Size = new Size(173, 55);
            label1.TabIndex = 0;
            label1.Text = "Sign up";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(950, 575);
            Controls.Add(panel1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button loginbutton;
        private Label label3;
        private TextBox passwordtxt;
        private Label label2;
        private TextBox emailtxt;
        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private CheckBox checkBox1;
    }
}