using System;

using R5T.T0131;


namespace R5T.R0006
{
    /// <summary>
    /// For use with <see cref="Microsoft.AspNetCore.Components.Web.KeyboardEventArgs.Key"/> values.
    /// </summary>
    [ValuesMarker]
    public partial interface IKeys : IValuesMarker
    {
        public string Enter => "Enter";
    }
}
