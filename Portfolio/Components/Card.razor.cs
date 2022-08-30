using Microsoft.AspNetCore.Components;

namespace Portfolio.Components {
    partial class Card {
        [Parameter]
        public string SrcImage { get; set; } = string.Empty;

        [Parameter]
        public string Title { get; set; } = string.Empty;

        [Parameter]
        public string Text {  get; set; } = string.Empty;

        [Parameter]
        public string Link { get; set; } = string.Empty;
    }
}
