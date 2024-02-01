using Lombok.NET;

namespace pairing_master.models;

[AllArgsConstructor, With]
public class Game
{
    Team team1 { get; set; }
    Team team2 { get; set; }
    
    List<Match> matches { get; set; }
}