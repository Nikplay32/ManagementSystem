using System;

class Program {
  public static void Main (string[] args) {
    Komandas newTeam = new Komandas("PSG");
    Treneri newCoach = new Treneri("Jurgen");
    Tournaments newTOUN = new Tournaments("WorldCup");
    int move;
    int movement;
    StartMenu();

    void StartMenu(){
      Console.WriteLine("==============================");
      Console.WriteLine("        WELCOME TO THE        ");
      Console.WriteLine("           FOOTBALL           ");
      Console.WriteLine("          MANAGER APP         ");
      Console.WriteLine("==============================");
      Console.WriteLine( "What Would You Like To Do?: " );
      Console.WriteLine( "       1. Team Info         " );
      Console.WriteLine( "       2. Coach Info        " );
      Console.WriteLine( "       3. Tournament Info   " );
      Console.WriteLine("==============================");
          Console.Write("Please Enter Your Option: ");

      move = Convert.ToInt32(Console.ReadLine());
      
      switch (move) {
  
      case 1:
          newTeam.TeamMenu();
          movement = Convert.ToInt32(Console.ReadLine());
          switch (movement) {
          case 1:
              newTeam.TeamInfoAdd();
              Console.WriteLine("Anything else?(Y/N)");
              string answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();         
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 2:
              newTeam.ShowTeam();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 3:
              newTeam.SearchTeamData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 4:
              newTeam.DeleteTeamData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 5:
              newTeam.ChangeTeamData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 6:
              newTeam.SortTeamData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 7:
              newTeam.Transfers();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.WriteLine("See you again!");
              }
              break;
          case 8:
              Console.Clear();
              StartMenu();
              Console.WriteLine("See you again!");
              break;
          case 9:
              Console.Clear();
              Console.WriteLine("See you again!");
              break;
          }
          break;
      case 2:
          newCoach.CoachMenu(); 
          movement = Convert.ToInt32(Console.ReadLine());
          switch (movement) {
          case 1:
              newCoach.CoachInfoAdd();
              Console.Write("Anything else?(Y/N): ");
              string answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 2:
              newCoach.ShowCoachData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 3:
              newCoach.SearchCoachData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 4:
              newCoach.DeleteCoachData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 5:
              newCoach.ChangeCoachData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 6:
              newCoach.SortCoachData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 7:
              newCoach.CoachSummary();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 8:
              Console.Clear();
              StartMenu();
              break;
          case 9:
              Console.Clear();
              Console.WriteLine("See you again!");
              break;
          }      
          break;
      case 3:
          newTOUN.TournamentMenu();
          movement = Convert.ToInt32(Console.ReadLine());
          switch (movement) {
          case 1:
              newTOUN.TournamentInfoAdd();
              Console.Write("Anything else?(Y/N): ");
              string answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.WriteLine("See you again!");
                Console.Clear();
                break;
              }
              break;
          case 2:
              newTOUN.ShowTData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 3:
              newTOUN.SearchTData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 4:
              newTOUN.DeleteTData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 5:
              newTOUN.ChangeTournData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 6:
              newTOUN.SortTData();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 7:
              newTOUN.Timetable();
              Console.Write("Anything else?(Y/N): ");
              answer = Console.ReadLine();
              if(answer == "Y" || answer == "y"){
                Console.Clear();
                StartMenu();          
              } else {
                Console.Clear();
                Console.WriteLine("See you again!");
                break;
              }
              break;
          case 8:
              Console.Clear();
              StartMenu();
              Console.WriteLine("See you again!");
              break; 
          case 9:
              Console.Clear();
              Console.WriteLine("See you again!");
              break;
          }      
          break;
    }
  
    }
  }
}

