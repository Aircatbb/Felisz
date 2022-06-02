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
    public partial class formCégadatok : Form
    {
        public formCégadatok()
        {
            InitializeComponent();
        }

        private void cbBankKód_Validated(object sender, EventArgs e)
        {
            Standard tempTalálat = Adatbázis.SzámlavezetőBankok.Find(item => item.Kód == cbBankKód.Text);
            if (tempTalálat != null) tbSzámlavazetőBankNeve.Text = tempTalálat.Megnevezés;

            if (cbBankKód.Text != "")
            {
                Funkciók.CímkeSzínBeállítás(lbBankKód, true);
                Funkciók.CímkeSzínBeállítás(lbSzámlavezetőBankNeve, true);
            }
            else
            {
                Funkciók.CímkeSzínBeállítás(lbBankKód, false);
                Funkciók.CímkeSzínBeállítás(lbSzámlavezetőBankNeve, false);
            }
        }

        private void tbBankSzámlaszám_Validated(object sender, EventArgs e)
        {
            if (tbBankSzámlaszám.Text.Length == 16) tbBankSzámlaszám.Text = tbBankSzámlaszám.Text.Substring(0, 8) + "-" + tbBankSzámlaszám.Text.Substring(8, 8);
            if (tbBankSzámlaszám.Text.Length == 8) tbBankSzámlaszám.Text = tbBankSzámlaszám.Text + "-00000000";

            if (tbBankSzámlaszám.Text != "" && Funkciók.SzámlaszámEllenőrzés(cbBankKód.Text + "-" + tbBankSzámlaszám.Text) && tbBankSzámlaszám.Text.Length == 17)
            {
                Funkciók.CímkeSzínBeállítás(lbSzámlaSzám, true);
            }
            else
            {
                Funkciók.CímkeSzínBeállítás(lbSzámlaSzám, false);
            }
        }

        private void formCégadatok_Shown(object sender, EventArgs e)
        {
            Funkciók.cbBankKódFeltöltés(cbBankKód,tbSzámlavazetőBankNeve);

        }

        private void tbEmail_Validated(object sender, EventArgs e)
        {
            Funkciók.EmailValidálás(lbEmail, tbEmail, true);
        }
    }
}
