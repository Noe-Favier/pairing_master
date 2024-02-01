using pairing_master.models;

namespace pairing_master.services;

public class MatchProcessor
{
    public ProcessResult processGame(Team team1)
    {
        ProcessResult result = new ProcessResult();
        //TODO
        result.configs = new List<Game>();
        result.configs.Add(new Game(team1));
        return result;
    }
}