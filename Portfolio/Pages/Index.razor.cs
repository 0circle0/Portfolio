using Portfolio.Classes;

namespace Portfolio.Pages
{
    partial class Index
    {
        private readonly CardDetails SpriteCreatorCard = new()
        {
            Title = "Sprite Creator 3",
            Text = "Sprite Creator 3 is a character generator where you can design and export animated sprite sheets",
            Link = "https://spritecreator.itch.io/spritecreator3",
            SrcImage = "/image/background2.png"
        };

        private readonly CardDetails GithubCard = new()
        {
            Title = "Github",
            Text = "C/C++, C#, JavaScript, Server/Client with NodeJS, Unity3D Client/Server",
            Link = "https://github.com/0circle0",
            SrcImage = "/image/GitHub-Mark.png"
        };
    }
}
