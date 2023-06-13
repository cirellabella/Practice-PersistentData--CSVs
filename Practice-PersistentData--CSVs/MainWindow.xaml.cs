using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
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
using CsvHelper;

namespace Practice_PersistentData__CSVs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string filePath = "wallets";
        public List<Wallet> loadedWallets = new List<Wallet>();
        public MainWindow()
        {
            InitializeComponent();
            Preload();

            loadedWallets = LoadCSV<Wallet>(filePath);
            lvWallets.ItemsSource = loadedWallets;
        }//end main

        public List<T> LoadCSV<T>(string filePath)
        {
            // Loading a csv file to a list of type that we can work with
            List<T> tempList = new List<T>();
            using (StreamReader sr = new StreamReader(filePath))
            using (CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture))
            {
                // We are saving a list of an object to work with in our program
                tempList = csv.GetRecords<T>().ToList();
            }

            return tempList;
        }

        public void LoadCSV(string filePath, List<Wallet> list)
        {
            // Loading a csv file to a list of type that we can work with
            using (StreamReader sr = new StreamReader(filePath))
            using (CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture))
            {
                // We are saving a list of an object to work with in our program
                list = csv.GetRecords<Wallet>().ToList();
            }
        }

        //preload
        public void Preload()
        {
            List<Wallet> wallets = new List<Wallet>
            {
                new Wallet("black", 3, 4, 8, 2, "Infiniti", "Business Wallets", "leather", "tri-fold"),
                new Wallet("black", 3, 8, 15, 3, "Rose", "Lifestyle Wallets", "fabric", "checkbook")
            };

            SaveCSVFile(filePath, wallets);
        }

        //save method
        public void SaveCSVFile<T>(string filePath, List<T> list)
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            //string filePath = "students.csv";

            using (var stream = File.Open(filePath, FileMode.OpenOrCreate))
            using (var writer = new StreamWriter(stream))
            using (var csvWriter = new CsvWriter(writer, ci))
            {
                // .WriteRecords(list);
                csvWriter.WriteRecords(list);
                writer.Flush();
            }

        }//end save method

    }//end class

}//end namespace
