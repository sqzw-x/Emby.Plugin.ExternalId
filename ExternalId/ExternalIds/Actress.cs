using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;

namespace ExternalId.ExternalIds;

public class MinnanoavId : IExternalId
{
    public bool Supports(IHasProviderIds item)
    {
        return item is Person;
    }

    public string Name => "minnano-av";
    public string Key => "minnano-av";
    public string UrlFormatString => "http://www.minnano-av.com/{0}";
}

public class JavDbActressId : IExternalId
{
    public bool Supports(IHasProviderIds item)
    {
        return item is Person;
    }

    public string Name => "JavDB";
    public string Key => "JavDB";
    public string UrlFormatString => Plugin.Instance.Options.JavDbDomain + "search?f=actor&q={0}"; // 偷懒
}

public class TwitterId : IExternalId
{
    public bool Supports(IHasProviderIds item)
    {
        return item is Person;
    }

    public string Name => "Twitter";
    public string Key => "Twitter";
    public string UrlFormatString => "https://twitter.com/{0}";
}