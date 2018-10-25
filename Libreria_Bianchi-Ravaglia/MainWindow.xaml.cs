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
using System.IO;
using System.Windows.Forms;
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
        }

        private void btn_SearchFile_Click(object sender, RoutedEventArgs e)
        {
           
            // apertura della finestra di ricerca del file
            OpenFileDialog window = new OpenFileDialog();
            window.Filter = "File xml (*.xml)|*.xml|All files (*.*)|*.*";
            window.ShowDialog();
            System.Windows.Forms.MessageBox.Show("CIAO");
            txt_FilePath.Text = window.FileName;
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

            // caricamento file
            fileSorgente = XDocument.Load(@"..\..\libri.xml");

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
    }
}
