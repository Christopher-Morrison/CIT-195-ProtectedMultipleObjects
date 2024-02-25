using System;
using System.Net.Sockets;

namespace protectedMultipleObjects
{
    class Sport
    {
        protected int _playerCount;
        protected string _headCoach;
        protected int _playerSalary;
        protected int _coachSalary;
        public Sport()
        {
            _playerCount = 0;
            _headCoach = "";
            _playerSalary = 0;
            _coachSalary = 0;
        }
        public Sport(int playerCount, string headCoach, int playerSalary, int coachSalary)
        {
            _playerCount = playerCount;
            _headCoach = headCoach;
            _playerSalary = playerSalary;
            _coachSalary = coachSalary;
        }
        // set and get methods
        // public int getPlayerCount()
        // {
        //     return _playerCount;
        // }
        // public void setPlayerCount(int playerCount)
        // {
        //     _playerCount = playerCount;
        // }
        // public string getHeadCoach()
        // {
        //     return _headCoach;
        // }
        // public void setHeadCoach(string headCoach)
        // {
        //     _headCoach = headCoach;
        // }
        // public int getPlayerSalary()
        // {
        //     return _playerSalary;
        // }
        // public void setplayerSalary(int playerSalary)
        // {
        //     _playerSalary = playerSalary;
        // }
        // public int getCoachSalary()
        // {
        //     return _coachSalary;
        // }
        // public void setCoachSalary(int coachSalary)
        // {
        //     _coachSalary = coachSalary;
        // }
        // //update methods
        // public virtual void updatePlayerCount(int totalPlayers)
        // {
        //     _playerCount = totalPlayers;
        // }
        // public virtual void updatePlayerSalary(int newSalary)
        // {
        //     _playerSalary = newSalary;
        // }
        // public virtual void updateCoachSalary(int newSalary)
        // {
        //     _coachSalary = newSalary;
        // }
        // public virtual void changeCoach(string newCoach)
        // {
        //     _headCoach = newCoach;
        // }
        public virtual void updateSport()
        {
            Console.Write("Player Count: ");
            _playerCount = int.Parse(Console.ReadLine());
            Console.Write("Player Salary: ");
            _playerSalary = int.Parse(Console.ReadLine());
            Console.Write("Head Coach: ");
            _headCoach = Console.ReadLine();
            Console.Write("Coach salary: ");
            _coachSalary = int.Parse(Console.ReadLine());
        }
        public virtual void displayTeam()
        {
            Console.WriteLine("\nYour team data:");
            Console.WriteLine($"Total Player Count: {_playerCount}");
            Console.WriteLine($"Player Salary: {_playerSalary}");
            Console.WriteLine($"Head Coach: {_headCoach}");
            Console.WriteLine($"Coach Salary: {_coachSalary}");
        }
    }
        // derived class
    class Baseball : Sport
    {
        protected string _pitcher;

        protected string _mascot;
        public Baseball()
            :base()
        {
            _pitcher = "";
            _mascot ="";
        }
        public Baseball(int playerCount, string headCoach, int playerSalary, int coachSalary, string pitcher, string mascot)
            :base(playerCount, headCoach, playerSalary, coachSalary)
        {
            _pitcher = pitcher;
            _mascot = mascot;
        }
        //get and set methods
        // public string getPitcher()
        // {
        //     return _pitcher;
        // }
        // public void setPitcher(string pitcher)
        // {
        //     _pitcher = pitcher;
        // }
        // public string getmascot()
        // {
        //     return _mascot;
        // }
        // public void setmascot(string mascot)
        // {
        //     _mascot = mascot;
        // }
        // public override void updatePlayerCount(int totalPlayers)
        // {
        //     base.updatePlayerCount(totalPlayers);
        // }
        // public override void updatePlayerSalary(int newSalary)
        // {
        //     base.updatePlayerSalary(newSalary);
        // }
        // public override void updateCoachSalary(int newSalary)
        // {
        //     base.updateCoachSalary(newSalary);
        // }
        // public override void changeCoach(string newCoach)
        // {
        //     base.changeCoach(newCoach);
        // }
        public override void updateSport()
        {
            Console.Write("Player Count: ");
            _playerCount = int.Parse(Console.ReadLine());
            Console.Write("Player Salary: ");
            _playerSalary = int.Parse(Console.ReadLine());
            Console.Write("Head Coach: ");
            _headCoach = Console.ReadLine();
            Console.Write("Coach salary: ");
            _coachSalary = int.Parse(Console.ReadLine());
            Console.Write("Pitcher name: ");
            _pitcher = Console.ReadLine();
            Console.Write("mascot name: ");
            _mascot = Console.ReadLine();
        }
        public override void displayTeam()
        {
            Console.WriteLine("\nYour Baseball 1team data:");
            Console.WriteLine($"Total Player Count: {_playerCount}");
            Console.WriteLine($"Player Salary: {_playerSalary}");
            Console.WriteLine($"Head Coach: {_headCoach}");
            Console.WriteLine($"Coach Salary: {_coachSalary}");
            Console.WriteLine($"Pitcher: {_pitcher}");
            Console.WriteLine($"mascot: {_mascot}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many teams would you like to enter?");
            int numOfTeams;
            while (!int.TryParse(Console.ReadLine(), out numOfTeams))
                Console.WriteLine("Please enter a whole number");
            Sport[] sportsArray = new Sport[numOfTeams];

            Console.WriteLine("How many Baseball teams would you like to enter?");
            int numOfBaseBallTeams;
            while (!int.TryParse(Console.ReadLine(), out numOfBaseBallTeams))
                Console.WriteLine("Please enter a whole number");
            Sport[] baseBallArray = new Sport[numOfTeams];

            // Editing the arrays
            int choice, rec, type;
            int sportCounter = 0, baseBallCounter = 0;
            choice = Menu();
            while ( choice !=4)
            {
                Console.WriteLine("Enter 1 for general sports or 2 for baseball");
                while (!int.TryParse(Console.ReadLine(), out type))
                    Console.WriteLine("1 for general sports, 2 for baseball");
                
                try 
                {
                    switch (choice)
                    {
                        case 1: // add a new team to the array
                            if (type == 1) //general sports
                            {
                                if (sportCounter <= numOfTeams)
                                {
                                    sportsArray[sportCounter]= new Sport();
                                    sportsArray[sportCounter].updateSport();
                                    sportCounter++;
                                }
                                else 
                                Console.WriteLine("The maximum number of teams have been added.");
                            }
                            else // add to baseball array
                            {
                                if (baseBallCounter <= numOfBaseBallTeams)
                                {
                                    baseBallArray[baseBallCounter] = new Baseball();
                                    baseBallArray[baseBallCounter].updateSport();
                                    baseBallCounter++;
                                }
                                else    
                                    Console.WriteLine("The maximum number of baseball teams has been reached. ");
                            }
                        break;
                        case 2: // change an object in the array
                        {
                            Console.Write("Enter the index number of the team you want to change");
                            while (!int.TryParse(Console.ReadLine(), out rec))
                                Console.Write("Enter the index number of the team you want to change");
                            rec--; // adjusting for index starting at zero
                            if (type ==1) // sport
                            {
                                while(rec > sportCounter -1 || rec < 0)
                                {
                                    Console.Write("The number you entered was out of range. Try again.");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the index number you want to change.");
                                    rec--;
                                }
                                sportsArray[rec].updateSport();
                            }
                            else {
                                while (rec> baseBallCounter -1 || rec <0)
                                {
                                    Console.Write("The number you entered was out of range");
                                    while (!int.TryParse(Console.ReadLine(), out rec))
                                        Console.Write("Enter the index of the team you want to change.");
                                    rec--;
                                }
                                baseBallArray[rec].updateSport();
                            }
                        }
                        break;
                        case 3: // print all
                        if (type == 1) // sport
                        {
                            for ( int i = 0; i < sportCounter; i++)
                                sportsArray[i].displayTeam();
                        }
                        else 
                        {
                            for (int i = 0; i < baseBallCounter; i++)
                                baseBallArray[i].displayTeam();
                        }
                        break;
                        default:
                            Console.WriteLine("You made an invalid selection ,please try again.");
                            break;
                    }
                }
                catch (IndexOutOfRangeException e)
                { Console.WriteLine(e.Message); }
                catch (FormatException e)
                { Console.WriteLine(e.Message); }
                catch (Exception e)
                { Console.WriteLine(e.Message); }
                choice = Menu();
            }
        }

        protected static int Menu()
        {
            Console.WriteLine("Please make a selection from the menu");
            Console.WriteLine("1-Add 2-Change 3-Print 4-Quit");
            int selection = 0;
            while (selection < 1 || selection >4 )
                while (!int.TryParse(Console.ReadLine(), out selection))
                    Console.WriteLine("1-Add 2-Change 3-Print 4-Quit");
                return selection;
        }
    }
}