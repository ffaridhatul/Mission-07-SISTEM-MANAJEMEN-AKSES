using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mission2.Model
{
    public class FileDataSource : IDataSource<AccessRecord>
    {
        private readonly string _filePath = "AccessRecord.txt";

        public List<AccessRecord> Load()
        {
            try
            {
                // Cek apakah file ada, jika tidak, kembalikan list kosong
                if (!File.Exists(_filePath))
                {
                    return new List<AccessRecord>();
                }

                // Buka file AccessRecord.txt dengan FileStream dan StreamReader untuk membaca string sampai akhir
                using (FileStream fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    // Baca seluruh isi file sebagai string
                    string json = sr.ReadToEnd();

                    // Deserialisasi string JSON ke dalam List<AccessRecord>
                    var records = JsonConvert.DeserializeObject<List<AccessRecord>>(json);

                    // Jika deserialisasi berhasil, kembalikan list; jika tidak, kembalikan list kosong
                    return records ?? new List<AccessRecord>();
                }
            }
            catch (Exception ex)
            {
                // Tangani kesalahan jika terjadi
                Console.WriteLine($"An error occurred while loading the records: {ex.Message}");
                return new List<AccessRecord>(); // Kembalikan list kosong jika terjadi kesalahan
            }
        }

        public void Save(List<AccessRecord> list)
        {
            try
            {
                // Serialisasi objek List<AccessRecord> menjadi sebuah string JSON
                string json = JsonConvert.SerializeObject(list, Formatting.Indented);

                // Buka file AccessRecord.txt dengan FileStream dan StreamWriter, dan simpan string JSON ke file
                using (FileStream fs = new FileStream(_filePath, FileMode.Create, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.Write(json);
                }
            }
            catch (Exception ex)
            {
                // Tangani kesalahan jika terjadi
                Console.WriteLine($"An error occurred while saving the records: {ex.Message}");
            }
        }
    }
}
