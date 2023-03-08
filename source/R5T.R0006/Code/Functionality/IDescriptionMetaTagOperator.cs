using System;
using System.Linq;

using R5T.T0132;


namespace R5T.R0006
{
    [FunctionalityMarker]
    public partial interface IDescriptionMetaTagOperator : IFunctionalityMarker
    {
        public string GetDescription(DescriptionMetaTagBestPractices description)
        {
            var sentences = new[]
            {
                description.A_AccurateAndConciseDescription,
                description.B_BenefitToTheVisitor,
                description.C_CallToAction,
            }
            .Select(x => Instances.TextOperator.EnsureIsSentence(x))
            .Now();

            var descriptionText = Instances.TextOperator.JoinSentences(sentences);
            return descriptionText;
        }
    }
}
