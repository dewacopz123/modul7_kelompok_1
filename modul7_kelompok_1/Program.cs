// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System;
using System.IO;
using modul7_kelompok_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Json 1");
        DataMahasiswa_103022330051.ReadJSON();
        Console.WriteLine("Json 2");
        TeamMembers_103022330051.ReadJSON();
    }
}