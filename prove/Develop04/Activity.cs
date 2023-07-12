namespace edu.byui.cs210.dev4;




public abstract class Activity
{
    protected string name;
    protected string startMessage;

    protected string endMessage;

    protected int pauseInMS;

    protected int duration;

    public abstract void run();



    protected void ShowSpinner()
    {
        string[] spinChars = { "|", "/", "-", "\\" };
        for (int i = 0; i < 10; i++)
        {
            foreach (string spinChar in spinChars)
            {
                Console.Write(spinChar + "\r");
                Thread.Sleep(100);

            }
        }
    }
    protected void ShowCountdown(int count = 6)
    {
        for (int i = count; i > 0; i--)
        {
            Console.Write(i + "\b");
            Thread.Sleep(1000);


        }

    }
    protected virtual void Start()
    {
        Console.Clear();
        Console.WriteLine($"{name} Activity");
        Console.WriteLine(startMessage);
        Console.Write("Enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner();
        Console.WriteLine($"{name} activity started.");
        Thread.Sleep(1000);

    }
    protected virtual void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {name} Activity for {duration} seconds.");
        Console.WriteLine("Well done!");
        ShowSpinner();
    }


}