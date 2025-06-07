using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mines
{
    class PlaceHolderManager
    {
        private readonly Dictionary<Guna2TextBox, string> placeholders = new();

        public void AddPlaceholder(Guna2TextBox textBox, string placeholderText)
        {
            placeholders[textBox] = placeholderText;
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.White;

            textBox.Enter -= TextBox_Enter;
            textBox.Leave -= TextBox_Leave;
            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox tb && placeholders.ContainsKey(tb))
            {
                if (tb.Text == placeholders[tb])
                {
                    tb.Text = "";
                    tb.ForeColor = Color.White;
                }
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox tb && placeholders.ContainsKey(tb))
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholders[tb];
                    tb.ForeColor = Color.Gray;
                }
            }
        }
    }
}
