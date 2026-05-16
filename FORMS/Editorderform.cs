using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using OOP_FINAL_PROJECT.Models;

namespace OOP_FINAL_PROJECT
{
    public partial class EditOrderForm : Form
    {
        private OrderRepository _orderRepo = new OrderRepository();
        private MenuItemRepository _menuRepo = new MenuItemRepository();

        private int _orderID;
        private string _currentStatus;
        private List<EditableOrderItem> _items = new List<EditableOrderItem>();

        public EditOrderForm(int orderID, string currentStatus)
        {
            _orderID = orderID;
            _currentStatus = currentStatus;
            InitializeComponent();
            LoadOrderDetails();
            LoadMenuItems();
        }

        private void LoadOrderDetails()
        {
            lblOrderInfo.Text = $"Order #{_orderID}  |  Status: {_currentStatus}";

            bool canEdit = _currentStatus == "Pending";
            btnSave.Enabled = canEdit;
            btnCancelOrder.Enabled = canEdit;
            btnIncrease.Enabled = canEdit;
            btnDecrease.Enabled = canEdit;
            btnRemoveItem.Enabled = canEdit;
            btnAddItem.Enabled = canEdit;
            cboMenuItems.Enabled = canEdit;
            nudQty.Enabled = canEdit;

            lblEditNote.Text = canEdit
                ? "Select an item below and click + Add Item to add it to the order."
                : $"⚠ Order is {_currentStatus} — only Pending orders can be modified.";

            DataTable dt = _orderRepo.GetOrderDetails(_orderID);
            _items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                _items.Add(new EditableOrderItem
                {
                    DetailID = Convert.ToInt32(row["detailID"]),
                    ItemName = row["name"].ToString(),
                    Price = Convert.ToDouble(row["price"]),
                    Quantity = Convert.ToInt32(row["orderQty"]),
                    OriginalQty = Convert.ToInt32(row["orderQty"])
                });
            }
            RefreshGrid();
        }

        private void LoadMenuItems()
        {
            DataTable dt = _menuRepo.GetAll();
            cboMenuItems.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                cboMenuItems.Items.Add(new MenuItemEntry
                {
                    ItemID = Convert.ToInt32(row["itemID"]),
                    Name = row["name"].ToString(),
                    Price = Convert.ToDouble(row["price"]),
                    Category = row["category"].ToString()
                });
            }
            if (cboMenuItems.Items.Count > 0)
                cboMenuItems.SelectedIndex = 0;
        }

        private void RefreshGrid()
        {
            dgvItems.Rows.Clear();
            double total = 0;
            foreach (var item in _items)
            {
                double sub = item.Price * item.Quantity;
                int idx = dgvItems.Rows.Add(item.DetailID, item.ItemName,
                                               $"₱{item.Price:F2}", item.Quantity, $"₱{sub:F2}");
                if (item.Quantity == 0)
                    dgvItems.Rows[idx].DefaultCellStyle.ForeColor = Color.Red;
                else if (item.DetailID == 0) // newly added
                    dgvItems.Rows[idx].DefaultCellStyle.ForeColor = Color.FromArgb(33, 150, 243);
                total += sub;
            }
            lblTotal.Text = $"New Total: ₱{total:F2}";
        }

        // ── Existing item controls ────────────────────────────
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null) { MessageBox.Show("Select an item first."); return; }
            int idx = dgvItems.CurrentRow.Index;
            if (idx < _items.Count) { _items[idx].Quantity++; RefreshGrid(); }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null) { MessageBox.Show("Select an item first."); return; }
            int idx = dgvItems.CurrentRow.Index;
            if (idx < _items.Count && _items[idx].Quantity > 0)
            { _items[idx].Quantity--; RefreshGrid(); }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null) { MessageBox.Show("Select an item first."); return; }
            int idx = dgvItems.CurrentRow.Index;
            if (idx < _items.Count) { _items[idx].Quantity = 0; RefreshGrid(); }
        }

        // ── Add new item ──────────────────────────────────────
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cboMenuItems.SelectedItem == null) return;

            var selected = (MenuItemEntry)cboMenuItems.SelectedItem;
            int qty = (int)nudQty.Value;

            // Check if item already exists in order — increase qty instead
            var existing = _items.Find(x => x.ItemName == selected.Name && x.Quantity > 0);
            if (existing != null)
            {
                existing.Quantity += qty;
                RefreshGrid();
                MessageBox.Show($"Added {qty} more '{selected.Name}' to order.", "Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Add as new item (DetailID = 0 means it's new — will INSERT not UPDATE)
            _items.Add(new EditableOrderItem
            {
                DetailID = 0,
                ItemName = selected.Name,
                Price = selected.Price,
                Quantity = qty,
                OriginalQty = 0,
                ItemID = selected.ItemID
            });

            RefreshGrid();
            MessageBox.Show($"'{selected.Name}' x{qty} added to order!", "Item Added",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── Cancel entire order ───────────────────────────────
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                $"Are you sure you want to CANCEL Order #{_orderID}?\nThis cannot be undone.",
                "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            _orderRepo.UpdateStatus(_orderID, "Cancelled");
            SessionManager.NotifyOrderChanged();
            MessageBox.Show($"Order #{_orderID} has been cancelled.", "Cancelled");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // ── Save changes ──────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if all items are zero
            bool allZero = true;
            foreach (var item in _items)
                if (item.Quantity > 0) { allZero = false; break; }

            if (allZero)
            {
                var confirm = MessageBox.Show(
                    "All items removed. This will cancel the order.\nContinue?",
                    "Cancel Order?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes) return;
                _orderRepo.UpdateStatus(_orderID, "Cancelled");
                SessionManager.NotifyOrderChanged();
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            double newTotal = 0;
            foreach (var item in _items)
            {
                if (item.DetailID == 0 && item.Quantity > 0)
                {
                    // New item — INSERT into OrderDetails
                    var detail = new OrderDetail
                    {
                        OrderID = _orderID,
                        ItemID = item.ItemID,
                        Quantity = item.Quantity,
                        Price = item.Price
                    };
                    _orderRepo.AddOrderDetail(detail);
                }
                else if (item.DetailID > 0)
                {
                    if (item.Quantity == 0)
                        _orderRepo.DeleteOrderDetail(item.DetailID);
                    else if (item.Quantity != item.OriginalQty)
                        _orderRepo.UpdateOrderDetailQty(item.DetailID, item.Quantity);
                }
                newTotal += item.Price * item.Quantity;
            }

            _orderRepo.UpdateOrderTotal(_orderID, newTotal);
            SessionManager.NotifyOrderChanged();
            MessageBox.Show($"Order #{_orderID} updated!\nNew Total: ₱{newTotal:F2}",
                "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

    public class EditableOrderItem
    {
        public int DetailID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int OriginalQty { get; set; }
    }

    public class MenuItemEntry
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public override string ToString() => $"{Name}  —  ₱{Price:F2}  ({Category})";
    }
}