using System;


namespace R5T.R0006
{
    /// <summary>
    /// Used by Google to form the blurb underneath the search result link.
    /// A good description contains:
    ///     1) An accurate and concise description of web page content,
    ///     2) A benefit to the visitor of the website, and
    ///     3) A call to action to entice potential visitors to click.
    /// </summary>
    /// <remarks>
    /// Sources:
    /// * With examples: https://ahrefs.com/blog/meta-description/
    /// * Good: https://www.practicalecommerce.com/influencing-how-google-displays-your-page-description
    /// * Google's own take: https://developers.google.com/search/docs/advanced/appearance/snippet
    /// * First Google result for "how to write a good meta description": https://yoast.com/meta-descriptions/
    /// </remarks>
    public class DescriptionMetaTagBestPractices
    {
        public string A_AccurateAndConciseDescription { get; set; }
        public string B_BenefitToTheVisitor { get; set; }
        public string C_CallToAction { get; set; }
    }
}
