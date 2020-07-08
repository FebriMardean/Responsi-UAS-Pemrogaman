using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine(" ");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Hapus Mahasiswa");
            Console.WriteLine("3. Tampilkan Mahasiswa");
            Console.WriteLine("4. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Mahasiswa mahasiswa = new Mahasiswa();
            Console.Write("NIM           : ");
            mahasiswa.NIM = Console.ReadLine();
            Console.Write("Nama          : ");
            mahasiswa.Nama = Console.ReadLine();
            Console.Write("Jenis [L/P]   : ");
            string JenisKelamin = Console.ReadLine();
            mahasiswa.JenisKelamin = (JenisKelamin == "L" || JenisKelamin == "P") ? "Laki-Laki" : "Perempuan";
            Console.Write("IPK           : ");
            mahasiswa.IPK = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection

            Console.WriteLine("Hapus Data Mahasiswa");
            Console.Write("NIM   : ");
            string nim = Console.ReadLine();
            Mahasiswa delete = daftarMahasiswa.SingleOrDefault(x => x.NIM == nim);
            if (daftarMahasiswa.Contains(delete) == true)
            {
                daftarMahasiswa.Remove(delete);
                Console.WriteLine("Data Mahasiswa berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nNIM tidak ditemukan");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Console.WriteLine("Data Mahasiswa");
            int no = 0;

            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", no, mahasiswa.NIM, mahasiswa.Nama, mahasiswa.JenisKelamin, mahasiswa.IPK);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
