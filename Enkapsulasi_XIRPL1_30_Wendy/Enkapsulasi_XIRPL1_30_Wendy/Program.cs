using System;

namespace Enkapsulasi_XIRPL1_30_Wendy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biodata Dokter:");
            Dokter dokter1 = new Dokter();
            dokter1.nama = "Joko";
            Console.WriteLine("Nama Dokter: " + dokter1.nama);
            dokter1.NomorID = 012;
            Console.WriteLine("No ID: " + dokter1.NomorID);
            Console.WriteLine("Riwayat Penyakit: " + dokter1.BiodataDokter());
            dokter1.Bangsal = "kelas Melati";
            Console.WriteLine("Dokter berada di Bangsal: " + dokter1.Bangsal);
            dokter1.NoHP = 082228491979;
            Console.WriteLine("Nomor Hp: " + dokter1.NoHP);
            Console.WriteLine();




            Console.WriteLine("Biodata Pasien: ");
            Pasien pasien1 = new Pasien();
            pasien1.nama = "Dini";
            Console.WriteLine("Nama Pasien: " + pasien1.nama);
            pasien1.NomorID = 445;
            Console.WriteLine("No ID: " + pasien1.NomorID);
            Console.WriteLine("Riwayat Penyakit: " + pasien1.BiodataPasien());
            pasien1.Bangsal = "Kelas Mawar";
            Console.WriteLine("Pasien berada di Bangsal :" + pasien1.Bangsal);
            pasien1.NoHP = 085726336632;
            Console.WriteLine("Nomor Hp: " + pasien1.NoHP);
            


           
        }
    }
}
