using MovementGameObjects.Models;
using System.Drawing;

internal class Program
{
    readonly static StarShip starShip = new StarShip(new Point(12, 5), new Point(12, 5), new object());
    private static void Main(string[] args)
    {
        
        StepMove stepMove = new StepMove(starShip);

        try
        {
            stepMove.Execute();
        }
        catch (Exception)
        {

        }
    }
}