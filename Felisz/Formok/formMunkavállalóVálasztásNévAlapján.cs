using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Felisz.Formok
{
    public partial class formMunkavállalóVálasztásNévAlapján : Form
    {
        public static string selName = "";
        public formMunkavállalóVálasztásNévAlapján()
        {
            InitializeComponent();
        }

        private void tbNév_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                formMunkavállalóVálasztásNévAlapján.selName = tbNév.Text;
                this.Close();
            }
        }
    }
}
