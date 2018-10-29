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
using System.Xml.Linq;

namespace Libreria_Bianchi_Ravaglia
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        XDocument fileSorgente = new XDocument();

        public MainWindow()
        {
            InitializeComponent();

            fileSorgente = XDocument.Load(@"..\..\libri.xml");
        }

        private void btn_CreateFile_Click(object sender, RoutedEventArgs e)
        {
            // variabili locali                  
            int cont = 0;                                           // contatore per i dati estratti dal file sorgente
            XDocument newFile;                                      // nuovo file xml con i soli dati richiesti

            // creazione documento e intestazione
            newFile = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"), 
                new XElement("Biblioteca"));

            // estrazione dei codici scheda
            IEnumerable<string> codiciScheda = from codice in fileSorgente.Element("Biblioteca").Elements("wiride")
                                               select codice.Element("codice_scheda").Value;

            // estrazione dei titoli dei libri
            IEnumerable<string> titoliLibri = from titolo in fileSorgente.Element("Biblioteca").Elements("wiride")
                                               select titolo.Element("titolo").Value;

            // estrazione dei cognomi degli autori
            IEnumerable<string> cognomiAutori = from cognome in fileSorgente.Element("Biblioteca").Elements("wiride")
                                              select cognome.Element("autore").Element("cognome").Value;


            // creazione del nuovo file
            foreach (string codice in codiciScheda)
            {
                newFile.Element("Biblioteca").Add(
                   new XElement("Libro", new XElement("codice_scheda", codice),
                   new XElement("Titolo", titoliLibri.ElementAt(cont)),
                   new XElement("Autore", cognomiAutori.ElementAt(cont))));
                cont++;
            }

            newFile.Save(@"..\..\newFile.xml");
        }

        private void btn_cercaAutore_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<string> titoli = from libri in fileSorgente.Elements("Biblioteca").Elements("wiride")
                                         where (string)libri.Element("autore").Element("cognome") == txt_autore.Text
                                         select libri.Element("titolo").Value;

            //stampa titoli
            foreach (string tit in titoli)
                lst_stampa.Items.Add(tit);
        }

        private void btn_copie_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<string> copie = from libri in fileSorgente.Elements("Biblioteca").Elements("wiride")
                                        where (string)libri.Element("titolo") == txt_titolo.Text
                                        select libri.Element("titolo").Value;

            MessageBox.Show("Ci sono " + copie.Count<string>().ToString() + " copie di " + txt_titolo.Text, "Risultato ricerca");
        }

        private void btn_genere_Click(object sender, RoutedEventArgs e)
        {
            int cont = 0;
            IEnumerable<string> titoli = from libri in fileSorgente.Elements("Biblioteca").Elements("wiride")
                                         select libri.Element("genere").Value;

            foreach (string tit in titoli)
            {
                if ((tit == "romanzo") || (tit == "romanzo giallo") || (tit == "romanzo breve") || (tit == "romanzo umoristico"))
                    cont++;
            }

            MessageBox.Show("Ci sono " + cont + " romanzi", "Risultato ricerca");
        }

        private void btn_eliminazioneAbstract_Click(object sender, RoutedEventArgs e)
        {
            XDocument newFile = fileSorgente;

            newFile.Root.Elements("wiride").Elements("abstract").Remove();

            fileSorgente.Save(@"..\..\noAbstract.xml");
        }

        private void btn_cambio1_Click(object sender, RoutedEventArgs e)
        {
            fileSorgente.Root.Elements("wiride").Where(x => x.Element("titolo").Value == txt_CambioTitolo.Text).FirstOrDefault().SetElementValue("genere", txt_CambioGenere.Text);
            fileSorgente.Save(@"..\..\nuovoGenere.xml");
        }
    }
}