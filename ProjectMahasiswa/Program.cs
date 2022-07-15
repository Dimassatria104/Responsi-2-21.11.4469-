using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        Mahasiswa mhs = new Mahasiswa();
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3:
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Alpikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampil Mahasiswa");
            Console.WriteLine("3. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            Console.WriteLine("Tambah Data Mahasiswa");
            Console.WriteLine();

            Mahasiswa mhs = new Mahasiswa();
            Console.WriteLine("NIM :");
            mhs.nim = int.Parse(Console.ReadLine());

            Console.WriteLine("Nama :");
            mhs.nama = Console.ReadLine();

            Console.WriteLine("Jenis Kelamin :");
            mhs.kelamin = Console.ReadLine();
            if (mhs.kelamin == "L")
            {
                mhs.kelamin = "Laki-Laki";
            }
            else if (mhs.kelamin == "P")
            {
                mhs.kelamin = "Perempuan";
            }

            Console.WriteLine("IPK :");
            mhs.ipk = int.Parse(Console.ReadLine());

            daftarMahasiswa.Add(mhs);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();

            
        }

        static void TampilMahasiswa()
        {Console.WriteLine("Data Mahasiswa\n");
            int i = 1;

            foreach (Mahasiswa mhs in daftarMahasiswa)
            {

                Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}", i, mhs.nim, mhs.nama, mhs.kelamin, mhs.ipk);
                i++;
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
