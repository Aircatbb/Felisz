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
    public partial class formVáltozásLista : Form
    {
        public formVáltozásLista()
        {
            InitializeComponent();
        }

        private void formVáltozásLista_Load(object sender, EventArgs e)
        {
            rtbVáltozásLista.Text= Properties.Resources.VáltozásLista;
            lbVerzió.Text="Jelenlegi verzió: "+ System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
        }
    }
}
