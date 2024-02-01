using Lombok.NET;

namespace pairing_master.models;

[AllArgsConstructor, With]
public class Match
{
    Player player1 { get; set; }
    Player player2 { get; set; }
    
    int score { get; set; }
}