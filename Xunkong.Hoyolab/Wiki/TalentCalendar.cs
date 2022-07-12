namespace Xunkong.Hoyolab.Wiki;

public class TalentCalendar
{
    /// <summary>
    /// 角色名
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// 0：角色生日，2：天赋材料
    /// </summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    /// <summary>
    /// 头像
    /// </summary>
    [JsonPropertyName("img_url")]
    public string ImgUrl { get; set; }

    [JsonPropertyName("jump_type")]
    public string JumpType { get; set; }

    [JsonPropertyName("jump_url")]
    public string JumpUrl { get; set; }

    [JsonPropertyName("content_id")]
    public string ContentId { get; set; }

    [JsonPropertyName("style")]
    public string Style { get; set; }

    [JsonPropertyName("start_time")]
    public string StartTime { get; set; }

    [JsonPropertyName("end_time")]
    public string EndTime { get; set; }

    [JsonPropertyName("font_color")]
    public string FontColor { get; set; }

    [JsonPropertyName("padding_color")]
    public string PaddingColor { get; set; }

    /// <summary>
    /// 周几开放
    /// </summary>
    [JsonPropertyName("drop_day")]
    public List<string> DropDay { get; set; }

    /// <summary>
    /// 1：武器，2：角色
    /// </summary>
    [JsonPropertyName("break_type")]
    public string BreakType { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// 天赋材料
    /// </summary>
    [JsonPropertyName("contentInfos")]
    public List<ContentInfo> ContentInfos { get; set; }

    /// <summary>
    /// 此角色或武器在展示栏中的排序，左 int：星期（周日为0），右 int：排序号
    /// </summary>
    [JsonPropertyName("sort")]
    [JsonConverter(typeof(TalentCalendarSortJsonConverter))]
    public Dictionary<int, int> Sort { get; set; }

    /// <summary>
    /// 天赋材料来源
    /// </summary>
    [JsonPropertyName("contentSource")]
    public List<ContentSource> ContentSource { get; set; }

}

/// <summary>
/// 天赋材料内容
/// </summary>
public class ContentInfo : IEquatable<ContentInfo>
{
    [JsonPropertyName("content_id")]
    public int ContentId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("bbs_url")]
    public string BbsUrl { get; set; }

    public bool Equals(ContentInfo? other)
    {
        return ContentId == other?.ContentId;
    }

    public override int GetHashCode()
    {
        return ContentId.GetHashCode();
    }
}

/// <summary>
/// 天赋材料来源
/// </summary>
public class ContentSource
{
    [JsonPropertyName("content_id")]
    public int ContentId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("bbs_url")]
    public string BbsUrl { get; set; }
}



internal class TalentCalendarSortJsonConverter : JsonConverter<Dictionary<int, int>>
{
    public override Dictionary<int, int>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString();
        if (string.IsNullOrWhiteSpace(str))
        {
            return new Dictionary<int, int>();
        }
        else
        {
            return JsonSerializer.Deserialize<Dictionary<int, int>>(str);
        }
    }

    public override void Write(Utf8JsonWriter writer, Dictionary<int, int> value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}