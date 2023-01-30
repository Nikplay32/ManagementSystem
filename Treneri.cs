using System;
using System.IO;
using System.Text;
using System.Linq;

public class Treneri {
  public string path;
  public string name;
  public string lastname;
  public string personal_code;
  public string e_pasts;
  public int number;
  public string joma;
  public int answer;
  public int i;
  public int n;
  public string input;
  public string id;
  public string[] lines;
  
  public Treneri(string Name) {
    this.name = Name;
  }

  public void CoachMenu(){
      Console.Clear();
      Console.WriteLine("==============================");
      Console.WriteLine("         WELCOME TO THE       ");
      Console.WriteLine("          COACH DATA          ");
      Console.WriteLine("           APP PART           ");
      Console.WriteLine("==============================");
      Console.WriteLine("==============================");
      Console.WriteLine( "What Would You Like To Do?:" );
      Console.WriteLine( "   1. Add Coach Data" );
      Console.WriteLine( "   2. Show Coach Data" );
      Console.WriteLine( "   3. Search Coach Data" );
      Console.WriteLine( "   4. Delete Coach Data" );
      Console.WriteLine( "   5. Change Coach Data" );
      Console.WriteLine( "   6. Sort Coach Data" );
      Console.WriteLine( "   7. Summary Coach Data" );
      Console.WriteLine( "   8. Back" );
      Console.WriteLine( "   9. Quit" );
      Console.WriteLine("==============================");
      Console.Write("Please Enter Your Option: ");
  }


   public void CoachSummary(){
      if(new FileInfo("CoachInfo.txt").Length != 0){
        string[] coachdata = File.ReadAllLines("CoachInfo.txt");
        for (int i = 0; i < 1; i++) { 
            string[] newArray = coachdata.Where((e, i) => i < 250).ToArray();
            foreach (var item in newArray){
                Console.WriteLine(item);
            }
        }
        Console.Write("Please choose the number of the coach: ");
        string answer_coach = Console.ReadLine();
        Char value = '#';
        Boolean result = answer_coach.Contains(value);
        string[] teamdata = File.ReadAllLines("KomandasInfo.txt");
        string[] array = teamdata.Where((e, i) => i < 128).ToArray();
        if(result == false){
          if(new FileInfo("KomandasInfo.txt").Length != 0){
            foreach (string line in coachdata){
              if(line.Contains(answer_coach)){
                    foreach (var team in array)
                    {
                        Console.WriteLine(team);
                    }
              }
            }
            Console.Write("Please choose the number of the team, to add Coach: ");
            int client_answer = Convert.ToInt32(Console.ReadLine());
            if(client_answer == 1){
              int line_to_edit = 1;
              string sourceFile = "CoachInfo.txt";
              string destinationFile = "KomandasInfo.txt";
      
              
              string lineToWrite = null;
              using (StreamReader reader = new StreamReader(sourceFile))
              {
                  for (int i = 1; i <= line_to_edit; ++i)
                      lineToWrite = reader.ReadLine();
              }
      
              string[] lines = File.ReadAllLines(destinationFile);
      
              // Write the new file over the old file.
              using (StreamWriter writer = new StreamWriter(destinationFile))
              {
                  for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                  {
                      if (currentLine == line_to_edit + 1)
                      {
                          writer.WriteLine($" Coach ID: {answer_coach}");
                      }
                      else
                      {
                          writer.WriteLine(lines[currentLine - 1]);
                      }
                  }
              }
              Console.WriteLine("Coach ID has been added!");
            }
            else if(client_answer == 2){
              int line_to_edit = 8;
              string sourceFile = "CoachInfo.txt";
              string destinationFile = "KomandasInfo.txt";
      
              
              string lineToWrite = null;
              using (StreamReader reader = new StreamReader(sourceFile))
              {
                  for (int i = 1; i <= line_to_edit; ++i)
                      lineToWrite = reader.ReadLine();
              }
      
              string[] lines = File.ReadAllLines(destinationFile);
      
              // Write the new file over the old file.
              using (StreamWriter writer = new StreamWriter(destinationFile))
              {
                  for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                  {
                      if (currentLine == line_to_edit + 1)
                      {
                          writer.WriteLine($" Coach ID: {answer_coach}");
                      }
                      else
                      {
                          writer.WriteLine(lines[currentLine - 1]);
                      }
                  }
              }
            }
            else if(client_answer == 3){
              int line_to_edit = 15;
              string sourceFile = "CoachInfo.txt";
              string destinationFile = "KomandasInfo.txt";
      
              
              string lineToWrite = null;
              using (StreamReader reader = new StreamReader(sourceFile))
              {
                  for (int i = 1; i <= line_to_edit; ++i)
                      lineToWrite = reader.ReadLine();
              }
      
              string[] lines = File.ReadAllLines(destinationFile);
      
              // Write the new file over the old file.
              using (StreamWriter writer = new StreamWriter(destinationFile))
              {
                  for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                  {
                      if (currentLine == line_to_edit + 1)
                      {
                          writer.WriteLine($" Coach ID: {answer_coach}");
                      }
                      else
                      {
                          writer.WriteLine(lines[currentLine - 1]);
                      }
                  }
              }
              Console.WriteLine("Coach ID has been added!");
            }
            else if(client_answer == 4){
              int line_to_edit = 22;
              string sourceFile = "CoachInfo.txt";
              string destinationFile = "KomandasInfo.txt";
      
              
              string lineToWrite = null;
              using (StreamReader reader = new StreamReader(sourceFile))
              {
                  for (int i = 1; i <= line_to_edit; ++i)
                      lineToWrite = reader.ReadLine();
              }

      
              string[] lines = File.ReadAllLines(destinationFile);
      
              // Write the new file over the old file.
              using (StreamWriter writer = new StreamWriter(destinationFile))
              {
                  for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                  {
                      if (currentLine == line_to_edit + 1)
                      {
                          writer.WriteLine($" Coach ID: {answer_coach}");
                      }
                      else
                      {
                          writer.WriteLine(lines[currentLine - 1]);
                      }
                  }
              }
            }
          }
        }
        Console.WriteLine("Coach ID has been added!");
      } else {
        Console.WriteLine("Sorry, the Coach file is empty. Please add there some information, to make actions");
      }
   }

  public void CoachInfoAdd() {
        path = "CoachInfo.txt";
        if (!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path)) {
            }
        }

        using (StreamWriter sw = File.AppendText(path))
        {
            Console.Write("Coach Name: ");
            name = Console.ReadLine();
            Console.Write("Coach Last Name: ");
            lastname = Console.ReadLine();
            Console.Write("Personal_Code: ");
            personal_code = Console.ReadLine();
            Console.Write("Mail: ");
            e_pasts = Console.ReadLine();
            Console.Write("Phone Number: ");
            number = Console.Read();
            Console.Write("Post: ");
            joma = Console.ReadLine();

            for(int i = 0; i < 1; i++){
              lines = new string[7];
              n++;
              id = n.ToString();
              lines[0] = id;
              lines[1] = name;
              lines[2] = lastname;
              lines[3] = personal_code;
              lines[4] = e_pasts;
              lines[5] = e_pasts;
              Console.WriteLine($"{id}");
              string line = $" {lines[0]}\n Coach Name: { lines[1] } \n Coach Lastname: { lines[2] } \n Personal code: { lines[3] } \n E_Pasts: { lines[4] } \n Phone number: { lines[5] }";
              sw.WriteLine(line);
              sw.WriteLine("---------------------------");
            }
        }
    }

  
  public void ShowCoachData(){
    if (File.Exists("CoachInfo.txt")){
      string[] team = File.ReadAllLines("CoachInfo.txt");  
      foreach (string data in team){  
        Console.WriteLine(data); 
      }
    } else {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Sorry the file doesn't exist. You need to add data, to make the actions");
        Console.WriteLine("----------------------------------------------------------------------------");
    }
  }


  public void SearchCoachData(){
    if (File.Exists("CoachInfo.txt")){
      int summary = 0;
      Console.WriteLine("------------------------------");
      Console.Write("Enter the value, to search it: ");
      string toSearch = Console.ReadLine().Trim();
      if (File.Exists("CoachInfo")){
        string []first_file = System.IO.File.ReadAllLines("CoachInfo.txt");
        foreach (string line in first_file){
          if(line.Contains(toSearch)){
            summary++;
            Console.WriteLine(line);
          }
        }
        Console.WriteLine("------------------------------------");
        Console.WriteLine($"Summary of all matches found: {summary}");
        Console.WriteLine("------------------------------------");
      } else {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Sorry, the file doesn't exist.");
        Console.WriteLine("To make actions with data, you need to add new data");
        Console.WriteLine("------------------------------------------");
      }
    } else {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Sorry the file doesn't exist. You need to add data, to make the actions");
        Console.WriteLine("----------------------------------------------------------------------------");
    }
  }

  public void DeleteCoachData(){
    if (File.Exists("CoachInfo.txt")){
      path = "CoachInfo.txt";
      
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
        Console.Write("Choose ID to delete(or write 'nd' not ot delete): ");
        int choiceDelete = Convert.ToInt32(Console.ReadLine());
        string movement = "nd";
        if (Convert.ToString(choiceDelete) == movement)
        {
          Console.Clear();
        }
        if(choiceDelete == 1 || choiceDelete == 7 || choiceDelete == 14 || choiceDelete == 21 || choiceDelete == 28){
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
    } else {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Sorry the file doesn't exist. You need to add data, to make the actions");
        Console.WriteLine("----------------------------------------------------------------------------");
    }
  }

  public void SortCoachData(){
    if (File.Exists("CoachInfo.txt")){
      path = "CoachInfo.txt";
      string[] readText = File.ReadAllLines(path);
      Console.Write("Enter l to sort by lenght/a to ascending: ");
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
    } else {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Sorry the file doesn't exist. You need to add data, to make the actions");
        Console.WriteLine("----------------------------------------------------------------------------");
    }
  }

  public void ChangeCoachData(){
    if (File.Exists("CoachInfo.txt")){
      var lines = System.IO.File.ReadAllLines(@"CoachInfo.txt");
      int counterPrint = 1;
  
      Console.WriteLine("----------------------------------------");
  
      foreach (string s in lines)
      {
          Console.WriteLine($"{ counterPrint }. { s }");
          counterPrint ++;
      }
  
      Console.Write("Enter line number, to change it: ");
      int choiceDelete = Convert.ToInt32(Console.ReadLine());
      if(choiceDelete == 1 || choiceDelete == 7 || choiceDelete == 14 || choiceDelete == 21 || choiceDelete == 28){
         Console.WriteLine("Sorry! You can't change ID line");
      } else {
      Console.Write("Enter the new value: ");
      input = Console.ReadLine();
    
      Console.WriteLine("----------------------------------------");
              lines[choiceDelete - 1] = input;
              System.IO.File.WriteAllLines(@"CoachInfo.txt", lines);
      }
    } else {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("Sorry the file doesn't exist. You need to add data, to make the actions");
        Console.WriteLine("----------------------------------------------------------------------------");
    }
  }
}
