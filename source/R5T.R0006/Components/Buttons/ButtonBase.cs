using System;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using R5T.R0006.Components;


namespace R5T.R0006.Buttons
{
    /// <summary>
    /// Base class for buttons, providing functioal parameters other than styling.
    /// </summary>
    public abstract class ButtonBase : ComponentBase,
        IHasChildContent,
        IHasOnClick
    {
        [Parameter]
        public bool Disabled { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
