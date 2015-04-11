using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TweetSentimentWeb2.Startup))]
namespace TweetSentimentWeb2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
