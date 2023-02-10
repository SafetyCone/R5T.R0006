using System;

using Microsoft.AspNetCore.Components;


namespace R5T.R0006
{
    [EventHandler("ontransitionend", typeof(EventArgs), enableStopPropagation: true, enablePreventDefault: false)]
    [EventHandler("onanimationend", typeof(EventArgs), enableStopPropagation: true, enablePreventDefault: false)]
    public static class EventHandlers
    {
    }
}
