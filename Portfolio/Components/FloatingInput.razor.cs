using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    partial class FloatingInput
    {
        [Parameter]
        public bool Required { get; set; } = true;

        [Parameter]
        public bool TextBox { get; set; } = false;

        [Parameter, EditorRequired]
        public string Text { get; set; } = string.Empty;

        [Parameter, EditorRequired]
        public string Id { get; set; } = string.Empty;
    }
}
