using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;

namespace ExternalId.ExternalIds;

public class Custom1 : IExternalId
{
    public bool Supports(IHasProviderIds item)
    {
        return Plugin.Instance.Options.Custom1Type switch
        {
            IdType.Movie => item is Movie,
            IdType.Actress => item is Person,
            _ => false
        };
    }

    public string Name => Plugin.Instance.Options.Custom1Name;
    public string Key => Plugin.Instance.Options.Custom1Name;
    public string UrlFormatString => Plugin.Instance.Options.Custom1Url;
}

public class Custom2 : IExternalId
{
    public bool Supports(IHasProviderIds item)
    {
        return Plugin.Instance.Options.Custom2Type switch
        {
            IdType.Movie => item is Movie,
            IdType.Actress => item is Person,
            _ => false
        };
    }

    public string Name => Plugin.Instance.Options.Custom2Name;
    public string Key => Plugin.Instance.Options.Custom2Name;
    public string UrlFormatString => Plugin.Instance.Options.Custom2Url;
}

public class Custom3 : IExternalId
{
    public bool Supports(IHasProviderIds item)
    {
        return Plugin.Instance.Options.Custom3Type switch
        {
            IdType.Movie => item is Movie,
            IdType.Actress => item is Person,
            _ => false
        };
    }

    public string Name => Plugin.Instance.Options.Custom3Name;
    public string Key => Plugin.Instance.Options.Custom3Name;
    public string UrlFormatString => Plugin.Instance.Options.Custom3Url;
}