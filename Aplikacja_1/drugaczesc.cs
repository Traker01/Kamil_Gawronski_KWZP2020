using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacja_1
{
    public partial class drugaczesc : Form
    {
        public drugaczesc(SzwalniaEntities db, String empleyeeLastName)
        {
            InitializeComponent();

            Pracownicy employee = db.Pracownicy.Where(pracownik => pracownik.Nazwisko == empleyeeLastName).First();

            labeltitle.Text = employee.Imie + " " + employee.Nazwisko;
            txtName.Text = employee.Imie;
            txtLastName.Text = employee.Nazwisko;
            txtPesel.Text = employee.Pesel;
            txtAddress.Text = employee.Adres;
                     
        }


    }
}
