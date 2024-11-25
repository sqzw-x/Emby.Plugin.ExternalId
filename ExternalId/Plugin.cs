using MediaBrowser.Common;
using MediaBrowser.Controller.Plugins;

namespace ExternalId;

public class Plugin : BasePluginSimpleUI<PluginOptions>
{
    public override Guid Id => Guid.Parse("f38b6329-6d0c-4dc1-8442-46b52c028edc");
    public override string Name => "Jav 外部链接支持";

    public override string Description => "提供对 JavDB 及 minnano-av 的外部链接支持.";

    public static Plugin Instance { get; private set; }

    public Plugin(IApplicationHost applicationHost) : base(applicationHost)
    {
        Instance = this;
    }

    public PluginOptions Options => GetOptions();
}