namespace OOP_FINAL_PROJECT
{
    partial class PINPromptForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.pnlHeader.Controls.AddRange(new System.Windows.Forms.Control[] { this.lblTitle, this.lblSubtitle });
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 70;
            this.pnlHeader.Name = "pnlHeader";

            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Manager Authorization";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(255, 200, 200);
            this.lblSubtitle.Location = new System.Drawing.Point(22, 44);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Enter the Manager PIN to edit this order";

            // lblPrompt
            this.lblPrompt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrompt.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.lblPrompt.Location = new System.Drawing.Point(30, 88);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(230, 24);
            this.lblPrompt.Text = "Enter 4-digit PIN:";

            // txtPIN — display only, never receives focus
            this.txtPIN.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.txtPIN.Location = new System.Drawing.Point(30, 115);
            this.txtPIN.MaxLength = 4;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.ReadOnly = true;
            this.txtPIN.TabStop = false;
            this.txtPIN.Size = new System.Drawing.Size(230, 48);
            this.txtPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPIN.UseSystemPasswordChar = true;
            this.txtPIN.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.txtPIN.Cursor = System.Windows.Forms.Cursors.Default;

            // lblAttempts
            this.lblAttempts.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblAttempts.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.lblAttempts.Location = new System.Drawing.Point(30, 166);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(230, 18);
            this.lblAttempts.Text = "";
            this.lblAttempts.Visible = false;

            // ── Number pad buttons (no loop — explicit setup) ──
            // Row 1: 1 2 3
            this.btn1.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btn1.Location = new System.Drawing.Point(30, 190);
            this.btn1.Name = "btn1"; this.btn1.Size = new System.Drawing.Size(68, 46);
            this.btn1.Text = "1";
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btn1.Click += new System.EventHandler(this.btnPIN_Click);

            this.btn2.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btn2.Location = new System.Drawing.Point(106, 190);
            this.btn2.Name = "btn2"; this.btn2.Size = new System.Drawing.Size(68, 46);
            this.btn2.Text = "2";
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btn2.Click += new System.EventHandler(this.btnPIN_Click);

            this.btn3.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btn3.Location = new System.Drawing.Point(182, 190);
            this.btn3.Name = "btn3"; this.btn3.Size = new System.Drawing.Size(68, 46);
            this.btn3.Text = "3";
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btn3.Click += new System.EventHandler(this.btnPIN_Click);

            // Row 2: 4 5 6
            this.btn4.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btn4.Location = new System.Drawing.Point(30, 244);
            this.btn4.Name = "btn4"; this.btn4.Size = new System.Drawing.Size(68, 46);
            this.btn4.Text = "4";
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btn4.Click += new System.EventHandler(this.btnPIN_Click);

            this.btn5.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btn5.Location = new System.Drawing.Point(106, 244);
            this.btn5.Name = "btn5"; this.btn5.Size = new System.Drawing.Size(68, 46);
            this.btn5.Text = "5";
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btn5.Click += new System.EventHandler(this.btnPIN_Click);

            this.btn6.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btn6.Location = new System.Drawing.Point(182, 244);
            this.btn6.Name = "btn6"; this.btn6.Size = new System.Drawing.Size(68, 46);
            this.btn6.Text = "6";
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btn6.Click += new System.EventHandler(this.btnPIN_Click);

            // Row 3: 7 8 9
            this.btn7.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btn7.Location = new System.Drawing.Point(30, 298);
            this.btn7.Name = "btn7"; this.btn7.Size = new System.Drawing.Size(68, 46);
            this.btn7.Text = "7";
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btn7.Click += new System.EventHandler(this.btnPIN_Click);

            this.btn8.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btn8.Location = new System.Drawing.Point(106, 298);
            this.btn8.Name = "btn8"; this.btn8.Size = new System.Drawing.Size(68, 46);
            this.btn8.Text = "8";
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btn8.Click += new System.EventHandler(this.btnPIN_Click);

            this.btn9.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btn9.Location = new System.Drawing.Point(182, 298);
            this.btn9.Name = "btn9"; this.btn9.Size = new System.Drawing.Size(68, 46);
            this.btn9.Text = "9";
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btn9.Click += new System.EventHandler(this.btnPIN_Click);

            // Row 4: ⌫ 0 CLR
            this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBackspace.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnBackspace.Location = new System.Drawing.Point(30, 352);
            this.btnBackspace.Name = "btnBackspace"; this.btnBackspace.Size = new System.Drawing.Size(68, 46);
            this.btnBackspace.Text = "⌫";
            this.btnBackspace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);

            this.btn0.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.btn0.Location = new System.Drawing.Point(106, 352);
            this.btn0.Name = "btn0"; this.btn0.Size = new System.Drawing.Size(68, 46);
            this.btn0.Text = "0";
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btn0.Click += new System.EventHandler(this.btnPIN_Click);

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnClear.Location = new System.Drawing.Point(182, 352);
            this.btnClear.Name = "btnClear"; this.btnClear.Size = new System.Drawing.Size(68, 46);
            this.btnClear.Text = "CLR";
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Confirm & Cancel
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(30, 415);
            this.btnConfirm.Name = "btnConfirm"; this.btnConfirm.Size = new System.Drawing.Size(220, 44);
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnCancel.Location = new System.Drawing.Point(30, 467);
            this.btnCancel.Name = "btnCancel"; this.btnCancel.Size = new System.Drawing.Size(220, 30);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // PINPromptForm
            this.ClientSize = new System.Drawing.Size(280, 515);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PINPromptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Authorization";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PINPromptForm_KeyPress);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlHeader, this.lblPrompt, this.txtPIN, this.lblAttempts,
                this.btn1, this.btn2, this.btn3,
                this.btn4, this.btn5, this.btn6,
                this.btn7, this.btn8, this.btn9,
                this.btnBackspace, this.btn0, this.btnClear,
                this.btnConfirm, this.btnCancel
            });

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}