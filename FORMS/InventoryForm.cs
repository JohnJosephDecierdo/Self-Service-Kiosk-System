using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class InventoryForm : Form
    {
        private InventoryRepository _repo = new InventoryRepository();
        private string _managerUsername = "Manager";

        public InventoryForm(string managerUsername = "Manager")
        {
            _managerUsername = managerUsername;
            InitializeComponent();
            this.Load += (s, e) =>
            {
                LoadSummaryCards();
                LoadInventory();
                LoadAllLogs();
            };
        }

        // ════════════════════════════════════════════════════
        //  SUMMARY CARDS
        // ════════════════════════════════════════════════════
        private void LoadSummaryCards()
        {
            lblTotalItems.Text    = _repo.GetTotalItems().ToString();
            lblLowStock.Text      = _repo.GetLowStockCount().ToString();
            lblDamaged.Text       = _repo.GetDamagedCount().ToString();
            lblLost.Text          = _repo.GetLostCount().ToString();

            // Always white text — cards already have colored backgrounds
            lblLowStock.ForeColor = Color.White;
            lblDamaged.ForeColor  = Color.White;
            lblLost.ForeColor     = Color.White;
        }

        // ════════════════════════════════════════════════════
        //  INVENTORY GRID
        // ════════════════════════════════════════════════════
        private void LoadInventory(string filter = "All")
        {
            DataTable dt;
            switch (filter)
            {
                case "Low Stock":    dt = _repo.GetLowStock();        break;
                case "Damaged/Lost": dt = _repo.GetDamagedOrLost();   break;
                default:
                    string cat = cboFilterCat.SelectedItem?.ToString();
                    dt = (cat != null && cat != "All Categories")
                        ? _repo.GetByCategory(cat)
                        : _repo.GetAll();
                    break;
            }

            dgvInventory.DataSource = dt;
            ColorInventoryRows();
            LoadSummaryCards();
        }

        private void ColorInventoryRows()
        {
            if (dgvInventory.Columns["quantity"] == null) return;
            foreach (DataGridViewRow row in dgvInventory.Rows)
            {
                if (row.IsNewRow) continue;
                string cond = row.Cells["condition"]?.Value?.ToString() ?? "";
                int    qty  = 0;
                int    min  = 0;
                if (row.Cells["quantity"]?.Value != null)
                    int.TryParse(row.Cells["quantity"].Value.ToString(), out qty);
                if (row.Cells["minStock"]?.Value != null)
                    int.TryParse(row.Cells["minStock"].Value.ToString(), out min);

                if (cond == "Lost")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220);
                else if (cond == "Damaged")
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 180);
                else if (qty <= min)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 220);
                else
                    row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            var row = GetSelectedRow(dgvInventory);
            if (row == null) return;
            PopulateForm(row);

            // Load logs for this specific item
            int itemID = Convert.ToInt32(row.Cells["itemID"].Value);
            dgvLogs.DataSource = _repo.GetLogs(itemID);
        }

        private void PopulateForm(DataGridViewRow row)
        {
            txtItemName.Text       = row.Cells["name"]?.Value?.ToString()     ?? "";
            cboCategory.Text       = row.Cells["category"]?.Value?.ToString() ?? "";
            nudQuantity.Value      = Convert.ToDecimal(row.Cells["quantity"]?.Value  ?? 0);
            nudMinStock.Value      = Convert.ToDecimal(row.Cells["minStock"]?.Value  ?? 0);
            cboCondition.Text      = row.Cells["condition"]?.Value?.ToString() ?? "Good";
            cboLocation.Text       = row.Cells["location"]?.Value?.ToString()  ?? "";
            txtNotes.Text          = row.Cells["notes"]?.Value?.ToString()     ?? "";
            txtItemName.BackColor  = Color.White;
        }

        private void ClearForm()
        {
            txtItemName.Text   = "";
            nudQuantity.Value  = 0;
            nudMinStock.Value  = 1;
            txtNotes.Text      = "";
            cboCategory.SelectedIndex  = 0;
            cboCondition.SelectedIndex = 0;
            cboLocation.SelectedIndex  = 0;
            txtItemName.BackColor = Color.White;
        }

        // ════════════════════════════════════════════════════
        //  CRUD BUTTONS
        // ════════════════════════════════════════════════════
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            var item = BuildItemFromForm();
            if (_repo.Add(item))
            {
                MessageBox.Show($"'{item.Name}' added to inventory!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadInventory();
                LoadAllLogs();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow(dgvInventory);
            if (row == null) { MessageBox.Show("Select an item first."); return; }
            if (!ValidateForm()) return;

            var item    = BuildItemFromForm();
            item.ItemID = Convert.ToInt32(row.Cells["itemID"].Value);

            if (_repo.Update(item))
            {
                MessageBox.Show($"'{item.Name}' updated!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInventory();
                LoadAllLogs();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow(dgvInventory);
            if (row == null) { MessageBox.Show("Select an item first."); return; }
            string name = row.Cells["name"].Value?.ToString();
            if (MessageBox.Show($"Delete '{name}' from inventory?\nAll logs will also be deleted.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(row.Cells["itemID"].Value);
                if (_repo.Delete(id)) { ClearForm(); LoadInventory(); LoadAllLogs(); }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboFilterCat.SelectedIndex = 0;
            LoadInventory();
            LoadAllLogs();
        }

        // ════════════════════════════════════════════════════
        //  CHECK IN / CHECK OUT / DAMAGE / LOSS
        // ════════════════════════════════════════════════════
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow(dgvInventory);
            if (row == null) { MessageBox.Show("Select an item first."); return; }
            int id   = Convert.ToInt32(row.Cells["itemID"].Value);
            string nm = row.Cells["name"].Value?.ToString();
            PerformAction("Check In", id, nm);
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow(dgvInventory);
            if (row == null) { MessageBox.Show("Select an item first."); return; }
            int id   = Convert.ToInt32(row.Cells["itemID"].Value);
            string nm = row.Cells["name"].Value?.ToString();
            PerformAction("Check Out", id, nm);
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow(dgvInventory);
            if (row == null) { MessageBox.Show("Select an item first."); return; }
            int id   = Convert.ToInt32(row.Cells["itemID"].Value);
            string nm = row.Cells["name"].Value?.ToString();
            PerformAction("Damaged", id, nm);
        }

        private void btnLost_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow(dgvInventory);
            if (row == null) { MessageBox.Show("Select an item first."); return; }
            int id   = Convert.ToInt32(row.Cells["itemID"].Value);
            string nm = row.Cells["name"].Value?.ToString();
            PerformAction("Lost", id, nm);
        }

        private void btnRestoreCondition_Click(object sender, EventArgs e)
        {
            var row = GetSelectedRow(dgvInventory);
            if (row == null) { MessageBox.Show("Select an item first."); return; }
            int    id   = Convert.ToInt32(row.Cells["itemID"].Value);
            string name = row.Cells["name"].Value?.ToString();

            using (var dlg = new InventoryActionDialog("Restore", name))
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                if (_repo.RestoreCondition(id, dlg.Quantity, dlg.Remarks, _managerUsername))
                {
                    MessageBox.Show($"'{name}' restored to Good condition.", "Restored",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventory();
                    LoadAllLogs();
                }
            }
        }

        private void PerformAction(string action, int itemID, string itemName)
        {
            using (var dlg = new InventoryActionDialog(action, itemName))
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                int    qty     = dlg.Quantity;
                string remarks = dlg.Remarks;
                bool   ok      = false;

                switch (action)
                {
                    case "Check In":  ok = _repo.CheckIn(itemID, qty, remarks, _managerUsername);  break;
                    case "Check Out": ok = _repo.CheckOut(itemID, qty, remarks, _managerUsername);
                        if (!ok) { MessageBox.Show("Not enough stock to check out!", "Insufficient Stock",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning); return; } break;
                    case "Damaged":   ok = _repo.ReportDamage(itemID, qty, remarks, _managerUsername); break;
                    case "Lost":      ok = _repo.ReportLoss(itemID, qty, remarks, _managerUsername);   break;
                }

                if (ok)
                {
                    MessageBox.Show($"{action} recorded for '{itemName}'.", "Done",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInventory();
                    LoadAllLogs();
                }
            }
        }

        // ════════════════════════════════════════════════════
        //  FILTER BUTTONS
        // ════════════════════════════════════════════════════
        private void btnFilterAll_Click(object sender, EventArgs e)     => LoadInventory("All");
        private void btnFilterLow_Click(object sender, EventArgs e)     => LoadInventory("Low Stock");
        private void btnFilterDamaged_Click(object sender, EventArgs e) => LoadInventory("Damaged/Lost");
        private void cboFilterCat_SelectedIndexChanged(object sender, EventArgs e) => LoadInventory("All");

        // ════════════════════════════════════════════════════
        //  LOGS
        // ════════════════════════════════════════════════════
        private void LoadAllLogs()
        {
            dgvLogs.DataSource = _repo.GetLogs(0);
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        // ════════════════════════════════════════════════════
        //  HELPERS
        // ════════════════════════════════════════════════════
        private DataGridViewRow GetSelectedRow(DataGridView dgv)
        {
            if (dgv.SelectedRows.Count > 0) return dgv.SelectedRows[0];
            if (dgv.CurrentRow != null)     return dgv.CurrentRow;
            return null;
        }

        private bool ValidateForm()
        {
            txtItemName.BackColor = Color.White;
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                txtItemName.BackColor = Color.FromArgb(255, 220, 220);
                MessageBox.Show("Item name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private InventoryItem BuildItemFromForm()
        {
            return new InventoryItem
            {
                Name      = txtItemName.Text.Trim(),
                Category  = cboCategory.SelectedItem?.ToString()  ?? "Equipment",
                Quantity  = (int)nudQuantity.Value,
                MinStock  = (int)nudMinStock.Value,
                Condition = cboCondition.SelectedItem?.ToString() ?? "Good",
                Location  = cboLocation.SelectedItem?.ToString()  ?? "Storage",
                Notes     = txtNotes.Text.Trim()
            };
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
            => txtItemName.BackColor = Color.White;
    }
}
