﻿namespace AgileObjects.ReadableExpressions
{
    /// <summary>
    /// Provides configuration options to control aspects of source-code string generation.
    /// </summary>
    public class TranslationSettings
    {
        internal static readonly TranslationSettings Default = new TranslationSettings();

        internal TranslationSettings()
        {
            UseImplicitGenericParameters = true;
            DoNotCommentQuotedLambdas = true;
        }

        /// <summary>
        /// Always specify generic parameter arguments explicitly in &lt;pointy braces&gt;
        /// </summary>
        public TranslationSettings UseExplicitGenericParameters
        {
            get
            {
                UseImplicitGenericParameters = false;
                return this;
            }
        }

        internal bool UseImplicitGenericParameters { get; private set; }

        /// <summary>
        /// Annotate a Quoted Lambda Expression with a comment indicating that it has 
        /// been Quoted.
        /// </summary>
        public TranslationSettings ShowQuotedLambdaComments
        {
            get
            {
                DoNotCommentQuotedLambdas = false;
                return this;
            }
        }

        internal bool DoNotCommentQuotedLambdas { get; private set; }
    }
}
