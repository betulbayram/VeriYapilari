using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using LINQtoCSV;

namespace Personeller { 
class HashTable
{
    private const int TABLE_SIZE = 10; // hash tablosu uzunluğu
    private string[] table = new string[TABLE_SIZE];

    private int Hash(int key)
    {
        return key % TABLE_SIZE; // hash fonksiyonumuz
    }

    public void Add(MyObject obj)
    {
        int key = obj.GetId(); // Nesneden anahtar değerini al
        string valStr =obj.GetId() +"," +obj.GetName() + "," + obj.GetSurname() + "," + obj.GetAge() + "," + obj.GetTel() + "," + obj.GetGorev(); // Değeri string olarak al

        int hash = Hash(key);
        int index = hash;
        while (table[index] != null)
        {
            index = (index + 1) % TABLE_SIZE; // Boş adres bulana kadar ilerle
            if (index == hash)
            {
                // Tablo dolu, hata mesajı ver ve çık
                Console.WriteLine("Hash tablosu dolu. Yeni kayıt eklenemedi.");
                return;
            }
        }
        table[index] = valStr;

    }
    public void Remove(int key)
    {
            int hash = Hash(key);
            int index = hash;
            while (table[index] != null)
            {
                if (table[index].StartsWith(key + ","))
                {
                    table[index] = null;
                    return;
                }
                index = (index + 1) % TABLE_SIZE; // Boş adres bulana kadar ilerle
                if (index == hash)
                {
                    // Tablo dolu, hata mesajı ver ve çık
                    Console.WriteLine("Aranan kayıt bulunamadı.");
                    return;
                }
            }
            Console.WriteLine("Aranan kayıt bulunamadı.");
        }



    public string Search(int key)
    {
        int hash = Hash(key);
        string record = table[hash];
        if (record != null)
        {
            return record;
        }
        else
        {
            return "Aranan kayıt bulunamadı.";
        }

    }

    public void LoadPersonalInformation()
    {

        var csvFileDescription = new CsvFileDescription
        {
            FirstLineHasColumnNames = true,
            IgnoreUnknownColumns = true,
            SeparatorChar = ',',
            UseFieldIndexForReadingData = false,
        };

        var csvContext = new CsvContext();
        //var persons = csvContext.Read<MyObject>("C:/Users/isog1/source/repos/veriyapilariprojec/veriyapilariproje/hash_table.csv", csvFileDescription);
       // foreach (var p in persons)
        {
         //   Add(p);
        }

    }

    private void SaveToCsv()
    {
        var records = new List<MyObject>();
        for (int i = 0; i < TABLE_SIZE; i++)
        {
         //   records.Add(table[i]);
        }
        var csvFileDescription = new CsvFileDescription
        {
            FirstLineHasColumnNames = true,
            SeparatorChar = ',',
        };
        var csvContext = new CsvContext();
        csvContext.Write(records, "C:/Users/isog1/source/repos/veriyapilariprojec/veriyapilariproje/hash_table.csv", csvFileDescription);
        Console.WriteLine("Basarili");

    }


        static void PersonelMain(string[] args)
    {
        HashTable table = new HashTable();

        MyObject obj1 = new MyObject(2, "meral", "coban", 30, "tel1", "muavin");
        MyObject obj2 = new MyObject(5, "songul", "aba", 38, "tel2", "sofor");
        MyObject obj3 = new MyObject(7, "kader", "sal", 37, "tel3", "tur rehberi");
        MyObject obj4 = new MyObject(1, "mehmet", "yilmaz", 59, "tel4", "musteri temsilcisi");
        MyObject obj5 = new MyObject(3, "ayse", "kaya", 25, "tel5", "satis gorevlisi");

        string fileName = "C:/Users/isog1/source/repos/veriyapilariprojec/veriyapilariproje/hash_table.csv";

        table.Add(obj1);
        table.Add(obj2);
        table.Add(obj3);
        table.Add(obj4);
        table.Add(obj5);
        //table.Remove(5);
        //table.SaveToCsv(fileName);
        Console.WriteLine("Hash tablosu CSV dosyasına kaydedildi: " + fileName);
        //Console.WriteLine(table.Search(9));
    }
}

public class MyObject
{
    private int id;
    private string name;
    private string surname;
    private int yas;
    private string tel;
    private string gorev;
        private (int, string, string, int, string, TextBox gorevtxt) p;

        public MyObject(int id, string name, string surname, int yas, string tel, string gorev)
    {
        this.id = id;
        this.name = name;
        this.surname = surname;
        this.yas = yas;
        this.tel = tel;
        this.gorev = gorev;
    }

        public MyObject((int, string, string, int, string, TextBox gorevtxt) p)
        {
            this.p = p;
        }

        public int GetId()
    {
        return id;
    }

    public string GetName()
    {
        return name;
    }

    public string GetSurname()
    {
        return surname;
    }

    public int GetAge()
    {
        return yas;
    }
    public string GetTel()
    {
        return tel;
    }
    public string GetGorev()
    {
        return gorev;
    }
}
}
