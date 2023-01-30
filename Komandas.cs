using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;
using System.Text.RegularExpressions;

public class Komandas {
    public string path;
    public string nosaukums;
    public string titulu_skaits;
    public string saturs;
    public int newTitles;
    public string scheme;
    public string transfer;
    public string number;
    public string input;
    public int choose1;
    public string id; 
    string answer;
    public int p = 1;
    public string[] lines;

    public Komandas(string Nosaukums) {
        this.nosaukums = Nosaukums;
    }

    public void TeamMenu() {
        Console.Clear();
        Console.WriteLine("==============================");
        Console.WriteLine("        WELCOME TO THE        ");
        Console.WriteLine("          TEAM DATA           ");
        Console.WriteLine("           APP PART           ");
        Console.WriteLine("==============================");
        Console.WriteLine("What Would You Like To Do?:");
        Console.WriteLine("   1. Add Team Info");
        Console.WriteLine("   2. Show Team Data");
        Console.WriteLine("   3. Search Team Data");
        Console.WriteLine("   4. Delete Team Data");
        Console.WriteLine("   5. Change Team Data");
        Console.WriteLine("   6. Sort Team Data");
        Console.WriteLine("   7. Transfers");
        Console.WriteLine("   8. Back");
        Console.WriteLine("   9. Quit");
        Console.WriteLine("==============================");
        Console.Write("Please Enter Your Option: ");
    }

    public void TeamInfoAdd() {
        path = "KomandasInfo.txt";
        if (!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path)) {
            }
        }

        using (StreamWriter sw = File.AppendText(path))
        {
            Console.Write("Team Name: ");
            nosaukums = Console.ReadLine();
            Console.Write("Titles: ");
            titulu_skaits = Console.ReadLine();
            Console.Write("Scheme: ");
            scheme = Console.ReadLine();
            Console.Write("Employee count: ");
            saturs = Console.ReadLine();
          
            for(int i = 0; i < 1; i++){
              lines = new string[7];
              id = p.ToString();
              lines[0] = id;
              lines[1] = nosaukums;
              lines[2] = titulu_skaits;
              lines[3] = scheme;
              lines[4] = saturs;
              p++;
              string line = $" {lines[0]}\n Coach ID: {lines[5]}\n Team Name: { lines[1] } \n Titles: { lines[2] } \n Scheme: { lines[3] } \n Saturs: { lines[4] }";
              sw.WriteLine(line);
              sw.WriteLine("---------------------------");
            }
        }
    }

    public void ShowTeam() {
      if (File.Exists("KomandasInfo.txt")){
        string[] team = File.ReadAllLines("KomandasInfo.txt");
        foreach (string data in team) {
            Console.WriteLine(data);
        }
      } else {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Sorry the file doesn't exist. You need to add data, to make the actions");
        Console.WriteLine("----------------------------------------------------------------------------");
      }
    }

    public void SearchTeamData() {
      if (File.Exists("KomandasInfo.txt")){
        int summary = 0;
        Console.WriteLine("------------------------------");
        Console.Write("Enter the value, to search it: ");
        string toSearch = Console.ReadLine().Trim();
        string[] first_file = System.IO.File.ReadAllLines("KomandasInfo.txt");
        foreach (string line in first_file) {
            if (line.Contains(toSearch)) {
                summary++;
                Console.WriteLine(line);
            }
        }
        Console.WriteLine("------------------------------------");
        Console.WriteLine($"Summary of all matches found: {summary}");
        Console.WriteLine("------------------------------------");
      } else {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Sorry the file doesn't exist. You need to add data, to make the actions");
        Console.WriteLine("----------------------------------------------------------------------------");
      }
    }


    public void DeleteTeamData(){
      if (File.Exists("KomandasInfo.txt")){
        path = "KomandasInfo.txt";

        string[] readText = File.ReadAllLines(path);
        int counterPrint = 1;

        Console.WriteLine("----------------------------------------");

        foreach (string s in readText)
        {
            Console.WriteLine($"{ counterPrint }. { s }");
            counterPrint++;
        }

        Console.WriteLine("----------------------------------------");
        try {
            Console.Write("Choose line to delete(or write 'nd' not ot delete): ");
            int choiceDelete = Convert.ToInt32(Console.ReadLine());
            string movement = "nd";
            if (Convert.ToString(choiceDelete) == movement)
            {
            }
            if(choiceDelete == 1 || choiceDelete == 8 || choiceDelete == 15 || choiceDelete == 22 || choiceDelete == 29){
          Console.WriteLine("Sorry! You can't delete ID line");
            } else {
              readText = readText.Where((source, index) => index != choiceDelete-1).ToArray();
              File.WriteAllLines(path, readText);
              Console.WriteLine("Selected line was deleted");
            }
        }
        catch (Exception) {
        }
      } else {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Sorry the file doesn't exist. You need to add data, to make the actions");
        Console.WriteLine("----------------------------------------------------------------------------");
      }
    }

    public void ChangeTeamData() {
      if (File.Exists("KomandasInfo.txt")){
        var lines = System.IO.File.ReadAllLines(@"KomandasInfo.txt");
        int counterPrint = 1;

        Console.WriteLine("----------------------------------------");

        foreach (string s in lines)
        {
            Console.WriteLine($"{ counterPrint }. { s }");
            counterPrint++;
        }

        Console.Write("Enter line number, to change it: ");
        int choiceDelete = Convert.ToInt32(Console.ReadLine());
        if(choiceDelete == 1 || choiceDelete == 8 || choiceDelete == 15 || choiceDelete == 22 || choiceDelete == 29){
          Console.WriteLine("Sorry! You can't change ID line");
        } else {
          Console.Write("Enter the new value: ");
          input = Console.ReadLine();
  
          Console.WriteLine("----------------------------------------");
          Console.WriteLine("Line was changed");
          Console.WriteLine("----------------------------------------");
          lines[choiceDelete-1] = input;
          System.IO.File.WriteAllLines(@"KomandasInfo.txt", lines);
        }
      } else {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Sorry the file doesn't exist. You need to add data, to make the actions");
        Console.WriteLine("----------------------------------------------------------------------------");
      }
    }

    public void SortTeamData() {
      if (File.Exists("KomandasInfo.txt")){
        path = "KomandasInfo.txt";
        string[] readText = File.ReadAllLines(path);
        Console.Write("Enter l to sort by lenght/ a to sort ascending: ");
        string move = Console.ReadLine();
        if (move == "a") {
            string temp = string.Empty;
            try {
                for (int i = 1; i < readText.Length; i++) {
                    for (int j = 0; j < readText.Length - i; j++) {
                        if (readText[j].CompareTo(readText[j + 1]) > 0) {
                            temp = readText[j];
                            readText[j] = readText[j + 1];
                            readText[j + 1] = temp;
                        }
                    }
                }
                for (int i = 0; i < readText.Length; i++) {
                    Console.WriteLine(readText[i] + " ");
                }
            }

            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        } else if (move == "l") {
            Array.Sort(readText, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string s in readText)
            {
                Console.WriteLine($"{s}");
            }
        }
      } else {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Sorry the file doesn't exist. You need to add data, to make the actions");
        Console.WriteLine("----------------------------------------------------------------------------");
      }
    }

   public void Transfers() {
        bool c = false;
        Random rand = new Random();
        int goals = rand.Next(0,30);
        int assists = rand.Next(0,30);
        int counterPrint = 1;
         string[] transfer = File.ReadAllLines(@"Transfers.txt");
         Console.Clear();
         Console.WriteLine("==============================");
         Console.WriteLine("=        TRANSFER LIST       =");
         Console.WriteLine("==============================");
         foreach (string players in transfer) {
             Console.WriteLine($"{ counterPrint }. { players }");
             counterPrint++;
         }
         Console.WriteLine("===========================================");
         Console.Write("Please choose one player, to start negotiations with him: ");
         int chooseee = Console.Read();
         Console.WriteLine("-------------------------------------------------------");
         choose1 = Convert.ToInt32(chooseee) - 49;
         if (c == choose1.Equals(transfer))
         {   
             Console.Clear();
             Console.WriteLine("==============================");
             Console.WriteLine("=      PLAYER STATISTICS     =");
             Console.WriteLine("=       FOR THIS SEASON      =");
             Console.WriteLine("==============================");
             Console.WriteLine($"  Goals: {goals}    Assists: {assists}   ");
             Console.WriteLine("==============================");
             Console.WriteLine("Player Agent received your offer. He will contact with you: ");
             Console.WriteLine("......");
             Thread.Sleep(5000);
             bool player_choose = rand.Next(2) == 1;
             if (player_choose == true)
             {
                 Console.WriteLine("-------------------------------------------------------");
                 Console.WriteLine("Player applied your contract");
                 Random random = new Random();
                 int years = random.Next(1,5);
                 int signed_bonuss = random.Next(1000000/500, 5000000/500)*500;
            	   int salary = random.Next(250000/500, 750000/500)* 500;
            	   Console.WriteLine("The club let player sign contract. Negotiate contract terms with him");
                 Console.WriteLine($"{transfer[choose1]}: I want a contract for {years} years");
                 Console.WriteLine($"{transfer[choose1]}: Also I want {salary} salary per week");
                 Console.WriteLine($"{transfer[choose1]}: And signed bonuss {signed_bonuss} $");
                 Console.WriteLine("-------------------------------------------------------");
                 Console.Write("Please enter yes if you like the terms of contract or no: ");
                 answer = Console.ReadLine();
                 answer = Console.ReadLine();
                 Console.WriteLine("-------------------------------------------------------");
                 if(answer == "yes" || answer == "Yes"){
                   Console.WriteLine("Contract was succesfully signed by both lines!");
                   Console.WriteLine("-------------------------------------------------------");
                   FileStream ostrm;
                   StreamWriter writer;
                   TextWriter oldOut = Console.Out;
                   try{
                      ostrm = new FileStream ("TransferToClub.txt", FileMode.OpenOrCreate, FileAccess.Write);
                      writer = new StreamWriter (ostrm);
                   }
                   catch (Exception e){
                      Console.WriteLine ("Cannot open Redirect.txt for writing");
                      Console.WriteLine (e.Message);
                      return;
                   }
                   Console.SetOut (writer);
                   Console.WriteLine("----------------------------------------");
                   Console.WriteLine("CONTRACT: ");
                   Console.WriteLine("----------------------------------------");
                   Console.WriteLine($"Player: {transfer[choose1]}");
                   Console.WriteLine($"Player salary: {salary} $");
                   Console.WriteLine($"Player signed bonuss: {signed_bonuss} $");
                   Console.WriteLine($"Contract term agreement: {years} years");
                   Console.WriteLine("----------------------------------------");
                   Console.SetOut (oldOut);
                   writer.Close();
                   ostrm.Close();
                  } else {
                   Console.WriteLine("-------------------------------------------------------");
                   Console.WriteLine("The parties did not reach an agreement");
                   Console.WriteLine("-------------------------------------------------------");
                  }
             }
             else
             {
                 Console.WriteLine("Player canceled your offer");
             }
         }
     }
}