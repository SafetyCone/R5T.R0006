using System;


namespace R5T.R0006
{
    public class Keys : IKeys
    {
        #region Infrastructure

        public static IKeys Instance { get; } = new Keys();


        private Keys()
        {
        }

        #endregion
    }
}
