using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    partial class UnorderedList
    {
        [Parameter]
        public List<string> List { get; set; } = new();

        [Parameter]
        public string Title { get; set; } = string.Empty;
    }
}
