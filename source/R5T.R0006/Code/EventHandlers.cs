using System;

using Microsoft.AspNetCore.Components;

using R5T.T0142;
using R5T.T0154;


namespace R5T.R0006
{
    [Obsolete("See R5T.R0015.EventHandlers")]
    [EventHandler("ontransitionend", typeof(EventArgs), enableStopPropagation: true, enablePreventDefault: false)]
    [EventHandler("onanimationend", typeof(EventArgs), enableStopPropagation: true, enablePreventDefault: false)]
    [RazorComponentMarker] // Also put this type in the Razor components list.
    [UtilityTypeMarker]
    public static class EventHandlers
    {
    }
}
