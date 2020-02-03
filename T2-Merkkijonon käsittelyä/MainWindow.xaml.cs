using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace T2_Tekstien_käsittelyä
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTekstejä_Click(object sender, RoutedEventArgs e)
        {
            txbTulokset.Text = "- " + txtEtunimi.Text + " " + txtSukunimi.Text;


            txbTulokset.Text += "\n- Isoilla kirjaimilla " + txtEtunimi.Text.ToUpper() + " " + txtSukunimi.Text.ToUpper();
            txbTulokset.Text += "\n- Pienillä kirjaimilla " + txtEtunimi.Text.ToLower() + " " + txtSukunimi.Text.ToLower();

            char etu = txtEtunimi.Text[0];

            char suku = txtSukunimi.Text[0];

            txbTulokset.Text += "\n- Nimikirjaimet isolla " + etu.ToString().ToUpper() + suku.ToString().ToUpper();
            txbTulokset.Text += "\n- Nimikirjaimet pienillä " + etu.ToString().ToLower() + suku.ToString().ToLower();

            int etuLkm = txtEtunimi.Text.Length;

            int sukuLkm = txtSukunimi.Text.Length;
            int yhtLkm = etuLkm + sukuLkm;

            txbTulokset.Text += "\n- Etunimessä kirjaimia " + etuLkm + ", sukunimessä kirjaimia " + sukuLkm + ", kirjaimia yhteensä " + yhtLkm;

            etu = txtEtunimi.Text[etuLkm - 1];
            suku = txtSukunimi.Text[sukuLkm - 1];

            txbTulokset.Text += "\n- Etu- ja sukunimen viimeinen kirjain isolla " + etu.ToString().ToUpper() + suku.ToString().ToUpper();
            txbTulokset.Text += "\n- Etu- ja sukunimen viimeinen kirjain pienellä " + etu.ToString().ToLower() + suku.ToString().ToLower();

            Random arpoja = new Random();
            int paikka = arpoja.Next(yhtLkm);
            string kokonimi = txtEtunimi.Text + txtSukunimi.Text;
    
            char kirjain = kokonimi[paikka];
            txbTulokset.Text += "\n- Arvottiin nimestä kirjain " + kirjain;

            kirjain++;
            txbTulokset.Text += "\n- Aakkosissa seuraava kirjain " + kirjain;


        }
    }
}
