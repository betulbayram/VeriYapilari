using LINQtoCSV;
using System;
using System.Collections.Generic;

public class PersonelBilgi
{
    public int id { get; set; }
    public string name { get; set; }
    public string surname { get; set; }
    public int yas { get; set; }
    public string tel { get; set; }
    public string gorev { get; set; }
}

public class PersonelTablosu
{
    private Dictionary<int, PersonelBilgi> Personeller;

    public PersonelTablosu()
    {
        Personeller = new Dictionary<int, PersonelBilgi>();
    }

    public void PersonelEkle(int id, string name, string surname, int yas, string tel, string gorev)
    {
        PersonelBilgi Personel = new PersonelBilgi
        {
            id = id,
            name = name,
            surname = surname,
            yas = yas,
            tel = tel,
            gorev = gorev,
        };

        Personeller.Add(id, Personel);
    }

    public void PersonelSil(int id)
    {
        Personeller.Remove(id);
    }

    public void PersonelBilgileriniKaydetCSV()
    {
        var records = new List<PersonelBilgi>();

        foreach (var Personel in Personeller.Values)
        {
            records.Add(Personel);
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
        var persons = csvContext.Read<PersonelBilgi>("C:/Users/isog1/source/repos/veriyapilariprojec/veriyapilariproje/hash_table.csv", csvFileDescription);
        foreach (var p in persons)
        {
            Personeller.Add(p.id, p);
        }

    }
}
