namespace Mines
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtUser = new Guna.UI2.WinForms.Guna2TextBox();
            btnEnter = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BorderColor = Color.Blue;
            txtUser.CustomizableEdges = customizableEdges1;
            txtUser.DefaultText = "";
            txtUser.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUser.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUser.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUser.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUser.FillColor = Color.Black;
            txtUser.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.Silver;
            txtUser.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUser.Location = new Point(212, 273);
            txtUser.Margin = new Padding(8, 11, 8, 11);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "";
            txtUser.SelectedText = "";
            txtUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUser.Size = new Size(369, 65);
            txtUser.TabIndex = 1;
            txtUser.TextAlign = HorizontalAlignment.Center;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // btnEnter
            // 
            btnEnter.CustomizableEdges = customizableEdges3;
            btnEnter.DisabledState.BorderColor = Color.DarkGray;
            btnEnter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEnter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEnter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEnter.FillColor = Color.Black;
            btnEnter.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(314, 339);
            btnEnter.Name = "btnEnter";
            btnEnter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnEnter.Size = new Size(150, 41);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Enter";
            btnEnter.Click += btnEnter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(185, 78);
            label1.Name = "label1";
            label1.Size = new Size(448, 159);
            label1.TabIndex = 3;
            label1.Text = "SUGAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(212, 251);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 4;
            label2.Text = "Unique Nickname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(519, 251);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "e.g. Binx";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 498);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEnter);
            Controls.Add(txtUser);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtUser;
        private Guna.UI2.WinForms.Guna2Button btnEnter;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
