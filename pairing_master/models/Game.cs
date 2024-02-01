using Lombok.NET;

namespace pairing_master.models;

[AllArgsConstructor, With]
public class Game
{
    Team team1 { get; set; }
    Team team2 { get; set; } 
    
    //constructor
    public Game(Team team1)
    {
        this.team1 = team1;
        this.team2 = Team.getInverseTeam(team1);
    }
}