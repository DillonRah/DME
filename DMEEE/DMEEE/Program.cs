static void Prototype()
{
    /* If this app was actually used then we would have a function here to be able to recieve information from our physical product
       e.g we would have info about heartrate and oxygen levels e.t.c
       going to make variables just to show that the code works, this app is still in early development
    */

    int redbloodcells = 5; // readings taken in Mcl

    // in reality this would be int redbloodcells = function();

    static string usernamefunction()
    {
        Console.WriteLine("Enter your first name");
        string firstname = Console.ReadLine();
        Console.WriteLine("Enter your last name");
        string secondname = Console.ReadLine();
        char[] second = secondname.ToCharArray();
        // the users username is their first name + the first letter of their second name
        string username = firstname + second[0];
        return username;
    }

    static int NHSlinkfunction()
    {
        Console.WriteLine("Enter your NHS number");
        string inp = Console.ReadLine();
        Int64 value;
        if (Int64.TryParse(inp, out value))
        {
            char[] inpArray = inp.ToCharArray();

            int sum = 0;

            for (int i = 0; i < 9; i++)
            {
                string currentDigit = Convert.ToString(inpArray[i]);

                sum += Convert.ToInt32(currentDigit) * (10 - i);
            }

            int remainder = sum % 11;

            int checkdigit = 11 - remainder;

            if (checkdigit == Convert.ToInt64(Convert.ToString(inpArray[9])))
            {
                return 1;
            }
            else
            {
                Console.WriteLine("You did not enter a valid NHS number");
                return 0;
            }
        }
        else
        {
            // basic validation
            Console.WriteLine("You did not enter a number");
            return 0;
        }
    }

    static string diagnosis(int redbloodcells) // this function should actually intake the information from our BTU
    {
        Console.WriteLine("On a scale from 1 to 10, how much pain are you going through, 1 being minute and 10 being max");
        int painlevel = 0;
        while (!(painlevel < 10 && painlevel > 0))
        {
            string input = Console.ReadLine();
            int value;
            if (int.TryParse(input, out value))
            {
                painlevel = Convert.ToInt32(value);
            }
            else
            {
                // basic validation
                Console.WriteLine("You did not enter a number");
            }
        }

        Console.WriteLine("Where is the pain in your body?");
        Console.WriteLine("Press 1 for upper body press 2 for lower body");
        int input1 = 3;
        while (input1 > 2)
        {
            string input = Console.ReadLine();
            int value;
            if (int.TryParse(input, out value))
            {
                if (value == 1)
                {
                    Console.WriteLine("Where abouts in your upper body is the pain?");
                    Console.WriteLine("Press 1 for your chest");
                    Console.WriteLine("Press 2 for your arms");
                    // e.t.c so on and so forth
                    string input2 = Console.ReadLine();
                    int value2;
                    if (int.TryParse(input, out value2))
                    {
                        if (value == 1)
                        {
                            // ask more questions but for sake of argument will just end the questions here
                            int x = 3;
                            if (redbloodcells - 1 > x && painlevel < 5) // cancer in its usual stages does not hurt however we will just go with it because its the example
                            {
                                return "Anaemia";
                            }
                        }
                    }

                }
                if (input1 > 2)
                {
                    Console.WriteLine("You entered a value outside of the range please try again");
                }

                else
                {
                    // Write code to go further into depth e.g is the pain in your arm, lower arm or upper arm, so on and so forth until you get to a specific body part
                }
            }
            else
            {
                // basic validation
                Console.WriteLine("You did not enter a number");
            }
        }


        string bodypartandpainlevel = "elbow" + painlevel.ToString();
        // the code above instead of "elbow" will be an actual input just not enough time to go through each individual body part
        return bodypartandpainlevel;
    }

    // Main code below:
    static void MainApp()
    {
        string username = usernamefunction();
        int NHSlogin = NHSlinkfunction();
        if (NHSlogin == 0)
        {

        }
        else if (NHSlogin > 0)
        {
            Console.WriteLine($"Welcome {username}! What would you like to do today?");
            Console.WriteLine("Are you going through mental or physical distress?");
            Console.WriteLine("If you would like to enter your physical symptoms press 1");
            Console.WriteLine("If you would like to enter your mental symptoms press 2");
            Console.WriteLine("If you would like to do both, press 3");
            string input = Console.ReadLine();
            int value;
            if (int.TryParse(input, out value))
            {
                if (value == 1)
                {
                    string problem = diagnosis(5); // instead of 5 it would actually be a function in a function to get the data from the btu
                    Console.WriteLine($"You may have {problem}");
                    Console.WriteLine("You probably want to go get it checked out by your doctors to be safe, we reccomend seeking treatment");
                    Console.WriteLine("This is a provisional diagnosis");
                    // write a function where given your disease will give you advice + treatment
                }

                if (value == 2)
                {
                    // would excecute code similar to the code above, ask a series of questions to narrow down your symptoms down and able to give you treatment.
                }
            }
            else
            {
                // basic validation
                Console.WriteLine("You did not enter a number");
            }
        }
    }


    MainApp();
    // write code which will diagnose you mental and / or both
}

Prototype();