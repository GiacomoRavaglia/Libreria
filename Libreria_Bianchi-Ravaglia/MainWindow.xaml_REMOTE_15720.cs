﻿using System;
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
using System.Xml.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Libreria_Bianchi_Ravaglia
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_SearchFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog window = new OpenFileDialog();
            window.Filter = "File xml (*.xml)|*.xml|All files (*.*)|*.*";
            window.ShowDialog();

            txt_FilePath.Text = window.FileName;
        }


        private void btn_LoadFile_Click(object sender, RoutedEventArgs e)
        {
            mainForm.pathFile = txt_FilePath.Text;
        }

        private void btn_CreateFile_Click(object sender, RoutedEventArgs e)
        {
            mainForm.pathFile = "..";

        }
        
    }
}