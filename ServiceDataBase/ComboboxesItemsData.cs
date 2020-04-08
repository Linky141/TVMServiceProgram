using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ServiceDataBase
{
    class ComboboxesItemsData
    {
               

        public List<string> FillStatusCombobox(int step)
        {
            switch (step)
            {
                case 1:
                    List<string> lista = new List<string>();
                    lista.Add("Do naprawy");
                    lista.Add("Do uzgodnienia");
                    lista.Add("Do transportu");
                    lista.Add("Anulowane");
                    lista.Add("Likwidacja");
                    return lista;
                default:
                    return new List<string>();
            }
        }

        public List<string> FillRodzajNaprawyCombobox()
        {
            List<string> lista = new List<string>();
            lista.Add("Warsztatowa");
            lista.Add("Gwarancyjna");
            lista.Add("Terenowa");
            return lista;
        }


        public List<string> FillRodzajSprzetuCombobox()
        {
            if (!Directory.Exists(@"C:\SERWIS")) Directory.CreateDirectory(@"C:\SERWIS");
            if (!File.Exists(@"C:\SERWIS\RodzajSprzetuData.eb"))
            {
                StreamWriter sw = File.CreateText(@"C:\SERWIS\RodzajSprzetuData.eb");
                sw.Close();
            }

            List<string> lista = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\SERWIS\RodzajSprzetuData.eb", Encoding.Default))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        lista.Add(line);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Error reading file:\n" + e.Message);
            }
            return lista;
        }

        public List<string> FillMarkaSprzetuCombobox()
        {
            if (!Directory.Exists(@"C:\SERWIS")) Directory.CreateDirectory(@"C:\SERWIS");
            if (!File.Exists(@"C:\SERWIS\MarkaSprzetuData.eb"))
            {
                StreamWriter sw = File.CreateText(@"C:\SERWIS\MarkaSprzetuData.eb");
                sw.Close();
            }

            List<string> lista = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\SERWIS\MarkaSprzetuData.eb", Encoding.Default))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        lista.Add(line);
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("Error reading file:\n" + e.Message);
            }
            return lista;
        }
    }
}