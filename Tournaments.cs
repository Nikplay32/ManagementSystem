using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class Tournaments {
  public string name;
  public int participants;
  public string prize;
  public string time;
  public string path;
  public string number;
  public string number2;
  public string location;
  public string stadiums;
  public string input;
  public int n = 0;
  public string id;
  public DateTime inputtedDate;
  
  
  public Tournaments(string Name) {
    this.name = Name;
  }

  public void TournamentMenu(){
      Console.Clear();
      Console.WriteLine("==============================");
      Console.WriteLine("         WELCOME TO THE       ");
      Console.WriteLine("        TOURNAMENTS DATA      ");
      Console.WriteLine("            APP PART          ");
      Console.WriteLine("==============================");
      Console.WriteLine("==============================");
      Console.WriteLine( "What Would You Like To Do?:" );
      Console.WriteLine( "   1. Add Tournament" );
      Console.WriteLine( "   2. Show Tournament Data" );
      Console.WriteLine( "   3. Search Tournament Data" );
      Console.WriteLine( "   4. Delete Tournament Data" );
      Console.WriteLine( "   5. Change Tournament Data" );
      Console.WriteLine( "   6. Sort Tournament Data" );
      Console.WriteLine( "   7. Timetable" );
      Console.WriteLine( "   8. Back" );
      Console.WriteLine( "   9. Quit" );
      Console.WriteLine("==============================");
          Console.Write("Please Enter Your Option: ");
  }

  public void TournamentInfoAdd(){
   path = "TournamentInfo.txt";
    if (!File.Exists(path))
    {
      using (StreamWriter sw = File.CreateText(path)){       
      }
    }
    
    using (StreamWriter sw = File.AppendText(path))
    {
      Console.Write("Tournament Name: ");
      name = Console.ReadLine();
      Console.Write("Number of participants: ");
      string participants = Convert.ToString(number);
      stadiums = Convert.ToString(number2);
      participants = Console.ReadLine();
      Console.Write("Enter a date (e.g. 10/22/1987): ");
      inputtedDate = DateTime.Parse(Console.ReadLine());
      string date = inputtedDate.ToString();
      Console.Write("Enter time: ");
      time = Console.ReadLine();
      Console.Write("Stadiums: ");
      stadiums = Console.ReadLine();
      Console.Write("Tournament Final Match Location: ");
      location = Console.ReadLine();
      Console.Write("Prize: ");
      prize = Console.ReadLine();
      
      string[] lines = new string[8];
      for(int i = 0; i < 1; i++){
        n++;
        id = n.ToString();
        lines[0] = name;
        lines[1] = participants;
        lines[2] = date;
        lines[3] = time;
        lines[4] = stadiums;
        lines[5] = location;
        lines[6] = prize;
        lines[7] = id;
        
        string line = $" {lines[7]}\n Tournament Name: {lines[0]}\n Participant count: { lines[1]}\n Date: {lines[2]}\n Time: {lines[3]}\n Stadiums: {lines[4]}\n Location: {lines[5]}\n Prize: {lines[6]}";
        sw.WriteLine(line);
        sw.WriteLine("---------------------------");
      }
    }
  }

  public void ShowTData(){
    string[] team = File.ReadAllLines("TournamentInfo.txt");  
    foreach (string data in team){  
      Console.WriteLine(data); 
    }
  }

  public void SearchTData(){
    int summary = 0;
    Console.WriteLine("------------------------------");
    Console.Write("Enter the value, to search it: ");
    string toSearch = Console.ReadLine().Trim();
    string []first_file = System.IO.File.ReadAllLines("TournamentInfo.txt");
    foreach (string line in first_file){
        if(line.Contains(toSearch)){
          summary++;
          Console.WriteLine(line);
        }
    }
    Console.WriteLine("------------------------------------");
    Console.WriteLine($"Summary of all matches found: {summary}");
    Console.WriteLine("------------------------------------");
  }

  public void DeleteTData()
  {
    path = "TournamentInfo.txt";
    
    string[] readText = File.ReadAllLines(path);
    int counterPrint = 1;

    Console.WriteLine("----------------------------------------");

    foreach (string s in readText)
    {
        Console.WriteLine($"{ counterPrint }. { s }");
        counterPrint ++;
    }
  
    Console.WriteLine("----------------------------------------");
    try{
      Console.Write("Choose line to delete(or write 'nd' not ot delete): ");
      int choiceDelete = Convert.ToInt32(Console.ReadLine());
      string movement = "nd";
      if (Convert.ToString(choiceDelete) == movement)
      {
        Console.Clear();
      }
      if(choiceDelete == 1 || choiceDelete == 10 || choiceDelete == 19 || choiceDelete == 29 || choiceDelete == 39){
          Console.WriteLine("Sorry! You can't delete ID line");
        } else {
          readText = readText.Where((source, index) => index != choiceDelete-1).ToArray();
          File.WriteAllLines(path, readText);
          Console.WriteLine("Selected line was deleted");
      }
    }
    catch (Exception){
      Console.Clear();
    }
  }

  public void ChangeTData(){
    var lines = System.IO.File.ReadAllLines(@"TournamentInfo.txt");
    int counterPrint = 1;

    Console.WriteLine("----------------------------------------");

    foreach (string s in lines)
    {
        Console.WriteLine($"{ counterPrint }. { s }");
        counterPrint ++;
    }

    Console.Write("Enter line number, to change it: ");
    int choiceDelete = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Enter the new value: ");
    input = Console.ReadLine();
  
    Console.WriteLine("----------------------------------------");
            lines[choiceDelete] = input;
            System.IO.File.WriteAllLines(@"TournamentInfo.txt", lines);
  }

  public void SortTData(){
    path = "TournamentInfo.txt";
    string[] readText = File.ReadAllLines(path);
    Console.Write("Enter l to sort by lenght/ a to sort by ascending: ");
    string move = Console.ReadLine(); 
    if(move == "a"){ 
      string temp = string.Empty;
      try {
        for (int i = 1; i < readText.Length; i++){
          for (int j = 0; j < readText.Length-i; j++){
            if (readText[j].CompareTo(readText[j + 1]) > 0){
              temp = readText[j];
              readText[j] = readText[j + 1];
              readText[j + 1] = temp;
            }
          }
        }
        for (int i = 0; i < readText.Length; i++){
          Console.WriteLine(readText[i] + " ");
        }
        }
        
        catch (Exception ex){
          Console.WriteLine(ex.Message);
        }   
    } else {
      Array.Sort(readText, (x, y) => x.Length.CompareTo(y.Length));
            foreach (string s in readText)
            {
                Console.WriteLine($"{s}");
            }
    }
  }


  public void Timetable(){
    string[] cities = File.ReadAllLines("cities.txt");
    int counterPrint = 1;
    Random random = new Random();
    TimeSpan start = TimeSpan.FromHours(1);
    TimeSpan end = TimeSpan.FromHours(24);
    int maxMinutes = (int)((end - start).TotalMinutes);
    
      FileStream ostrm;
      StreamWriter writer;
      TextWriter oldOut = Console.Out;
      try
      {
          ostrm = new FileStream ("Timetable.txt", FileMode.OpenOrCreate, FileAccess.Write);
          writer = new StreamWriter (ostrm);
      }
      catch (Exception e)
      {
          Console.WriteLine ("Cannot open Redirect.txt for writing");
          Console.WriteLine (e.Message);
          return;
      }
      Console.SetOut (writer);
      Console.WriteLine("TABLE: FIRST LOOP OF TODAYS QUALIFICATION MATCHES: ");
      Console.WriteLine("---------------------------------------------------------------");
      foreach (string city in cities){
        int n = random.Next(24*6);
        TimeSpan ts = TimeSpan.FromMinutes(n * 5);
        Console.WriteLine($"| Match location and starting time: { counterPrint }. { city } - { ts } |");
        counterPrint++;
      }
      Console.SetOut (oldOut);
      writer.Close();
      ostrm.Close();
      Console.WriteLine("---------------------------------------------------------------");
      Console.Write("The timetable was created. To check it, enter ch: ");
      string table = Console.ReadLine();
      Console.WriteLine("---------------------------------------------------------------");
      Console.Clear();
      if(table == "ch"){
        string[] timetable = File.ReadAllLines("Timetable.txt");
        foreach (string time in timetable){
          Console.WriteLine($"{time}");
        }
      Console.WriteLine("---------------------------------------------------------------");
      }
  }

  public void ChangeTournData(){
    if (File.Exists("TournamentInfo.txt")){
      var lines = System.IO.File.ReadAllLines(@"TournamentInfo.txt");
      int counterPrint = 1;
  
      Console.WriteLine("----------------------------------------");
  
      foreach (string s in lines)
      {
          Console.WriteLine($"{ counterPrint }. { s }");
          counterPrint ++;
      }
  
        Console.Write("Enter line number, to change it: ");
        int choiceDelete = Convert.ToInt32(Console.ReadLine());
        if(choiceDelete == 1 || choiceDelete == 10 || choiceDelete == 19 || choiceDelete == 29 || choiceDelete == 39){
          Console.WriteLine("Sorry! You can't change ID line");
        } else {
          Console.Write("Enter the new value: ");
          input = Console.ReadLine();
  
          Console.WriteLine("----------------------------------------");
          lines[choiceDelete-1] = input;
          System.IO.File.WriteAllLines(@"TournamentInfo.txt", lines);
        }
    } else {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Sorry the file doesn't exist. You need to add data, to make the actions");
        Console.WriteLine("----------------------------------------------------------------------------");
    }
  }
  
}
