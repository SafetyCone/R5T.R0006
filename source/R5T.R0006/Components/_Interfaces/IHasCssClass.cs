using System;

using Microsoft.AspNetCore.Components;


namespace R5T.R0006.Components
{
    /// <summary>
    /// Interface for use in components that allow specifying the CSS class of their element.
    /// </summary>
    public interface IHasCssClass
    {
        /// <summary>
        /// The CSS class property for an element.
        /// </summary>
        [Parameter]
        string CssClass { get; set; }
    }
}
