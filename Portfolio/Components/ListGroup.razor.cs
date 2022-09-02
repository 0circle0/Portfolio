using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    partial class ListGroup
    {
        [Parameter]
        public List<string> List { get; set; } = new();
    }
}
