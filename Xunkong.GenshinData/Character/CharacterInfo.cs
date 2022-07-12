namespace Xunkong.GenshinData.Character;

public class CharacterInfo
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool Enable { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int Rarity { get; set; }

    public string? Gender { get; set; }

    public int Gender2 { get; set; }

    /// <summary>
    /// 所属势力
    /// </summary>
    public string? Affiliation { get; set; }

    public string? ConstllationName { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ElementType Element { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public WeaponType WeaponType { get; set; }

    /// <summary>
    /// MM/dd
    /// </summary>
    public string? Birthday { get; set; }

    public string? Card { get; set; }

    public string? Portrait { get; set; }

    public string? FaceIcon { get; set; }

    public string? SideIcon { get; set; }

    public string? GachaCard { get; set; }

    public string? GachaSplash { get; set; }

    public string? CvChinese { get; set; }

    public string? CvJapanese { get; set; }

    public string? CvEnglish { get; set; }

    public string? CvKorean { get; set; }

    /// <summary>
    /// 天赋
    /// </summary>
    public List<CharacterTalentInfo> Talents { get; set; }


    /// <summary>
    /// 命之座
    /// </summary>
    public List<CharacterConstellationInfo>? Constellations { get; set; }

}
