using System;
using System.Windows.Forms;

namespace OOP_FINAL_PROJECT
{
    /// <summary>
    /// Small modal dialog for entering quantity + remarks
    /// when doing Check In, Check Out, Damage, or Lost actions.
    /// </summary>
    public class InventoryActionDialog : Form
    {
        public int    Quantity { get; private set; } = 1;
        public string Remarks  { get; private set; } = "";

        private NumericUpDown nudQty;
        private TextBox       txtRemarks;
        private Button        btnOK;
        private Button        btnCancel;

        public InventoryActionDialog(string action, string itemName)
        {
            this.Text          = $"{action} — {itemName}";
            this.ClientSize    = new System.Drawing.Size(340, 200);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox   = false;
            this.MinimizeBox   = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor     = System.Drawing.Color.White;

            var lblInfo = new Label
            {
                Text      = $"Recording: {action} for \"{itemName}\"",
                Location  = new System.Drawing.Point(14, 14),
                Size      = new System.Drawing.Size(310, 20),
                Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(13, 71, 161)
            };

            var lblQty = new Label
            {
                Text      = "Quantity:",
                Location  = new System.Drawing.Point(14, 48),
                Size      = new System.Drawing.Size(80, 20),
                Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
            };

            nudQty = new NumericUpDown
            {
                Location = new System.Drawing.Point(100, 46),
                Size     = new System.Drawing.Size(80, 24),
                Minimum  = 1, Maximum = 9999, Value = 1,
                Font     = new System.Drawing.Font("Segoe UI", 10F)
            };

            var lblRemarks = new Label
            {
                Text      = "Remarks:",
                Location  = new System.Drawing.Point(14, 84),
                Size      = new System.Drawing.Size(80, 20),
                Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
            };

            txtRemarks = new TextBox
            {
                Location    = new System.Drawing.Point(14, 106),
                Size        = new System.Drawing.Size(308, 24),
                Font        = new System.Drawing.Font("Segoe UI", 9.5F),
                PlaceholderText = "Enter reason or notes (optional)"
            };

            btnOK = new Button
            {
                Text      = "Confirm",
                Location  = new System.Drawing.Point(120, 148),
                Size      = new System.Drawing.Size(100, 34),
                BackColor = System.Drawing.Color.FromArgb(255, 111, 0),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat,
                Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                DialogResult = DialogResult.OK
            };
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.Click += (s, e) =>
            {
                Quantity = (int)nudQty.Value;
                Remarks  = txtRemarks.Text.Trim();
            };

            btnCancel = new Button
            {
                Text         = "Cancel",
                Location     = new System.Drawing.Point(228, 148),
                Size         = new System.Drawing.Size(94, 34),
                FlatStyle    = FlatStyle.Flat,
                Font         = new System.Drawing.Font("Segoe UI", 9F),
                ForeColor    = System.Drawing.Color.FromArgb(100, 100, 100),
                DialogResult = DialogResult.Cancel
            };

            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
            this.Controls.AddRange(new Control[] {
                lblInfo, lblQty, nudQty, lblRemarks, txtRemarks, btnOK, btnCancel });
        }
    }
}
