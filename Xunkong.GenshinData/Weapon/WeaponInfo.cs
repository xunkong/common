namespace Xunkong.GenshinData.Weapon;

public class WeaponInfo
{

    public int Id { get; set; }

    public bool Enable { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int Rarity { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WeaponType WeaponType { get; set; }

    public string? Icon { get; set; }

    public string? AwakenIcon { get; set; }

    public string? GachaIcon { get; set; }

    public string? Story { get; set; }

    public List<WeaponSkill> Skills { get; set; }

}
