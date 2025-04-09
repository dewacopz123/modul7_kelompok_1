using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class GlossaryItem_103022330051
{
    public List<Member> members { get; set; }

    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int gender { get; set; }
        public string age { get; set; }
        public string nim { get; set; }
    }

    public static void ReadJSON()
    {
        string filePath = "jurnal7_2_103022330051.json";
        if (File.Exists(filePath))
        {
            Console.WriteLine("tidak di temukan");
            return;
        }
        string jsonString = File.ReadAllText(filePath);
        TeamMembers_103022330051 team = JsonSerializer.Deserialize<TeamMembers_103022330051>(jsonString);

        Console.WriteLine("Team member list :");
        foreach (var member in team.members)
        {
            Console.WriteLine($"{member.nim}{member.firstName}{member.lastName}({member.age}{member.gender})");
        }
    }
}