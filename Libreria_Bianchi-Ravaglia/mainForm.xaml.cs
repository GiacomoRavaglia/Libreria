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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Libreria_Bianchi_Ravaglia
{
    /// <summary>
    /// Logica di interazione per mainForm.xaml
    /// </summary>
    public partial class mainForm : Window
    {
        public static string pathFile;
        XDocument newFile;

        public mainForm()
        {
            InitializeComponent();
            newFile = XDocument.Load(pathFile);
        }



        private void btn_cercaAutore_Click(object sender, RoutedEventArgs e)//query che restituisce i titoli del autore inserito da input
        {
            IEnumerable<string> titoli = from libri in newFile.Elements("Biblioteca").Elements("wiride")
                                        where (string)libri.Element("autore").Element("cognome") == txt_autore.Text
                                         select libri.Element("titolo").Value;
            foreach (string tit in titoli)//stampa titoli
                lst_stampa.Items.Add(tit);
        }
    }
}
