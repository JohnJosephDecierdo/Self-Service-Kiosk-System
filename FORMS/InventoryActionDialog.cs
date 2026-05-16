using System;
using System.Windows.Forms;

namespace OOP_FINAL_PROJECT
{
    /// <summary>
    /// Small modal dialog for entering quantity + remarks
    /// when doing Check In, Check Out, Damage, Lost, or Restore actions.
    /// For Restore on "Damaged & Lost" items, also asks which condition is being restored.
    /// </summary>
    public class InventoryActionDialog : Form
    {
        public int    Quantity    { get; private set; } = 1;
        public string Remarks     { get; private set; } = "";
        /// <summary>"Damaged", "Lost", or "Both" — only meaningful for Restore on Damaged & Lost items.</summary>
        public string RestoreType { get; private set; } = "Both";

        private NumericUpDown nudQty;
        private TextBox       txtRemarks;
        private Button        btnOK;
        private Button        btnCancel;

        public InventoryActionDialog(string action, string itemName,
            int maxQuantity = 9999, string currentCondition = "")
        {
            bool isDualCondition = (action == "Restore" && currentCondition == "Damaged & Lost");

            int formHeight = isDualCondition ? 270 : 210;

            this.Text            = $"{action} — {itemName}";
            this.ClientSize      = new System.Drawing.Size(360, formHeight);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;
            this.StartPosition   = FormStartPosition.CenterParent;
            this.BackColor       = System.Drawing.Color.White;

            var lblInfo = new Label
            {
                Text      = $"Recording: {action} for \"{itemName}\"",
                Location  = new System.Drawing.Point(14, 14),
                Size      = new System.Drawing.Size(330, 20),
                Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(13, 71, 161)
            };

            int yOffset = 0; // extra vertical space when radio buttons are shown

            // ── Radio buttons (only for Damaged & Lost restore) ──
            RadioButton rbDamaged = null, rbLost = null, rbBoth = null;
            if (isDualCondition)
            {
                var lblRestoring = new Label
                {
                    Text      = "Restoring:",
                    Location  = new System.Drawing.Point(14, 46),
                    Size      = new System.Drawing.Size(80, 20),
                    Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
                };

                rbDamaged = new RadioButton
                {
                    Text     = "Damaged items",
                    Location = new System.Drawing.Point(100, 44),
                    Size     = new System.Drawing.Size(130, 22),
                    Font     = new System.Drawing.Font("Segoe UI", 9F)
                };
                rbLost = new RadioButton
                {
                    Text     = "Lost items",
                    Location = new System.Drawing.Point(100, 68),
                    Size     = new System.Drawing.Size(110, 22),
                    Font     = new System.Drawing.Font("Segoe UI", 9F)
                };
                rbBoth = new RadioButton
                {
                    Text    = "Both",
                    Location = new System.Drawing.Point(100, 92),
                    Size    = new System.Drawing.Size(70, 22),
                    Font    = new System.Drawing.Font("Segoe UI", 9F),
                    Checked = true
                };

                this.Controls.AddRange(new Control[] { lblRestoring, rbDamaged, rbLost, rbBoth });
                yOffset = 72; // push Qty + Remarks + buttons down
            }

            var lblQty = new Label
            {
                Text      = "Quantity:",
                Location  = new System.Drawing.Point(14, 48 + yOffset),
                Size      = new System.Drawing.Size(80, 20),
                Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
            };

            nudQty = new NumericUpDown
            {
                Location = new System.Drawing.Point(100, 46 + yOffset),
                Size     = new System.Drawing.Size(80, 24),
                Minimum  = 1, Maximum = maxQuantity, Value = 1,
                Font     = new System.Drawing.Font("Segoe UI", 10F)
            };

            var lblRemarks = new Label
            {
                Text      = "Remarks:",
                Location  = new System.Drawing.Point(14, 84 + yOffset),
                Size      = new System.Drawing.Size(80, 20),
                Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(80, 80, 80)
            };

            txtRemarks = new TextBox
            {
                Location        = new System.Drawing.Point(14, 106 + yOffset),
                Size            = new System.Drawing.Size(328, 24),
                Font            = new System.Drawing.Font("Segoe UI", 9.5F),
                PlaceholderText = "Enter reason or notes (optional)"
            };

            btnOK = new Button
            {
                Text         = "Confirm",
                Location     = new System.Drawing.Point(130, 150 + yOffset),
                Size         = new System.Drawing.Size(100, 34),
                BackColor    = System.Drawing.Color.FromArgb(255, 111, 0),
                ForeColor    = System.Drawing.Color.White,
                FlatStyle    = FlatStyle.Flat,
                Font         = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold),
                DialogResult = DialogResult.OK
            };
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.Click += (s, e) =>
            {
                Quantity = (int)nudQty.Value;
                Remarks  = txtRemarks.Text.Trim();
                if (isDualCondition)
                {
                    if (rbDamaged.Checked)     RestoreType = "Damaged";
                    else if (rbLost.Checked)   RestoreType = "Lost";
                    else                       RestoreType = "Both";
                }
            };

            btnCancel = new Button
            {
                Text         = "Cancel",
                Location     = new System.Drawing.Point(238, 150 + yOffset),
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
