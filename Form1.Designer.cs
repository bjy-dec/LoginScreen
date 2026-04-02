namespace LoginScreen
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
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblErrorMsg = new Label();
            btnClearID = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(272, 10);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(255, 120);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(106, 154);
            txtID.Name = "txtID";
            txtID.Size = new Size(553, 54);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.TextChanged += txtID_TextChanged;
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(106, 253);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(553, 54);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 255, 255);
            btnLogin.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLogin.ForeColor = Color.FromArgb(0, 0, 192);
            btnLogin.Location = new Point(272, 384);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(237, 71);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(106, 340);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(287, 20);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // btnClearID
            // 
            btnClearID.BackColor = Color.LightGray;
            btnClearID.FlatAppearance.BorderSize = 0;
            btnClearID.FlatStyle = FlatStyle.Flat;
            btnClearID.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClearID.ForeColor = Color.Gray;
            btnClearID.Location = new Point(608, 164);
            btnClearID.Name = "btnClearID";
            btnClearID.Size = new Size(39, 39);
            btnClearID.TabIndex = 5;
            btnClearID.Text = "✕";
            btnClearID.UseVisualStyleBackColor = false;
            btnClearID.Click += btnClearID_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 510);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(btnClearID);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Button btnClearID;
        private Label lblErrorMsg;
    }
}
