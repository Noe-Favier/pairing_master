using Lombok.NET;

namespace pairing_master.models;

[AllArgsConstructor, With]
public class Player
{
    String name { get; set; }
    
    Roles role { get; set; }
    
    public Dictionary<Player, int> scores { get; set; }
}