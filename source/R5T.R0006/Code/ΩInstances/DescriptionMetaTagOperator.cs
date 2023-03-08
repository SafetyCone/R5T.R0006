using System;


namespace R5T.R0006
{
    public class DescriptionMetaTagOperator : IDescriptionMetaTagOperator
    {
        #region Infrastructure

        public static IDescriptionMetaTagOperator Instance { get; } = new DescriptionMetaTagOperator();


        private DescriptionMetaTagOperator()
        {
        }

        #endregion
    }
}
