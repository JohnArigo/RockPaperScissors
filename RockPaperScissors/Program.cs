using System;


namespace RockPaperScissors
{
    class RockPaperScissors
    {
        static public void Main(String[] args)
        {
            bool keepGoing = true;
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 4);
            Console.WriteLine(randomNumber);
            do
            {

                int playerInput;
                Console.WriteLine("Lets Play Rock Paper & Scissors");
                Console.WriteLine("Press 1 for ROCK");
                Console.WriteLine("Press 2 for SCISSORS");
                Console.WriteLine("Press 3 for PAPER");
                bool validateInputBool = false;

                do
                    //loop through until stopped
                {
                    //find number entered by user
                    ConsoleKeyInfo input = Console.ReadKey();
                    if (char.IsDigit(input.KeyChar))
                    {
                        playerInput = int.Parse(input.KeyChar.ToString());
                        if (playerInput == 1)
                        {
                            //assign number into a int variable
                            int validInt;
                            ConsoleKeyInfo validInput;
                            Console.WriteLine("You chose ROCK correct? 1 yes, 0 no");
                            validInput = Console.ReadKey();
                            if (char.IsDigit(validInput.KeyChar))
                            {
                                validInt = int.Parse(validInput.KeyChar.ToString());
                                if (validInt == 1)
                                {
                                    if (playerInput == randomNumber)
                                    {
                                        
                                        int continueGame;
                                        ConsoleKeyInfo continueInput;
                                        Console.WriteLine("Congrats, you've won the game!");
                                        Console.WriteLine("Play again? 1 yes, 0 no");
                                        continueInput = Console.ReadKey();
                                        continueGame = int.Parse(continueInput.KeyChar.ToString());
                                        if (continueGame == 1)
                                        {
                                            validateInputBool = true;
                                        }
                                        else if (continueGame == 0)
                                        {
                                            validateInputBool = true;
                                            keepGoing = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("I have no idea what you typed so lets play again!");
                                            validateInputBool = true;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You lost");
                                        validateInputBool = true;

                                    }
                                }
                                else if (validInt == 0)
                                {
                                    Console.WriteLine("Pick again");

                                    validateInputBool = true;


                                }
                                else
                                {
                                    Console.WriteLine("Invalid Character Try again");

                                    continue;
                                }
                            }

                        }

                        else if (playerInput == 2)
                        {
                            //assign number into a int variable
                            int validInt;
                            ConsoleKeyInfo validInput;
                            Console.WriteLine("You chose SCISSORS correct? 1 yes, 0 no");
                            validInput = Console.ReadKey();
                            if (char.IsDigit(validInput.KeyChar))
                            {
                                validInt = int.Parse(validInput.KeyChar.ToString());
                                if (validInt == 1)
                                {

                                    if (playerInput == randomNumber)
                                    {
                                        int continueGame;
                                        ConsoleKeyInfo continueInput;

                                        Console.WriteLine("Congrats, you've won the game!");
                                        Console.WriteLine("Play again? 1 yes, 0 no");
                                       continueInput = Console.ReadKey();
                                        continueGame = int.Parse(continueInput.KeyChar.ToString());
                                        if (continueGame == 1)
                                        {
                                            validateInputBool = true;
                                        } else if (continueGame == 0)
                                        {
                                            validateInputBool = true;
                                            keepGoing = false;
                                        } else
                                        {
                                            Console.WriteLine("I have no idea what you typed so lets play again!");
                                            validateInputBool = true;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You lost");
                                        validateInputBool = true;

                                    }
                                }
                                else if (validInt == 0)
                                {
                                    Console.WriteLine("Pick again");

                                    validateInputBool = true;


                                }
                                else
                                {
                                    Console.WriteLine("Invalid Character Try again");

                                    continue;
                                }
                            }

                        }
                        
                        else if (playerInput == 3)
                        {
                            //assign number into a int variable
                            int validInt;
                            ConsoleKeyInfo validInput;
                            Console.WriteLine("You chose Paper correct? 1 yes, 0 no");
                            validInput = Console.ReadKey();
                            if (char.IsDigit(validInput.KeyChar))
                            {
                                validInt = int.Parse(validInput.KeyChar.ToString());
                                if (validInt == 1)
                                {
                                    if (playerInput == randomNumber)
                                    {
                                        int continueGame;
                                        ConsoleKeyInfo continueInput;
                                        Console.WriteLine("Congrats, you've won the game!");
                                        Console.WriteLine("Play again? 1 yes, 0 no");
                                        continueInput = Console.ReadKey();
                                        continueGame = int.Parse(continueInput.KeyChar.ToString());
                                        if (continueGame == 1)
                                        {
                                            validateInputBool = true;
                                        }
                                        else if (continueGame == 0)
                                        {
                                            validateInputBool = true;
                                            keepGoing = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("I have no idea what you typed so lets play again!");
                                            validateInputBool = true;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You lost");
                                        validateInputBool = true;

                                    }
                                }
                                else if (validInt == 0)
                                {
                                    Console.WriteLine("Pick again");

                                    validateInputBool = true;


                                }
                                else
                                {
                                    Console.WriteLine("Invalid Character Try again");

                                    continue;
                                }
                            }
                        }
                    }
                } while (!validateInputBool);

            } while (keepGoing);


        }
    }

}


