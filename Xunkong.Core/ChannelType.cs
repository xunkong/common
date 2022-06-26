using System.ComponentModel;

namespace Xunkong.Core;

[Flags]
public enum ChannelType
{

    [Description("正式版")]
    Stable = 1,


    [Description("预览版")]
    Preview = 2,


    [Description("开发版")]
    Development = 4,


    StableAndPreview = 3,


    StableAndDevelop = 5,


    PreviewAndDevelop = 6,


    All = 7,

}
