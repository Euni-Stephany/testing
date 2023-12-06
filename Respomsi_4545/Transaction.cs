using System;

namespace ConsoleApp1.Models
{
    public class Transactions
    {
        public string Nota { get; set; }
        public DateTime Tanggal { get; set; }
        public double Total { get; set; }

        public void Pembayaran(double bayar)
        {
            Console.WriteLine("Pembayaran    : Metode Cash");
            Console.WriteLine("Total Belanja : " + Total);
            Console.WriteLine("Pembayaran    : " + bayar);
            Console.WriteLine("Kembalian     : " + (bayar - Total));
        }
    }
}
