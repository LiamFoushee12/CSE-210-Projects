namespace edu.byui.cs210.dev4;


public class Reflecting : Activity
{

    public Reflecting()
    {
        name = "Reflecting";
        startMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public override void run()
    {
        this.Start();
        runActivity();
        this.End();

    }

    private void runActivity()
    {
        Console.WriteLine("Im running");
    }
}