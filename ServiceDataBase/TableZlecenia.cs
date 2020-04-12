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

    }
}
