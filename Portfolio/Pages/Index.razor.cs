using Portfolio.Classes;

namespace Portfolio.Pages
{
    partial class Index
    {
        private readonly CardDetails SpriteCreatorCard = new()
        {
            Title = "Sprite Creator 3",
            Text = "Customizable Animated Sprite Character Generator. Exports animated sprite sheets for use in games and apps. GUI Themes",
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

        private readonly CardDetails DiceCard = new()
        {
            Title = "Dice",
            Text = "Roll Customizable dice with multiple colors and menu options using Physics for WebGL, Desktop, and Android",
            Link = "https://spritecreator.itch.io/dice",
            SrcImage = "/image/Dice.png"
        };

        private readonly CardDetails WordCard = new()
        {
            Title = "Words",
            Text = "Type the words. Destroy the cubes. Keep track of your typing speed. Unity3D typing asset.",
            Link = "https://spritecreator.itch.io/words",
            SrcImage = "/image/Words.png"
        };
    }
}
