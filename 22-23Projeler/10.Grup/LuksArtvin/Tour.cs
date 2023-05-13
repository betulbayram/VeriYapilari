using System;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

// Tour sınıfı
public class Tour
{
    public int ID;
    public DateTime dt;
    public string placeOfDeparture;
    public string placeOfArrival;
    public double cost;
    //private Personel personel;
    //private Arac arac;


    public Tour(int id, DateTime date, string departure, string arrival, double cost)
    {
        this.ID = id;
        while(date < DateTime.Now)
        {
            Console.WriteLine("Gecmis bir tarih girdiniz. Lutfen yeni tarih giriniz.(yyyy/mm/dd hh:mm): ");
            string date_s = Console.ReadLine();
            date = DateTime.Parse(date_s);

        }
        this.dt = date;
        this.placeOfDeparture = departure;
        this.placeOfArrival = arrival;
        this.cost = cost;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Date: {dt}, From: {placeOfDeparture}, To: {placeOfArrival}, Cost: {cost}";
    }

    public int getID() {return ID;}
    public void setID(int id) {this.ID = id;}

    public DateTime getDt() {return dt;}
    public void setDT(int year, int month, int day, int hour, int minute) {
        DateTime date = new DateTime(year, month, day, hour, minute,0);
        while(date < DateTime.Now){
            Console.WriteLine("Gecmis bir tarih girdiniz. Lutfen yeni tarih giriniz.(yyyy/mm/dd hh:mm): ");  
            string date_s = Console.ReadLine();     
            date = DateTime.Parse(date_s);
        }
        this.dt= date;}

    public string getDeparture() {return placeOfDeparture;}
    public void setDeparture(string departure) {this.placeOfDeparture = departure;}

    public string getArrival() {return placeOfArrival;}
    public void setArrival(string arrival) {this.placeOfArrival = arrival;}

    public double getCost() {return cost;}
    public void setCost(double cost) {this.cost = cost;}



    
}
