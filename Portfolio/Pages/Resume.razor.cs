using Microsoft.JSInterop;

namespace Portfolio.Pages
{
    partial class Resume
    {
        private readonly bool showPrintButton = false;
        public async void Print()
        {
            await jsruntime.InvokeVoidAsync("Print");
            
        }
    }
}
