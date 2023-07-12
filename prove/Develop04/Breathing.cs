namespace edu.byui.cs210.dev4;



public class Breathing : Activity
{
    public Breathing()
    {
        name = "Breathing";
        startMessage = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public override void run()
    {
        this.Start();
        runActivity();
        this.End();

    }

    private void runActivity()
    {
        for (int i = duration / 8; i > 0; i--)
        {
            Console.Write("Breathe in... ");
            this.ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            this.ShowCountdown(4);
            Console.WriteLine();
        }

    }

}
