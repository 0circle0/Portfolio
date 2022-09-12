using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    partial class BoxGroupItems
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        public string Title { get; set; } = string.Empty;
    }
}
