using Microsoft.JSInterop;

namespace Portfolio.Pages
{
    partial class Resume
    {
        private readonly bool showPrintButton = false;
        public void Print()
        {
            jsruntime.InvokeVoidAsync("Print");
        }
    }
}
