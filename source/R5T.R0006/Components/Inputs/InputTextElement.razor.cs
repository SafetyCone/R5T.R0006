using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using R5T.T0154;

using R5T.R0006.Components;


namespace R5T.R0006.Inputs
{
    /// <summary>
    /// Put class documentation here (leaving the dummy documentation in the Razor file so that this documentation will appear for the component in client Razor files).
    /// </summary>
    [RazorComponentMarker]
    public partial class InputTextElement : IRazorComponentMarker,
        IHasCssClass
    {
        [Parameter]
        public string CssClass { get; set; }


        private async Task OnKeyUp(KeyboardEventArgs e)
        {
            if(e.Key == Instances.Keys.Enter)
            {
                await this.OnEnter.InvokeAsync();
            }
        }
    }
}
