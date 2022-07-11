using P04AplikacjaZawodnicy.Core.Repositories;
using System;

namespace P02AplikacjaZawodnicy
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void Odswiez()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            int strona = Convert.ToInt32(txtStrona.Text);
            var wynik = zr.Szukaj(txtFiltr.Text,strona);
            lbDane.DataSource = wynik.Zawodnicy;

            lbDane.DataTextField = "ImieNazwiskoKraj";
            lbDane.DataValueField = "Id_zawodnika";
            lbDane.DataBind();

            lblLiczbaStron.Text = Convert.ToString(wynik.LiczbaStron);

            btnPrawo.Enabled = strona != wynik.LiczbaStron;
            btnLewo.Enabled = strona != 1;
        }

        protected void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idZaznaczonego = Convert.ToInt32(lbDane.SelectedValue);
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik zaznaczony = zr.PodajZawodnika(idZaznaczonego);

            txtImie.Text = zaznaczony.Imie;
            txtNazwisko.Text = zaznaczony.Nazwisko;
            txtKraj.Text = zaznaczony.Kraj;

            // if(zaznaczony.Data_ur != null)
            //txtDataUr= zaznaczony.Data_ur.ToString()

            txtDataUr.Text = zaznaczony.Data_ur?.ToString("yyyy-MM-dd");
            txtWzrost.Text = zaznaczony.Wzrost?.ToString();
            txtWaga.Text = zaznaczony.Waga?.ToString();


        }

        protected void btnEdytuj_Click(object sender, EventArgs e)
        {
            int idZaznaczonego = Convert.ToInt32(lbDane.SelectedValue);
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik zaznaczony = zr.PodajZawodnika(idZaznaczonego);

            ZczytajDaneZFormularza(zaznaczony);

            zr.Edytuj(zaznaczony);
            Odswiez();
        }

        private void ZczytajDaneZFormularza(Zawodnik zaznaczony)
        {
            zaznaczony.Imie = txtImie.Text;
            zaznaczony.Nazwisko = txtNazwisko.Text;
            zaznaczony.Kraj = txtKraj.Text;

            //zaznaczony.Data_ur = string.IsNullOrWhiteSpace(txtDataUr.Text) ? null : Convert.ToDateTime(zaznaczony.Data_ur);
            if (!string.IsNullOrWhiteSpace(txtDataUr.Text))
                zaznaczony.Data_ur = Convert.ToDateTime(txtDataUr.Text);
            else
                zaznaczony.Data_ur = null;

            if (!string.IsNullOrWhiteSpace(txtWaga.Text))
                zaznaczony.Waga = Convert.ToInt32(txtWaga.Text);
            else
                zaznaczony.Waga = null;

            if (!string.IsNullOrWhiteSpace(txtWzrost.Text))
                zaznaczony.Wzrost = Convert.ToInt32(txtWzrost.Text);
            else
                zaznaczony.Wzrost = null;
        }

        protected void btnNowy_Click(object sender, EventArgs e)
        {
            Zawodnik z = new Zawodnik();
            ZczytajDaneZFormularza(z);
            ZawodnicyRepository zr = new ZawodnicyRepository();
            zr.Dodaj(z);
            Odswiez();
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            int idZaznaczonego = Convert.ToInt32(lbDane.SelectedValue);
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik zaznaczony = zr.PodajZawodnika(idZaznaczonego);
            zr.Usun(zaznaczony);
            Odswiez();
        }

        protected void btnLewo_Click(object sender, EventArgs e)
        {
            txtStrona.Text = Convert.ToString(Convert.ToInt32(txtStrona.Text) - 1);
            Odswiez();
        }

        protected void btnPrawo_Click(object sender, EventArgs e)
        {
            txtStrona.Text = Convert.ToString(Convert.ToInt32(txtStrona.Text) + 1);
            Odswiez();
        }

        protected void txtFiltr_TextChanged(object sender, EventArgs e)
        {
            txtStrona.Text = "1";
            Odswiez();
        }
    }
}