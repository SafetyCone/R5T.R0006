using System;

using Microsoft.AspNetCore.Components;

using R5T.R0006.Components;
using R5T.T0154;


namespace R5T.R0006.Buttons
{
    /// <summary>
    /// A basic button component.
    /// </summary>
    [RazorComponentMarker]
    public partial class ButtonElement : IRazorComponentMarker,
        IHasCssClass
    {
        [Parameter]
        public string CssClass { get; set; }
    }
}
