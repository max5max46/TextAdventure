using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static String toSplit = "Clown Adventure;You are standing in the cold on the side of the street, alone and sad, for there is no one to bring joy to. There are loops in your hands, yet you know that these loops are but child’s play when compared to the total amount of loops on your person. This fact brings joy.;Find another living creature;Bring them to you (Loop Time);2;3;You wonder an infinite city. Some might say that its quite strange that this city is infinite, but you’ve seen weirder. Your loops are feeling courageous.;Look in the police station for help;“AHHHHHHHHHHHHHHHHHHH”;4;5;You begin pulling out cometic number of loops. Your heart is happy to see so many old friends, but you are the only one smiling. You begin your performance, profound, elegant, impossibly sexy, truly a master of an object with a single hole in it. A crowd forms, eager to see what you shall do next. Eggnog.;Time to turn up the heat (Loop Time x2);Show the insects your true power (Eggnog);7;8;The police station brings back many good memories, you greet the receptionist. She didn’t live long. You decide if money can cause issues, you are the problem. After reaching the temporary holding cells you meet a man named Jerry.;“The law is absolute heathen!” (Loop Him);don’t do it, don’t do it, don’t do it, don’t do it, don’t do it, don’t do it, don’t do it, don’t do it;9;10;AHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH;“AHHHHHHHHHHHHHHHHHHHHHHHHHHHH”;Loop yourself;5;6;You successfully become one with God. It was painful but you are now free of sin, sadly, being free of sin means you can’t have loops in your “life”. Bad End. Your Loops are feeling Neutral.; ; ;0;0;You’re truly the most person of all time. The Loops start having a problematic mental episode on stage, in turn, your performance takes a hit. You can’t live up to the hype “2x!?!?!?” what were you thinking. Your Loops are feeling ecstatic.;We’re not done yet (Loop Time x3);Evade questioning. They can’t find you;11;12;Eggnog. The crowd goes silent due to lack of being among the living. “Well, that was fun” your band mate Chad said. Looks like your alone once again best make the most of it. The being known as loops recedes into the darkness of oneself.;Go to the side of the street;Move back 5 spaces and go to jail (you will pass GO though +200 Mono Money);1;13;Jerry never stood a chance in the face of the law. Though it seems that even the law is subject to the law. You are arrested for public indecency and are banned from the Total Tubular Turning Teaspoon TM. You feel right at home.;Break out. They can’t find you;Hire a trusted lawyer;12;14;You couldn’t help yourself. It only took 9 hours before Jerry couldn’t take it anymore. Your record was 11 hours before so your seeing Improvement. Next to Jerry’s left finger you find a note. “It would seem we’re in need of some teaching”. Your Loops are feeling sorrowful.;Find out who left the note;I’m not going to follow the note as I’m God destroyer of worlds;15;16;You couldn’t handle the pressure, hell, no one can handle the pressure. You find that your promise to your audience is shallow and Patronizing. Disappointment racks the crowd. Your band mate Chad can’t bear to look at you and the Loops have left. Alone. End.; ; ;0;0;You see another person who looks exactly like you going to the same spot as you. They found you. Silence, one must transcend, it must be you.;Show him the full extent of the law knowing damn well what it did to Jerry;You know that no one can handle 4x Loopige, he’s done for;17;18;Fred then hellos out “Sorry” and totally eviscerates your entire game plan. Now with no other options you must make a choice. You are not ready. But if you must. You will do it.;Fred was never going to have a long-life span, was he?;The Loops are hungry. I’m scared;19;20;You hire the best lawyer you know, yourself, or at least you would do that, but your rates are to high, if only you had 200 dollars in Monopoly Money. Ether way you pack up your things and get moving. Now at the courthouse, I kid you not, like four people were there. This is a surprise to you as human contact is dangerous to most humans.;Plead Guilty;Say that you don’t need no man;21;22;The note leads to your house, funny thing is, your homeless. A man you don’t know walks up to you. “Hello, Loopo the Clown. It would seem we have business, no?” a smile creeps across his face. You trust him.;Pierce his Torso 16 times with the short sword;Business;23;24;No, no you’re not. Sad End. You wake up feeling the full effects of Alcohol Poisoning.; ; ;0;0;You knew what would happen, yet it didn’t change the fact that Justice was served. Now with the burden of Humanity behind you, you think that maybe life could be different another go around. So, with that in mind, you feel like the genocides you committed in South Africa were fairly justified. Transcend Ending.; ; ;0;0;Many doubted your ability over the course of your life, yet one friend held strong. Now in your time of need your loops evolve to Neo Loops. Now with powers combined this faker stands no chance. Chad starts you off with a slow base line and you quickly pick up from there. 2x. 3x. But you just can’t seem to hit the Jive, Luckily the 2 loops you had held so dear in your hands Transform into one Giga Loop. 4x. The world rejoiced as their hero had arrived and saved them from the brink. You now lead a Happy life with your beautiful wife Neo Loops. Happy Ending.; ; ;0;0;His friends and family would gather at the funeral mourning the loss of there innocent boy, it didn’t have to be like this, He just needed to let me win but we’re here now. They don’t know what I did of course I couldn’t leave any evidence. So, I stand beside them and mourned, but I don’t deserve this. I should be rotting in a cell for the rest of time but instead I’m here. Not innocent Ending. Your Loops are feeling mellow.; ; ;0;0;You can’t keep going like this, the dream is fading, and reality is Sneaking through the cracks. You’re starving yet feel no hunger for it won’t let you. It must feed before it lets you die because you taste much better alive. Your dream is falling apart, nothing made sense, but you acted like it did. The creature has had its fill and detaches from you brain unfortunately this did not kill you. Instead, you got to feel the pain of having had all your limbs chewed off, half of your internal organs ripped out, and most of your skin being absent. It did not take long for you to die but in that time, suffering was the only reality left for you. Reality Ending.; ; ;0;0;You tell them what they want to hear. Guilty. Expect that was not at all what they thought. You’d be sent to prison for the second time today, never to see the light of day again. But since you are, in fact, the law the criminal justice system broke down resulting in all crime being legal. So as the tale goes you found a sweet ride and got to work purifying those Heathens with the holy light of your Loops. The Law Ending.; ; ;0;0;Then Everybody started clapping. Fake End.; ; ;0;0;About 11 Rapid strikes to his chest in, you question exactly what compelled you to take this course of action lucky thinking is not your strong suit. Now feeling satisfied with your work, you would go on to build a very successful Crypto Business TM as monopolies tend to succeed when unchallenged. You do look back sometimes wondering if sending your Loops to God was a good play but hey moneys money. Sigma Ending.; ; ;0;0;Well you were hoping to have a good conversation with this man regarding business and what not. Unfortunately, you didn’t see the short sword he was holding in time. You’d end up bleeding out with 16 holes in your chest, the loops tried to help you but hey its just business. Beta Ending. Your Loops are feeling peculiar.; ; ;0;0";
        static String[] storyArray = toSplit.Split(';');

        //Main
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            //Reseted Runs start here - Will keep the player in the Game for as long as they want
            while (gameResetLoop == true)
            {
                //variable Setup for gameLoop
                gameLoop = true;
                controlLoop = true;
                currentPage = 1;
                optionSelected = 1;

                //Menu Before Main Loop
                Console.WriteLine("\n ┌──────────────────────────────────────────────────────────────────────────────────────────────────────┐");
                Console.WriteLine(" │ ██████ █████ ██   ██ ██████       ████   ████    ██    ██ █████ ████  ██ ██████ ██   ██ █████  █████ │");
                Console.WriteLine(" │   ██   ██     ██ ██    ██        ██  ██  ██  ██  ██    ██ ██    ██ ██ ██   ██   ██   ██ ██  ██ ██    │");
                Console.WriteLine(" │   ▓▓   ▓▓▓▓    ▓▓▓     ▓▓        ▓▓▓▓▓▓  ▓▓   ▓▓  ▓▓  ▓▓  ▓▓▓▓  ▓▓ ▓▓ ▓▓   ▓▓   ▓▓   ▓▓ ▓▓▓▓▓  ▓▓▓▓  │");
                Console.WriteLine(" │   ▒▒   ▒▒     ▒▒ ▒▒    ▒▒       ▒▒    ▒▒ ▒▒  ▒▒   ▒▒  ▒▒  ▒▒    ▒▒ ▒▒ ▒▒   ▒▒   ▒▒   ▒▒ ▒▒  ▒▒ ▒▒    │");
                Console.WriteLine(" │   ░░   ░░░░░ ░░   ░░   ░░       ░░    ░░ ░░░░░     ░░░░   ░░░░░ ░░  ░░░░   ░░    ░░░░░  ░░  ░░ ░░░░░ │");
                Console.WriteLine(" └──────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                Console.WriteLine("\n  Made By: Dylan Adams");
                Console.Write("\n  Current Story Loaded: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(storyArray[0]);
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
                    Console.Write("\n ");
                    DisplayStory();

                    //Gives the player control without rewriting everything
                    while (controlLoop == true)
                    {
                        //Detect if any given page is an Ending
                        if (storyArray[((currentPage - 1) * 5) + 4] == "0")
                        {
                            gameLoop = false;
                            controlLoop = false;
                            Console.WriteLine("\n\n Hit any button to Reset or Hit Escape to Quit");
                        }

                        //Call to write Options for current page
                        DisplayOptions();

                        //Call to get player input
                        PlayerControl();

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

            //Story Writing Loop
            for (int i = 0; i < storyArray[((currentPage - 1) * 5) + 1].Length; i++)
            {

                Console.Write(storyArray[((currentPage - 1) * 5) + 1][i]);

                //Text Wraping By finding nearest Space
                if (textWrap > 65 && storyArray[((currentPage - 1) * 5) + 1][i] == ' ')
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
                Console.Write(">");

                if (optionSelected == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                Console.Write(storyArray[((currentPage - 1) * 5) + 2]);
                Console.ResetColor();

                //Display Option 2
                Console.SetCursorPosition(1, linesDown + 1);
                Console.Write(">");

                if (optionSelected == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                Console.Write(storyArray[((currentPage - 1) * 5) + 3]);
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
                    currentPage = Int32.Parse(storyArray[((currentPage - 1) * 5) + 4]);

                if (optionSelected == 2)
                    currentPage = Int32.Parse(storyArray[((currentPage - 1) * 5) + 5]);

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
