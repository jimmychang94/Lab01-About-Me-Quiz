using System;

namespace Lab01_About_Me_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            byte correct = Check();
            Console.WriteLine($"You got {correct}/5 questions right!");
        }

        /// <summary>
        /// This method is used to play the quiz while also tallying up the number of correct answers.
        /// </summary>
        /// <returns>This method returns a byte of the number of correct answers that were given.</returns>
        static byte Check ()
        {
            byte correct = 0;
            // This method uses the variable correct as an argument and then the output of the method is reassigned to the variable correct.
            correct = CheckBirthState(correct);
            correct = CheckGameConsoles(correct);
            correct = CheckFavoriteNumber(correct);
            correct = CheckMovies(correct);
            correct = CheckFavoriteFruit(correct);
            return correct;
        }

        /// <summary>
        /// This method is used to set up a question which asks which state I was born in.
        /// </summary>
        /// <param name="correct">This byte tallies the number of correct answers the user has answered</param>
        /// <returns>This method returns the tally of correct answers after determining if the user got this question right</returns>
        static byte CheckBirthState (byte correct)
        {
            string userGuessBirthState = BirthState();
            // This if statement includes || which stands for "or" since people are likely to both write the entire name of the state or thte abbreviation.
            if (userGuessBirthState == "Illinois" || userGuessBirthState == "IL")
            {
                Console.Write("Good job! ");
                correct++;
            }
            Console.WriteLine("I was born in the state of Illinois. I moved to Seattle after I finished 1st grade.");
            return correct;
        }

        /// <summary>
        /// This method is used to set up a question which asks a true or false question.
        /// </summary>
        /// <param name="correct">This byte tallies the number of correct answers the user has answered</param>
        /// <returns>This method returns the tally of correct answers after determining if the user got this question right</returns>
        static byte CheckGameConsoles(byte correct)
        {
            bool userGuessGameConsoles = GameConsoles();
            // Since the return from the called method is a boolean, using an if statement would check if it is true or false.
            if (userGuessGameConsoles)
            {
                Console.WriteLine("How did you know? Or did you make a lucky guess? ");
                correct++;
            }
            Console.WriteLine("I currently do have a Nintendo 64, Wii, and Nintendo Switch at my house. I also have a DS and Gameboy Advance.");
            Console.WriteLine("What can I say, I've always been a fan of Nintendo.");
            Console.WriteLine("Additionally, the switch isn't mine but my brother's; he just left it here for now. He lives in New York.");
            return correct;
        }

        /// <summary>
        /// This method is used to set up a question which asks what my favorite number is.
        /// </summary>
        /// <param name="correct">This byte tallies the number of correct answers the user has answered</param>
        /// <returns>This method returns the tally of correct answers after determining if the user got this question right</returns>
        static byte CheckFavoriteNumber(byte correct)
        {
            int userGuessFavoriteNumber = FavoriteNumber();
            if (userGuessFavoriteNumber == 25)
            {
                Console.Write("It is! ");
                correct++;
            }
            Console.WriteLine("My favorite number is 25. It is the sum of all the digits of my birthday, 1/10/1994.");
            return correct;
        }

        /// <summary>
        /// This method is used to set up a question which asks which movie series I have not seen.
        /// </summary>
        /// <param name="correct">This byte tallies the number of correct answers the user has answered</param>
        /// <returns>This method returns the tally of correct answers after determining if the user got this question right</returns>
        static byte CheckMovies(byte correct)
        {
            byte userGuessMovie = Movies();
            if (userGuessMovie == 1)
            {
                Console.Write("You are correct! ");
                correct++;
            }
            Console.WriteLine("I haven't seen the original Star Wars series. The only Star Wars related movie I've seen is Rogue One.");
            Console.WriteLine("I grew up with nobody in my family being a Star Wars fan and never got around to watching the series.");
            return correct;
        }

        /// <summary>
        /// This method is used to set up a question which asks what my favorite fruit is.
        /// </summary>
        /// <param name="correct">This byte tallies the number of correct answers the user has answered</param>
        /// <returns>This method returns the tally of correct answers after determining if the user got this question right</returns>
        static byte CheckFavoriteFruit(byte correct)
        {
            // Here we have the built-in string method ToLower() so that we don't need to test for cases when the user capitalizes the first letter.
            string userGuessFavoriteFruit = FavoriteFruit().ToLower();
            if (userGuessFavoriteFruit == "strawberry" || userGuessFavoriteFruit == "strawberries")
            {
                Console.Write("That is correct! ");
                correct++;
            }
            Console.WriteLine("My favorite fruit is strawberries! I had actually grown some in my garden when I was in middle school.");
            Console.WriteLine("Unfortunately a lot of the fruit got eaten before they fully ripened (usually by birds)");
            return correct;
        }

        // The below methods all pose a question to the user and returns the response the user types in (this is used for checking to see if the user input the right ansswer).
        /// <summary>
        /// This method poses a question "What state was I born in?"
        /// </summary>
        /// <returns>This method returns the user's response.</returns>
        static string BirthState ()
        {
            Console.WriteLine("What state was I born in?");
            return Console.ReadLine();
        }

        /// <summary>
        /// This method poses a question "True or False? I have a Nintendo 64, Wii, and Nintendo Switch in my house."
        /// </summary>
        /// <returns>This method returns the user's response after verifying if it is a valid input.</returns>
        static bool GameConsoles ()
        {
            Console.WriteLine("True or False? I have a Nintendo 64, Wii, and Nintendo Switch in my house.");
            // Since the Console.ReadLine() takes the user input and returns it as a string; 
            // I need to convert the variable type to boolean since that is the type that is returned from the method.
            // This same idea was applied for any other variable type besides string
            Boolean.TryParse(Console.ReadLine(), out bool userGuessGameConsoles);
            return userGuessGameConsoles;
        }

        /// <summary>
        /// This method poses a question "What is my favorite number? It is between 0 and 100."
        /// </summary>
        /// <returns>This method returns the user's response after verifying if it is a valid input.</returns>
        static int FavoriteNumber ()
        {
            Console.WriteLine("What is my favorite number? It is between 0 and 100.");
            Int32.TryParse(Console.ReadLine(), out int userGuessFavoriteNumber);
            return userGuessFavoriteNumber;
        }

        /// <summary>
        /// This method poses a question "Which of these movie series have I not seen?"
        /// </summary>
        /// <returns>This method returns the user's response after verifying if it is a valid input.</returns>
        static byte Movies ()
        {
            Console.WriteLine("Which of these movie series have I not seen?");
            Console.WriteLine("1. Star Wars");
            Console.WriteLine("2. Harry Potter");
            Console.WriteLine("3. The Lord of the Rings");
            Byte.TryParse(Console.ReadLine(), out byte userGuessMovie);
            return userGuessMovie;
        }

        /// <summary>
        /// This method poses a question "what is my favorite fruit?"
        /// </summary>
        /// <returns>This method returns the user's response.</returns>
        static string FavoriteFruit ()
        {
            Console.WriteLine("What is my favorite fruit?");
            return Console.ReadLine();
        }
    }
}
