using System;

using Microsoft.AspNetCore.Components;


namespace R5T.R0006.Components
{
    /// <summary>
    /// Interface for use in components that follow the Razor child-content convention.
    /// </summary>
    public interface IHasChildContent
    {
        /// <summary>
        /// The child content of the element.
        /// </summary>
        [Parameter]
        RenderFragment ChildContent { get; set; }
    }
}
