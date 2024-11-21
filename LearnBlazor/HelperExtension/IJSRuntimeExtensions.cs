using Microsoft.JSInterop;

namespace LearnBlazor.HelperExtension
{
    public static class IJSRuntimeExtensions
    {
        public static async Task ToastrSuccess(this IJSRuntime jsRuntime,string message) {
            await jsRuntime.InvokeVoidAsync("showToastr", "success", message);
        }
        public static async Task ToastrWarning(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", "warning", message);
        }
        public static async Task ToastrInfo(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("showToastr", "info", message);
        }
    }
}
