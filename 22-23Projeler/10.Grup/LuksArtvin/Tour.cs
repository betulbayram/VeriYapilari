using System;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using MyObject
using Vehicle

// Tour sınıfı
public class Tour
{
    public int ID;
    public DateTime dt;
    public string placeOfDeparture;
    public string placeOfArrival;
    public double cost;
    public MyObject personel;
    public Vehicle vehicle;


    public Tour(int id, DateTime date, string departure, string arrival, double cost, MyObject personel, Vehicle vehicle)
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
        this.personel = personel;
        this.vehicle = vehicle;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Date: {dt}, From: {placeOfDeparture}, To: {placeOfArrival}, Cost: {cost}, Sofor: {personel.name}, Arac: {vehicle.aracPlakasi}";
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

    public MyObject getPersonel() {return personel;}
    public void setPersonel(MyObject personel) {this.personel = personel;}

    public Vehicle getVehicle() {return vehicle;}
    public void setVehicle(Vehicle vehicle) {this.vehicle = vehicle;}

    
}
