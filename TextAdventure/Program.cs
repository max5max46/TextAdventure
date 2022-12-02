using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    

namespace TextAdventure
{
    internal class Program
    {
        //Variable Setup
        static int currentPage;
        static int optionSelected;
        static int textWrap = 0;
        static int linesDown;

        static bool gameLoop;
        static bool controlLoop;
        static bool gameResetLoop = true;

        //String to StringArray Setup 
        static string story;
        static String[] storyPages;

        //Main
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            //Plays Music Track
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "RetroForest.wav";
            player.PlayLooping();

            //Reseted Runs start here - Will keep the player in the Game for as long as they want
            while (gameResetLoop == true)
            {
                //variable Setup for gameLoop
                story = File.ReadAllText("story.txt");
                storyPages = story.Split('%');

                gameLoop = true;
                controlLoop = true;
                currentPage = 1;
                optionSelected = 1;

                //Menu Before Main Loop
                Console.WriteLine("\n ┌──────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                Console.WriteLine(" │ ██████ █████ ██   ██ ██████       ████   █████   ██    ██ █████ ████  ██ ██████ ██   ██ █████  █████ │");
                Console.WriteLine(" │   ██   ██     ██ ██    ██        ██  ██  ██  ██  ██    ██ ██    ██ ██ ██   ██   ██   ██ ██  ██ ██    │");
                Console.WriteLine(" │   ▓▓   ▓▓▓▓    ▓▓▓     ▓▓        ▓▓▓▓▓▓  ▓▓   ▓▓  ▓▓  ▓▓  ▓▓▓▓  ▓▓ ▓▓ ▓▓   ▓▓   ▓▓   ▓▓ ▓▓▓▓▓  ▓▓▓▓  │");
                Console.WriteLine(" │   ▒▒   ▒▒     ▒▒ ▒▒    ▒▒       ▒▒    ▒▒ ▒▒  ▒▒   ▒▒  ▒▒  ▒▒    ▒▒ ▒▒ ▒▒   ▒▒   ▒▒   ▒▒ ▒▒  ▒▒ ▒▒    │");
                Console.WriteLine(" │   ░░   ░░░░░ ░░   ░░   ░░       ░░    ░░ ░░░░░     ░░░░   ░░░░░ ░░  ░░░░   ░░    ░░░░░  ░░  ░░ ░░░░░ │");
                Console.WriteLine(" └──────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                Console.WriteLine("\n  Made By: Dylan Adams");
                Console.Write("\n  Current Story Loaded: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(storyPages[0]);
                Console.ResetColor();

                Console.WriteLine("\n\n  Press any Button to Continue");

                //if player hits Escape key closes Game
                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    gameLoop = false;
                    controlLoop = false;
                    gameResetLoop = false;
                }

                Console.Clear();

                //Main game Loop for 1 run
                while (gameLoop == true)
                {
                    //Call to write story text for current page
                    DisplayStory();

                    //Gives the player control without rewriting everything
                    while (controlLoop == true)
                    {
                        //Detect if any given page is an Ending
                        if (storyPages[currentPage].Split(';').Length != 5)
                        {
                            gameLoop = false;
                            controlLoop = false;
                            Console.WriteLine("\n\n Hit any button to Reset or Hit Escape to Quit");

                            keyInfo = Console.ReadKey(true);

                            if (keyInfo.Key == ConsoleKey.Escape)
                            {
                                gameLoop = false;
                                controlLoop = false;
                                gameResetLoop = false;
                            }

                        }
                        else
                        {
                            //Call to write Options for current page
                            DisplayOptions();

                            //Call to get player input
                            PlayerControl();
                        }
                    }
                    controlLoop = true;
                    Console.Clear();
                }
            }
        }

        //Writes out the Story for a page
        static void DisplayStory()
        {
            //Setup
            linesDown = 3;

            Console.SetCursorPosition(1, 1);

            //Story Writing Loop
            for (int i = 0; i < storyPages[currentPage].Split(';')[0].Length; i++)
            {

                Console.Write(storyPages[currentPage].Split(';')[0][i]);

                //Text Wraping By finding nearest Space
                if (textWrap > 65 && storyPages[currentPage].Split(';')[0][i] == ' ')
                {
                    Console.Write("\n ");
                    textWrap = 0;
                    linesDown++;
                }

                //Backup Text Wraping - In case of no spaces present within 20 characters past 65 force warp
                if (textWrap > 85)
                {
                    Console.Write("\n ");
                    textWrap = 0;
                    linesDown++;
                }

                textWrap++;
            }
            textWrap = 0;
        }

        //Displays the Options From a page + the Page Num
        static void DisplayOptions()
        {
            //checking to see if ending
            if (gameLoop == true)
            {
                //Display Option 1
                Console.SetCursorPosition(1, linesDown);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">");

                if (optionSelected == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                Console.Write(storyPages[currentPage].Split(';')[1]);
                Console.ResetColor();

                //Display Option 2
                Console.SetCursorPosition(1, linesDown + 1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">");

                if (optionSelected == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                Console.Write(storyPages[currentPage].Split(';')[2]);
                Console.ResetColor();
            }
        }

        //Allows the player to choose Options and quit game
        static void PlayerControl()
        {
            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey(true);

            //If player hits WASD/Left,Up,Right,Down changes highlighted option
            if (keyInfo.Key == ConsoleKey.LeftArrow || keyInfo.Key == ConsoleKey.A || keyInfo.Key == ConsoleKey.UpArrow || keyInfo.Key == ConsoleKey.W)
                optionSelected = 1;
            if (keyInfo.Key == ConsoleKey.RightArrow || keyInfo.Key == ConsoleKey.D || keyInfo.Key == ConsoleKey.DownArrow || keyInfo.Key == ConsoleKey.S)
                optionSelected = 2;

            //If player hits Enter/Space Key Selects highlighted option and moves on to next page
            if (keyInfo.Key == ConsoleKey.Enter || keyInfo.Key == ConsoleKey.Spacebar)
            {
                if (optionSelected == 1)
                    currentPage = Int32.Parse(storyPages[currentPage].Split(';')[3]);

                if (optionSelected == 2)
                    currentPage = Int32.Parse(storyPages[currentPage].Split(';')[4]);

                controlLoop = false;
            }

            //if player hits Escape key closes Game
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                gameLoop = false;
                controlLoop = false;
                gameResetLoop = false;
            }
        }
    }
}
