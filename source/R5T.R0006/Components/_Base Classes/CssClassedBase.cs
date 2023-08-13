using System;

using Microsoft.AspNetCore.Components;

using R5T.T0154;


namespace R5T.R0006.Components
{
    [RazorComponentMarker]
    public abstract class CssClassedBase : ComponentBase,
        IHasCssClass
    {
        // Parameter property is required, even though it's declared in the interface, because the Razor component engine does not honor the inherited=true property of the parameter property.
        [Parameter]
        public string CssClass { get; set; }
    }
}
