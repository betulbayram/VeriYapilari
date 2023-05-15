public class HashTableBase
{


    public static void PersonelMain(string[] args)
    {
        personeller.HashTable table = new personeller.HashTable();

        Personeller.MyObject obj1 = new Personeller.MyObject(2, "meral", "coban", 30, "tel1", "muavin");
        Personeller.MyObject obj2 = new Personeller.MyObject(5, "songul", "aba", 38, "tel2", "sofor");
        Personeller.MyObject obj3 = new Personeller.MyObject(7, "kader", "sal", 37, "tel3", "tur rehberi");
        Personeller.MyObject obj4 = new Personeller.MyObject(1, "mehmet", "yilmaz", 59, "tel4", "musteri temsilcisi");
        Personeller.MyObject obj5 = new Personeller.MyObject(3, "ayse", "kaya", 25, "tel5", "satis gorevlisi");

        string fileName = "hash_table.csv";

        table.Add(obj1);
        table.Add(obj2);
        table.Add(obj3);
        table.Add(obj4);
        table.Add(obj5);
        //table.Remove(5);
        table.SaveToCsv(fileName);
        System.Console.WriteLine("Hash tablosu CSV dosyasına kaydedildi: " + fileName);
        //Console.WriteLine(table.Search(9));
    }
}