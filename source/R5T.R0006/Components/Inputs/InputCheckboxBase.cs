using System;

using Microsoft.AspNetCore.Components;

using R5T.T0154;


namespace R5T.R0006.Inputs
{
    [RazorComponentMarker]
    public abstract class InputCheckboxBase : ComponentBase
    {
        [Parameter]
        public bool Disabled { get; set; }

        [Parameter]
        public bool Value { get; set; }

        [Parameter]
        public EventCallback<bool> ValueChanged { get; set; }
    }
}
