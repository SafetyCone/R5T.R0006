using System;

using Microsoft.AspNetCore.Components;


namespace R5T.R0006.Inputs
{
    public abstract class InputTextBase : ComponentBase
    {
        /// <summary>
        /// Placeholder text.
        /// </summary>
        [Parameter]
        public string Placeholder { get; set; }

        [Parameter]
        public bool Disabled { get; set; }

        [Parameter]
        public EventCallback OnEnter { get; set; }

        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }
    }
}
