// Nama     : Ziel Alfino Akbar
// NIM      : 220101010154
// Kelas    : SI301
// Matkul   : Pemograman Lanjutan
// Dosen    : Ir. Ahmad Chusyairi, S.Kom., M.Kom

using System;

    class GameTebakAngka
{
    static void Main(string[] args)
    {
        // Judul game
        Console.WriteLine("===== Game Tebak Angka =====");
        Console.WriteLine("Komputer akan memilih angka antara 1 hingga 100. Coba tebak!");

        // Deklarasi tipe data dan variabel
        Random random = new Random();
        int angkaTebakan = random.Next(1, 101); // Angka acak antara 1-100
        int tebakanPengguna = 0; // Variabel untuk input pengguna
        int kesempatan = 7; // Jumlah kesempatan menebak

        // Perulangan untuk game
        while (kesempatan > 0)
        {
            // Banyak tebakan yang anda lakukan hinga berhasil
            int tebakanBerhasil = 8 - kesempatan; 

            // Perintah input
            Console.Write($"Masukkan tebakan Anda (kesempatan {kesempatan}): ");
            // menambahkan '?? "0"' agar tidak terjadi null jika tidak tambahkan maka akan ada warning null
            string input = Console.ReadLine() ?? "0"; 

            // Percabangan untuk validasi input
            if (!int.TryParse(input, out tebakanPengguna))
            {
                Console.WriteLine("Masukkan angka yang valid!");
                continue;
            }

            // Operator untuk membandingkan tebakan
            if (tebakanPengguna == angkaTebakan)
            {
                Console.WriteLine($"Selamat! Anda berhasil menebak angkanya dalam {tebakanBerhasil} tebakan.");
                break; // Keluar dari perulangan
            }
            else if (tebakanPengguna < angkaTebakan)
            {
                Console.WriteLine("Tebakan Anda terlalu kecil!");
            }
            else
            {
                Console.WriteLine("Tebakan Anda terlalu besar!");
            }

            // Kurangi kesempatan
            kesempatan--;

            // Output jika kesempatan habis
            if (kesempatan == 0)
            {
                Console.WriteLine($"Kesempatan habis! Angka yang benar adalah {angkaTebakan}.");
            }
        }

        Console.WriteLine("Terima kasih sudah bermain!");
    }
}