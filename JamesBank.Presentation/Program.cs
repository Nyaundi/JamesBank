class Program
{
    //Application execution starts from the main method
    static void Main()
    {
        //Display Title of the app
        System.Console.WriteLine("****************James Bank * ***************");
        System.Console.WriteLine("::Login Page");

        //declaring variables to store username and password;
        string userName = null, password = null;

        //read userName from Keyboard
        System.Console.Write("Username: ");
        userName = System.Console.ReadLine();

        //read password from keyboard only if username is entered
        if (userName != "")
        {
            //read password from keyboad
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        //Validating the data i.e check username and password
        if(userName =="system" && password == "manager")
        {
            System.Console.WriteLine("To DO: Main Menu");
        }

        System.Console.WriteLine("Thank you! Visit Again");
        System.Console.ReadKey();

    }
}