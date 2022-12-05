using Microsoft.JSInterop;

namespace Portfolio.Pages
{
    partial class Resume
    {
        private readonly bool showPrintButton = true;
        public async Task Print()
        {
            await jsruntime.InvokeVoidAsync("Print");
        }
    }
}
