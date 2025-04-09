using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DataMahasiswa_103022300136
{
    public class mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }

        [JsonPropertyName("address")]
        public address Address { get; set; }
        [JsonPropertyName("courses")]
        public List<courses> Course { get; set; }
    }

    public class address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public static void ReadJSON()
    {
        try
        {
            string jsonText = File.ReadAllText("jurnal7_1_103022300136.json");
            mahasiswa data = JsonSerializer.Deserialize<mahasiswa>(jsonText);
            Console.WriteLine($"Nama {data.firstName} {data.lastName} dengan Kelamin {data.gender} dan umurnya {data.age}");
            Console.WriteLine($"tinggal di {data.Address.streetAddress}, {data.Address.city}, {data.Address.state}");
            Console.WriteLine($"Mata Kuliah yang di ambil");
            int i = 1;
            foreach (var mk in data.Course)
            {
                Console.WriteLine($"Mengambil Mata Kuliah {mk.code} = {mk.name}");
                i++;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Gagal membaca file JSON: " + ex.Message);
        }
    }

    public static void Main(string[] args)
    {
        ReadJSON();
        Console.ReadLine();
    }
}
