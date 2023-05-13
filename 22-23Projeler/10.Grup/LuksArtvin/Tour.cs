using System;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

// Servis sınıfı
public class Tour
{
    public int ID { get; set; } = default!;
    public DateTime dt { get; set; } = default!;
    public string placeOfDeparture { get; set; } = default!;
    public string placeOfArrival { get; set; } = default!;
    public double cost { get; set; } = default!;
    //public Personel personel;
    //public Arac arac;



    public override string ToString()
    {
        return $"Date: {dt}, From: {placeOfDeparture}, To: {placeOfArrival}, Cost: {cost}";
    }


    
}