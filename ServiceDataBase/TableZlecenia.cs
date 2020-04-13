using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataBase
{
    public class TableZlecenia
    {
        private List<RowZlecenia> table = null;

        //pusty konstruktor bez parametrów
        public TableZlecenia()
        {
            table = new List<RowZlecenia>();
        }

        //konstruktor z parematrami listy o nazwie 'table'
        public TableZlecenia(List<RowZlecenia> table)
        {
            this.table = table;
        }

        //tworzenie metody settera o nazwie 'setTable'
        public void setTable(List<RowZlecenia> val) 
        { 
            table = val;
        }

        //tworzenie metody gettera o nazwie 'getTable'
        public List<RowZlecenia> getTable () 
        { 
            return table; 
        }

        //metoda czyszczenia tabeli
        public void Clear()
        {
            table = null;
        }

        //Powieranie wartości z określonego numery wiersza tabeli
        public RowZlecenia getRow(int number)
        {
            return table[number];
        }

        //dodawanie nowego wiersza do tabeli
        public void addRow(RowZlecenia val)
        {
            table.Add(val);
        }


        //metody odczytu i zapisu
        public void serialize()
        {
            this.serialize(@"C:\SERWIS\Zlecenia.xaml");
        }
        
        public void serialize(string path)
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(List<RowZlecenia>));
            System.IO.StreamWriter writer = new System.IO.StreamWriter(path);
            xmlSerializer.Serialize(writer, table);
            writer.Close();
        }

        public void deserialize()
        {
            this.deserialize(@"C:\SERWIS\Zlecenia.xaml");
        }
        
        public void deserialize(string path)
        {
            System.Xml.Serialization.XmlSerializer xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(List<RowZlecenia>));
            System.IO.StreamReader reader = new System.IO.StreamReader(path);
            table = (List<RowZlecenia>)xmlSerializer.Deserialize(reader);
            reader.Close();
        }


        public void saveAsBin()
        {
            this.saveAsBin(@"C:\SERWIS\Zlecenia.bin");
        }

        public void saveAsBin(string path)
        {
            using (System.IO.Stream stream = System.IO.File.Open(path, System.IO.FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, table);
            }
        }

        public void readAsBin()
        {
            this.readAsBin(@"C:\SERWIS\Zlecenia.bin");
        }

        public void readAsBin(string path)
        {
            using (System.IO.Stream stream = System.IO.File.Open(path, System.IO.FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                table =  (List<RowZlecenia>)binaryFormatter.Deserialize(stream);
            }
        }

        public void saveAsTxt()
        {
            this.saveAsTxt(@"C:\SERWIS\Zlecenia.txt");
        }

        public void saveAsTxt(string path)
        {
            using (System.IO.StreamWriter outputFile = new System.IO.StreamWriter(path))
            {
                foreach (RowZlecenia row in table)
                {
                    outputFile.Write(row.numerZlecenia + ";");
                    outputFile.Write(row.nazwisko + ";");
                    outputFile.Write(row.status + ";");
                    outputFile.Write(row.koszt + ";");
                    outputFile.Write(row.model + ";");
                    outputFile.Write(row.rodzajSprzetu + ";");
                    outputFile.Write(row.marka + ";");
                    outputFile.Write(row.dataPrzyjecia.ToString() + ";");
                    outputFile.Write(row.dataRozliczenia.ToString() + ";");
                    outputFile.Write(row.dataOdbioru.ToString() + ";");
                    outputFile.Write(row.dataZakonczenia.ToString() + ";");
                    outputFile.Write(row.kosztRobocizny + ";");
                    outputFile.Write(row.kosztMaterialu + ";");
                    outputFile.Write(row.kosztTransportu + ";");
                    outputFile.Write(row.rodzajNaprawy + ";");
                    outputFile.Write(row.miejscowosc + ";");
                    outputFile.Write(row.kodPocztowy + ";");
                    outputFile.Write(row.adres + ";");
                    outputFile.Write(row.nip + ";");
                    outputFile.Write(row.telefon1 + ";");
                    outputFile.Write(row.telefon2 + ";");
                    outputFile.Write(row.email + ";");
                    outputFile.Write(row.numerFabryczny + ";");
                    outputFile.Write(row.godzinaPrzyjecia.ToString() + ";");
                    outputFile.Write(row.numerRachunku + ";");
                    outputFile.Write(row.zaliczka + ";");
                    outputFile.Write(row.opis + ";");
                    outputFile.Write(row.user + ";");
                    outputFile.Write(row.Zamkniete.ToString() + ";");
                    outputFile.Write(row.przywoz.ToString() + ";");
                    outputFile.Write(row.pilot.ToString() + ";");
                    outputFile.Write(row.przewodZasilajacy.ToString() + ";");
                    outputFile.Write(row.podstawa.ToString() + ";");
                    outputFile.Write(row.wieszak.ToString() + ";");
                    outputFile.Write(row.opakowanie.ToString() + ";");
                    outputFile.Write(row.uwagi + ";");
                }


            }
        }

        public void readAsTxt()
        {
            this.readAsTxt(@"C:\SERWIS\Zlecenia.txt");
        }

        public void readAsTxt(string path)
        {
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
                {
                    table.Clear();
                    string tmpLine = "";
                    while ((tmpLine = sr.ReadLine()) != null)
                    {
                        string[] fragments = tmpLine.Split(';');
                        RowZlecenia tmpRow= new RowZlecenia();

                        tmpRow.numerZlecenia = Int32.Parse(fragments[0]);
                        tmpRow.nazwisko = fragments[1];
                        tmpRow.status = fragments[2];
                        tmpRow.koszt = Double.Parse(fragments[3]);
                        tmpRow.model = fragments[4];
                        tmpRow.rodzajSprzetu = fragments[5];
                        tmpRow.marka = fragments[6];
                        tmpRow.dataPrzyjecia = DateTime.Parse(fragments[7]);
                        tmpRow.dataRozliczenia = DateTime.Parse(fragments[8]);
                        tmpRow.dataOdbioru = DateTime.Parse(fragments[9]);
                        tmpRow.dataZakonczenia = DateTime.Parse(fragments[10]);
                        tmpRow.kosztRobocizny = Double.Parse(fragments[11]);
                        tmpRow.kosztMaterialu = Double.Parse(fragments[12]);
                        tmpRow.kosztTransportu = Double.Parse(fragments[13]);
                        tmpRow.rodzajNaprawy = fragments[14];
                        tmpRow.miejscowosc = fragments[15];
                        tmpRow.kodPocztowy = fragments[16];
                        tmpRow.adres = fragments[17];
                        tmpRow.nip = Int32.Parse(fragments[18]);
                        tmpRow.telefon1 = Int32.Parse(fragments[19]);
                        tmpRow.telefon2 = Int32.Parse(fragments[20]);
                        tmpRow.email = fragments[21];
                        tmpRow.numerFabryczny = fragments[22];
                        tmpRow.godzinaPrzyjecia = DateTime.Parse(fragments[23]);
                        tmpRow.numerRachunku = fragments[24];
                        tmpRow.zaliczka = Double.Parse(fragments[25]);
                        tmpRow.opis = fragments[26];
                        tmpRow.user = fragments[27];
                        tmpRow.Zamkniete = Boolean.Parse(fragments[28]);
                        tmpRow.przywoz = Boolean.Parse(fragments[29]);
                        tmpRow.pilot = Boolean.Parse(fragments[30]);
                        tmpRow.przewodZasilajacy = Boolean.Parse(fragments[31]);
                        tmpRow.podstawa = Boolean.Parse(fragments[32]);
                        tmpRow.wieszak = Boolean.Parse(fragments[33]);
                        tmpRow.opakowanie = Boolean.Parse(fragments[34]);
                        tmpRow.uwagi = fragments[35];

                        table.Add(tmpRow);
                    }
                }
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

    }
}
