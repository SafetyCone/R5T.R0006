using System;


namespace R5T.R0006
{
    public static class Instances
    {
        public static IDescriptionMetaTagOperator DescriptionMetaTagOperator => R0006.DescriptionMetaTagOperator.Instance;
        public static IKeys Keys => R0006.Keys.Instance;
        public static F0000.ITextOperator TextOperator => F0000.TextOperator.Instance;
        public static F0100.IUrlOperator UrlOperator => F0100.UrlOperator.Instance;	
    }
}