using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_1
{
    public class DataMahasiswa_103022330051
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_1_103022330051.json";
            if (File.Exists(filePath))
            {
                Console.WriteLine("tidak di temukan");
                return;
            }
            string jsonString = File.ReadAllText(filePath);
            DataMahasiswa_103022330051 data = JsonSerializer.Deserialize<DataMahasiswa_103022330051>(jsonString);

            Console.WriteLine("Data Mahasiswa:");
            Console.WriteLine($"First Name : {data.firstName}");
            Console.WriteLine($"Last Name : {data.lastName}");
            Console.WriteLine($"Age : {data.age}");
            Console.WriteLine($"Gender : {data.gender}");
        }
    }
}
