using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erişim Belirleyiciler

            //1.Public : Her yerden erişilebilir.
            //2.Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.
            //3.Internal : Sadece bulunduğu proje içerisinden erişilebilir
            //4.Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.

            Calisan calisan = new Calisan("songül","ateş",186029045,"Backend");
            calisan.CalisanInfo();
            Console.WriteLine(" --- ");
        }

    }

    class Calisan
    {
        public string Name { get; set; }
        public string Lastname { get; set; }    
        public int No { get; set; }
        public string Departman { get; set; }
        public Calisan(string name, string lastname, int no,string departman)
        {
            this.Name=name;
            this.Lastname=lastname;
            this.No=no;
            this.Departman=departman;

        }
        public Calisan()
        {

        }
        public void CalisanInfo()
        {
            Console.WriteLine("Çalışanın Adı : {0}",Name);
            Console.WriteLine("Çalışanın Soyadı : {0}",Lastname);
            Console.WriteLine("Çalışanın No : {0}",No);
            Console.WriteLine("Çalışanın Departmanı : {0}",Departman);

        }

    }

}