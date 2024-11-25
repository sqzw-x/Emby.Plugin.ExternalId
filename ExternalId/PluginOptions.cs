using System.ComponentModel;
using Emby.Web.GenericEdit;

namespace ExternalId;

public class PluginOptions : EditableOptionsBase
{
    public override string EditorTitle => "Jav 外链插件设置";

    [DisplayName("JavDB 域名设置")]
    [Description("注意要有最后的斜杠，例：https://javdb.com/")]
    public string JavDbDomain { get; set; } = "https://javdb.com/";

    [DisplayName("自定义外链 1 名称")]
    [Description("将读取 <名称 + id> Nfo 标签")]
    public string Custom1Name { get; set; } = "javlib";

    [DisplayName("自定义外链 1 URL")]
    [Description("使用 {0} 引用 Nfo 中对应的值")]
    public string Custom1Url { get; set; } = "https://www.javlibrary.com/cn/vl_searchbyid.php?keyword={0}";

    [DisplayName("自定义外链 1 类型")]
    [Description("外链类型，可选：Movie, Actress")]
    public IdType Custom1Type { get; set; } = IdType.Movie;


    [DisplayName("自定义外链 2 名称")] public string Custom2Name { get; set; } = "custom2";

    [DisplayName("自定义外链 2 URL")] public string Custom2Url { get; set; } = "custom2";

    [DisplayName("自定义外链 2 类型")] public IdType Custom2Type { get; set; }


    [DisplayName("自定义外链 3 名称")] public string Custom3Name { get; set; } = "custom3";

    [DisplayName("自定义外链 3 URL")] public string Custom3Url { get; set; } = "custom3";

    [DisplayName("自定义外链 3 类型")] public IdType Custom3Type { get; set; }
}

public enum IdType
{
    Movie,
    Actress
}