public class GameService
{
    public string ComputerRnd()
    {
        Random computerSelection = new Random();
        string[] gameSelection = ["rock", "paper", "scissors"];
        return gameSelection[computerSelection.Next(0,3)];
    }
}