using Lombok.NET;

namespace pairing_master.models;

[AllArgsConstructor, With]
public class Team
{
    String name { get; set; }
    List<Player> players { get; set; }
}