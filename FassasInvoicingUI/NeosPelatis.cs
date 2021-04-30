using FassasInvoicingLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FassasInvoicingUI
{
    public partial class NeosPelatis : Form
    {
        public NeosPelatis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Eteria model = new Eteria(afmtextbox.Text, eponimiatextbox.Text, drastiriotitatextbox.Text, doytextbox.Text, diefthinsitextbox.Text,
                                      politextbox.Text, tktextbox.Text, xoratextbox.Text, tilefonotextbox.Text, emailtextbox.Text







                    );
                //model.Afm = afmtextbox.Text;
               // model.Eponimia = eponimiatextbox.Text;
               // model.Drastiriotita = drastiriotitatextbox.Text;
                //model.Doy = doytextbox.Text;
                //model.Diefthinsi = diefthinsitextbox.Text;
                //model.Poli = politextbox.Text;
                //model.Tk = tktextbox.Text;
                //model.Xora = xoratextbox.Text;
               // model.Tilefono = tilefonotextbox.Text;
               // model.Email = emailtextbox.Text;

                GlobalConfig.Connection.CreatePelatis(model);

                afmtextbox.Text = "";
                eponimiatextbox.Text = "";
                drastiriotitatextbox.Text = "";
                doytextbox.Text = "";
                diefthinsitextbox.Text = "";
                politextbox.Text = "";
                tktextbox.Text = "";
                xoratextbox.Text = "";
                tilefonotextbox.Text = "";
                emailtextbox.Text = "";

                MessageBox.Show("H Εισαγωγή ολοκληρώθηκε.");


            }
            else
            {
                MessageBox.Show("Λάθος στην εισαγωγή δεδομένων, παρακαλώ ξαναπροσπαθήστε.");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;

            if (afmtextbox.Text.Length < 9)
            {
                output = false;
                MessageBox.Show("Λάθος ΑΦΜ!");
            }
            if (tktextbox.Text.Length < 5)
            {
                output = false;
                MessageBox.Show("Λάθος ΤΚ!");
            }

            if (tilefonotextbox.Text.Length < 10)
            {
                output = false;
                MessageBox.Show("Λάθος τηλέφωνο!");
            }
           


            return output;
        }

        private void NeosPelatis_Load(object sender, EventArgs e)
        {

        }
    }
}
