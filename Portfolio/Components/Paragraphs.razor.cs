using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    partial class Paragraphs
    {
        [Parameter]
        public string Title { get; set; } = string.Empty;

        [Parameter]
        public List<string> Data { get; set; } = new();

        [Parameter]
        public bool CenterData { get; set; } = false;
    }
}
