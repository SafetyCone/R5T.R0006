using System;

using R5T.R0006;


namespace System
{
    public static class DescriptionMetaTagBestPracticesExtensions
    {
        public static string GetDescription(this DescriptionMetaTagBestPractices description)
        {
            var output = Instances.DescriptionMetaTagOperator.GetDescription(description);
            return output;
        }
    }
}
