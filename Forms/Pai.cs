using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovSoft.Forms
{
    public partial class Pai : Form
    {
        public Pai()
        {
            InitializeComponent();
        }

        protected void AjustarSelectorMaskedTextBox()
        {
            foreach (MaskedTextBox input in this.Controls.OfType<MaskedTextBox>()) 
            {
                input.Click += (sender, e) =>
                {
                    if (string.IsNullOrEmpty(input.Text))
                    {
                        input.Select(0, 0);
                    }
                };
            }
        }
    }
}
