using System;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


namespace R5T.R0006.Components
{
    /// <summary>
    /// Interface for use in components that allow handling the <c>onclick</c> event of their element.
    /// </summary>
    public interface IHasOnClick
    {
        /// <summary>
        /// The onclick event handler for the element.
        /// </summary>
        [Parameter]
        EventCallback<MouseEventArgs> OnClick { get; set; }
    }
}
