using Lombok.NET;

namespace pairing_master.models;

[AllArgsConstructor, With]
public class Team
{
    String name { get; set; }
    List<Player> players { get; set; }

    public static Team getInverseTeam(Team team1)
    {
        Team td = new Team();
        td.players = team1.players[0].scores.Keys.ToList();
        td.name = "!!!";
        return td;
    }
}