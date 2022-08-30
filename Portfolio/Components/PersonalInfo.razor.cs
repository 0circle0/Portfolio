using Microsoft.AspNetCore.Components;

namespace Portfolio.Components
{
    partial class PersonalInfo
    {
        [Parameter]
        public string Email { get; set; } = string.Empty;

        [Parameter]
        public string LinkedIn { get; set; } = string.Empty;

        [Parameter]
        public string Address1 { get; set; } = string.Empty;

        [Parameter]
        public string Address2 { get; set; } = string.Empty;

        [Parameter]
        public string Image { get; set; } = string.Empty;

        [Parameter]
        public string Title { get; set; } = string.Empty;
    }
}
