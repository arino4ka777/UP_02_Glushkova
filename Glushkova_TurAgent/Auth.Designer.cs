namespace Glushkova_TurAgent
{
    partial class Auth
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
            this.LabelCaptcha = new System.Windows.Forms.Label();
            this.TextBoxCaptcha = new System.Windows.Forms.TextBox();
            this.ButtonChangeCaptcha = new System.Windows.Forms.Button();
            this.PictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.signBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.buttonShowOrHidePass = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCaptcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonShowOrHidePass)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCaptcha
            // 
            this.LabelCaptcha.AutoSize = true;
            this.LabelCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.LabelCaptcha.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCaptcha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelCaptcha.Location = new System.Drawing.Point(90, 276);
            this.LabelCaptcha.Name = "LabelCaptcha";
            this.LabelCaptcha.Size = new System.Drawing.Size(131, 23);
            this.LabelCaptcha.TabIndex = 31;
            this.LabelCaptcha.Text = "Скрытый текст";
            // 
            // TextBoxCaptcha
            // 
            this.TextBoxCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TextBoxCaptcha.Location = new System.Drawing.Point(93, 304);
            this.TextBoxCaptcha.Name = "TextBoxCaptcha";
            this.TextBoxCaptcha.Size = new System.Drawing.Size(256, 29);
            this.TextBoxCaptcha.TabIndex = 30;
            this.TextBoxCaptcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonChangeCaptcha
            // 
            this.ButtonChangeCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ButtonChangeCaptcha.Location = new System.Drawing.Point(184, 393);
            this.ButtonChangeCaptcha.Name = "ButtonChangeCaptcha";
            this.ButtonChangeCaptcha.Size = new System.Drawing.Size(72, 23);
            this.ButtonChangeCaptcha.TabIndex = 29;
            this.ButtonChangeCaptcha.Text = "Изменить";
            this.ButtonChangeCaptcha.UseVisualStyleBackColor = true;
            this.ButtonChangeCaptcha.Click += new System.EventHandler(this.ButtonChangeCaptcha_Click);
            // 
            // PictureBoxCaptcha
            // 
            this.PictureBoxCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxCaptcha.Location = new System.Drawing.Point(94, 347);
            this.PictureBoxCaptcha.Name = "PictureBoxCaptcha";
            this.PictureBoxCaptcha.Size = new System.Drawing.Size(256, 40);
            this.PictureBoxCaptcha.TabIndex = 28;
            this.PictureBoxCaptcha.TabStop = false;
            // 
            // signBtn
            // 
            this.signBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.signBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signBtn.Location = new System.Drawing.Point(94, 439);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(256, 39);
            this.signBtn.TabIndex = 27;
            this.signBtn.Text = "Войти";
            this.signBtn.UseVisualStyleBackColor = false;
            this.signBtn.Click += new System.EventHandler(this.SignBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(172, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 39);
            this.label3.TabIndex = 25;
            this.label3.Text = "ВХОД";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(89, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(89, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Логин";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(93, 157);
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(256, 29);
            this.loginTextBox.TabIndex = 22;
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTextBox.Location = new System.Drawing.Point(93, 234);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(256, 26);
            this.passTextBox.TabIndex = 33;
            this.passTextBox.TabStop = false;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // buttonShowOrHidePass
            // 
            this.buttonShowOrHidePass.BackColor = System.Drawing.SystemColors.Window;
            this.buttonShowOrHidePass.Image = global::Glushkova_TurAgent.Properties.Resources.Show;
            this.buttonShowOrHidePass.Location = new System.Drawing.Point(322, 235);
            this.buttonShowOrHidePass.Name = "buttonShowOrHidePass";
            this.buttonShowOrHidePass.Size = new System.Drawing.Size(25, 24);
            this.buttonShowOrHidePass.TabIndex = 34;
            this.buttonShowOrHidePass.TabStop = false;
            this.buttonShowOrHidePass.Click += new System.EventHandler(this.buttonShowOrHidePass_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Glushkova_TurAgent.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(438, 505);
            this.Controls.Add(this.buttonShowOrHidePass);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.LabelCaptcha);
            this.Controls.Add(this.TextBoxCaptcha);
            this.Controls.Add(this.ButtonChangeCaptcha);
            this.Controls.Add(this.PictureBoxCaptcha);
            this.Controls.Add(this.signBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginTextBox);
            this.Name = "Auth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Auth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCaptcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonShowOrHidePass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCaptcha;
        private System.Windows.Forms.TextBox TextBoxCaptcha;
        private System.Windows.Forms.Button ButtonChangeCaptcha;
        private System.Windows.Forms.PictureBox PictureBoxCaptcha;
        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.PictureBox buttonShowOrHidePass;
    }
}