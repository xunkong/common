namespace Xunkong.GenshinData.Character;

/// <summary>
/// 命之座
/// </summary>
public class CharacterConstellationInfo
{

    public int Id { get; set; }

    public int ConstellationId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Icon { get; set; }

    /// <summary>
    /// 上一个命星的id
    /// </summary>
    public int PreviewConstellationId { get; set; }

}
