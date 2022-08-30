using Microsoft.AspNetCore.Components;
using Portfolio.Classes;

namespace Portfolio.Components {
    partial class Card {
        [Parameter]
        public CardDetails Details { get; set; } = new();
    }
}
