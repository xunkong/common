namespace Xunkong.GenshinData.Character;

/// <summary>
/// 角色天赋（技能）
/// </summary>
public class CharacterTalentInfo
{
    
    public int Id { get; set; }

    public int TalentId { get; set; }

    /// <summary>
    /// 在角色天赋中的排序
    /// </summary>
    public int Order { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Icon { get; set; }

    public float CdTime { get; set; }

    /// <summary>
    /// 可积攒次数
    /// </summary>
    public int MaxChargeNumber { get; set; }

    /// <summary>
    /// 大招消耗的能量
    /// </summary>
    public float CostElementValue { get; set; }


}
