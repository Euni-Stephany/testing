using System;
using System.Collections.Generic;

// Class Barang
class Barang
{
    public string Nama { get; set; }
    public int Harga { get; set; }
    public int JumlahStok { get; set; }
    public string Kategori { get; set; }
}

// Class Pembelian
class Pembelian
{
    public string NomorInvoice { get; set; }
    public string TanggalPembelian { get; set; }
    public string MetodePembayaran { get; set; }

    public List<DetailPembelian> DaftarDetailPembelian { get; set; }

    public void TampilkanPembayaranCash()
    {
        if (MetodePembayaran.Equals("Cash", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Pembayaran menggunakan metode Cash.");
        }
        else
        {
            Console.WriteLine("Metode pembayaran bukan Cash.");
        }
    }
}

// Class DetailPembelian
class DetailPembelian
{
    public string NamaBarang { get; set; }
    public int Jumlah { get; set; }
    public int TotalHarga { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Inisialisasi beberapa objek Barang
        Barang barang1 = new Barang
        {
            Nama = "Barang 1",
            Harga = 10000,
            JumlahStok = 10,
            Kategori = "Kategori 1"
        };

        Barang barang2 = new Barang
        {
            Nama = "Barang 2",
            Harga = 20000,
            JumlahStok = 5,
            Kategori = "Kategori 2"
        };

        // Inisialisasi objek Pembelian
        Pembelian pembelian = new Pembelian
        {
            NomorInvoice = "INV-001",
            TanggalPembelian = "27 Juni 2023",
            MetodePembayaran = "Cash",
            DaftarDetailPembelian = new List<DetailPembelian>()
        };

        // Inisialisasi beberapa objek DetailPembelian
        DetailPembelian detailPembelian1 = new DetailPembelian
        {
            NamaBarang = barang1.Nama,
            Jumlah = 2,
            TotalHarga = barang1.Harga * 2
        };

        DetailPembelian detailPembelian2 = new DetailPembelian
        {
            NamaBarang = barang2.Nama,
            Jumlah = 3,
            TotalHarga = barang2.Harga * 3
        };

        // Menambahkan objek DetailPembelian ke DaftarDetailPembelian dalam objek Pembelian
        pembelian.DaftarDetailPembelian.Add(detailPembelian1);
        pembelian.DaftarDetailPembelian.Add(detailPembelian2);

        // Menampilkan informasi transaksi penjualan
        Console.WriteLine("Transaksi Penjualan:");
        Console.WriteLine("Nomor Invoice: " + pembelian.NomorInvoice);
        Console.WriteLine("Tanggal Pembelian: " + pembelian.TanggalPembelian);
        Console.WriteLine("Metode Pembayaran: " + pembelian.MetodePembayaran);

        Console.WriteLine("\nDaftar Detail Pembelian:");
        foreach (DetailPembelian detailPembelian in pembelian.DaftarDetailPembelian)
        {
            Console.WriteLine("Nama Barang: " + detailPembelian.NamaBarang);
            Console.WriteLine("Jumlah: " + detailPembelian.Jumlah);
            Console.WriteLine("Total Harga: " + detailPembelian.TotalHarga);
            Console.WriteLine();
        }

        // Menampilkan informasi pembayaran cash
        pembelian.TampilkanPembayaranCash();

        Console.ReadLine();
    }
}