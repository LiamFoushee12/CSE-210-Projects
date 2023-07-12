namespace edu.byui.cs210.dev4;


public class Listing : Activity
{
    public Listing()
    {
        name = "Listing";
        startMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
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