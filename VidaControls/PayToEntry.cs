using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VidaControls.DTOs;

namespace VidaControls
{
    public partial class PayToEntry: UserControl
    {
        PayToEntryDTO payToEntryDTO;
        List<PayToEntryDTO> payToEntryList = new List<PayToEntryDTO>();

        public PayToEntry()
        {
            InitializeComponent();
            lbPayees.DrawMode = DrawMode.OwnerDrawFixed;
        }

        private void ValidateEntries(IEnumerable<TextBox> TextBoxes)
        {
            Validator validate = new Validator();
            bool fail = false;
            payToEntryDTO = new PayToEntryDTO();

            foreach (TextBox tb in TextBoxes)
            {

                switch (tb.Name)
                {
                    case "tbPayTo":
                        if (!string.IsNullOrWhiteSpace(tb.Text))
                        {
                            payToEntryDTO.ToName = tb.Text;
                            tb.BackColor = Color.White;
                        }
                        else
                        {
                            tb.BackColor = Color.Red;
                        }
                        break;
                    case "tbDueDate":
                        if (validate.ValidateInteger(tb.Text))
                        {
                            payToEntryDTO.DateOfMonthDue = Convert.ToInt32(tb.Text);
                            tb.BackColor = Color.White;
                        }
                        else
                        {
                            tb.BackColor = Color.Red;
                        }
                        break;
                    case "tbAPR":
                        if (validate.ValidateDecimal(tb.Text, true))
                        {
                            payToEntryDTO.APR = string.IsNullOrWhiteSpace(tb.Text) ? 0.0M : Convert.ToDecimal(tb.Text);
                            tb.BackColor = Color.FromArgb(255, 255, 178);
                        }
                        else
                        {
                            tb.BackColor = Color.Red;
                        }
                        break;
                    case "tbTotalOwed":
                        // if there is an APR, there must be a TotalOwed
                       // there can be a totalowed without an apr


                        if (validate.ValidateDecimal(tb.Text, true))
                        {
                            payToEntryDTO.TotalOwed = string.IsNullOrWhiteSpace(tb.Text) ? 0.0M : Convert.ToDecimal(tb.Text);
                            tb.BackColor = Color.FromArgb(255, 255, 178);

                            if (!string.IsNullOrWhiteSpace(tbAPR.Text) && string.IsNullOrWhiteSpace(tb.Text))
                            {
                                tb.BackColor = Color.Red;
                            }
                        }
                        break;
                    case "tbMinimumPayment":
                        if (validate.ValidateDecimal(tb.Text))
                        {
                            payToEntryDTO.MinimumPayment = Convert.ToDecimal(tb.Text);
                            tb.BackColor = Color.White;
                        }
                        else
                        {
                            tb.BackColor = Color.Red;
                        }
                        break;
                }
            }

            fail = CheckForFailure();
            

            if (!fail)
            {
                payToEntryList.Add(payToEntryDTO);
                AddToListBox(payToEntryDTO);
            }
        }

        private bool CheckForFailure()
        {
            if ((from c in Controls.OfType<TextBox>() where c.BackColor == Color.Red select c).Count() > 0)
            {
                return true;
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool fail = false;

            IEnumerable<TextBox> textBoxes = from c in Controls.OfType<TextBox>()
                                      select c;

            ValidateEntries(textBoxes);

            fail = CheckForFailure();

            if (!fail)
            {
                foreach (TextBox t in Controls.OfType<TextBox>())
                {
                    t.Text = string.Empty;
                }
            }

            SetFocus();
        }

        private void SetFocus()
        {
            var firstTabStop = from c in Controls.OfType<TextBox>()
                               where c.TabIndex == 1
                               select c;

            var textBoxes = from c in Controls.OfType<TextBox>()
                            where c.BackColor == Color.Red
                            orderby c.TabIndex ascending
                            select c;

            if (textBoxes.Count() == 0)
            {
                firstTabStop.First().Focus();
            }
            else
            {
                textBoxes.First().Focus();
            }
           
        }

        private void AddToListBox(PayToEntryDTO payToEntryDTO)
        {
            // Build this out more for a complete description.  The "TotalOwed" will need update
            // based on other entries.

            StringBuilder sb = new StringBuilder();
            sb.Append($"{payToEntryDTO.ToName}");
            sb.Append($" (Total: {payToEntryDTO.TotalOwed})");
            sb.Append($" [Minimum Monthly Payment: {payToEntryDTO.MinimumPayment}]");

            lbPayees.Items.Add(sb.ToString());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbPayees.SelectedIndex != -1)
            {
                SuppressSelectedListboxItemDTO();
                lbPayees.Refresh();
            }

        }

        private void SuppressSelectedListboxItemDTO()
        {
            object item = lbPayees.SelectedItem;
            string selItem = item.ToString();
            selItem = selItem.Substring(0, selItem.IndexOf("("));
            selItem = selItem.Trim();

            foreach (PayToEntryDTO p in payToEntryList)
            {
                if (p.ToName == selItem)
                {
                    p.Suppressed = true;
                }
            }
        }

        private void UnsuppressSelectedListboxItemDTO()
        {
            object item = lbPayees.SelectedItem;
            string selItem = item.ToString();
            selItem = selItem.Substring(0, selItem.IndexOf("("));
            selItem = selItem.Trim();

            foreach (PayToEntryDTO p in payToEntryList)
            {
                if (p.ToName == selItem)
                {
                    p.Suppressed = false;
                }
            }
        }

        private bool IsListboxItemSuppressed(string name)
        {
            name = name.Substring(0, name.IndexOf("("));
            name = name.Trim();

            var ItemDTO = from dto in payToEntryList
                          where dto.ToName == name
                          select dto.Suppressed;

            if (ItemDTO.First())
            {
                return true;
            }

            return false;
        }

        private void lbPayees_DrawItem(object sender, DrawItemEventArgs e)
        {
            if(e.Index != -1) { 
                string itemName = lbPayees.Items[e.Index].ToString();
                bool suppressed = IsListboxItemSuppressed(itemName);
                FontStyle fontStyle = FontStyle.Regular;
                Font font;

                if (suppressed)
                {
                    fontStyle = FontStyle.Strikeout;
                }

                font = new Font("Microsoft Sans Serif", 8.25f, fontStyle);
                e.DrawBackground();
                e.Graphics.DrawString(itemName, font, Brushes.Black, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void btnUndelete_Click(object sender, EventArgs e)
        {
            UnsuppressSelectedListboxItemDTO();
            lbPayees.Refresh();
        }

        private void PayToEntry_Load(object sender, EventArgs e)
        {
            SetFocus();
            LoadComboBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // pass collection to JSONHelper to mid-tier logic for saving in the DAL.
        }

        private void LoadComboBox()
        {
            List<string> accounts = LoadAccountTypes();
            foreach (string s in accounts)
            {
                cbAccounts.Items.Add(s);
            }
            
        }

        private List<string> LoadAccountTypes()
        {
            // call the mid-tier and get the list of pre-set Account Types
            // This data would be pulled from the database

            List<string> accounts = new List<string>();
            accounts.Add("Mortgage");
            accounts.Add("Student Loans");
            accounts.Add("Auto Loan");
            accounts.Add("Motorcycle Loan");
            accounts.Add("Boat Loan");
            accounts.Add("Personal Loan");
            accounts.Add("Credit Card");
            accounts.Add("Utilities (Power)");
            accounts.Add("Utilities (Gas)");
            accounts.Add("Utilities (Water)");
            accounts.Add("Home Phone");
            accounts.Add("Mobile Phone");

            return accounts;
        }
    }
}
