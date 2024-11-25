using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;

namespace ExternalId.ExternalIds;

public class JavDbMovieId : IExternalId
{
    public bool Supports(IHasProviderIds item)
    {
        return item is Movie;
    }

    public string Name => "JavDB";
    public string Key => "JavDB";
    public string UrlFormatString => Plugin.Instance.Options.JavDbDomain + "v/{0}";
}

public class JavDbMovieSearchId : IExternalId
{
    public bool Supports(IHasProviderIds item)
    {
        return item is Movie;
    }

    public string Name => "JavDB Search";
    public string Key => "JavDBSearch";
    public string UrlFormatString => Plugin.Instance.Options.JavDbDomain + "search?q={0}";
}