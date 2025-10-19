using System;
class BannerRenderer
{
    private string platform;
    private string browser;
    private bool wasInitialized;
    private int resize;
    public BannerRenderer(string platform, string browser, bool wasInitialized, int resize)
    {
        this.platform = platform;
        this.browser = browser;
        this.wasInitialized = wasInitialized;
        this.resize = resize;
    }
    public void RenderBanner()
    {
        if ((platform.ToUpper().IndexOf("MAC") > -1) &&
            (browser.ToUpper().IndexOf("IE") > -1) &&
            wasInitialized && resize > 0)
        {
            Console.WriteLine(">>> Rendering banner...");
        }
        else
        {
            Console.WriteLine("Conditions not met.");
        }
    }
}
class Program
{
    static void Main()
    {
        BannerRenderer banner1 = new BannerRenderer("MacOS", "IE", true, 3);
        BannerRenderer banner2 = new BannerRenderer("Windows", "Chrome", true, 2);
        banner1.RenderBanner();
        banner2.RenderBanner();
    }
}

