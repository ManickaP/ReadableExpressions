namespace AgileObjects.ReadableExpressions
{
    using System;

    /// <summary>
    /// Provides configuration options to control aspects of source-code string generation.
    /// </summary>
    public class TranslationSettings
    {
        internal static readonly TranslationSettings Default = new TranslationSettings();

        internal TranslationSettings()
        {
            UseImplicitGenericParameters = true;
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
                CommentQuotedLambdas = true;
                return this;
            }
        }

        internal bool DoNotCommentQuotedLambdas => !CommentQuotedLambdas;

        internal bool CommentQuotedLambdas { get; set; }

        /// <summary>
        /// Name anonymous types using the given <paramref name="nameFactory"/> instead of the
        /// default method.
        /// </summary>
        /// <param name="nameFactory">The factory method to execute to retrieve the name for an anonymous type.</param>
        public TranslationSettings NameAnonymousTypesUsing(Func<Type, string> nameFactory)
        {
            AnonymousTypeNameFactory = nameFactory;
            return this;
        }

        internal Func<Type, string> AnonymousTypeNameFactory { get; private set; }

        /// <summary>
        /// Formats constant expression with the given <paramref name="constantFormatter"/> instead of default formatting.s
        /// </summary>
        /// <param name="constantFormatter">The constant formatter to customize constants output.</param>
        public TranslationSettings FormatConstantsWith(Func<object, string> constantFormatter)
        {
            ConstantFormatter = constantFormatter;
            return this;
        }

        internal Func<object, string> ConstantFormatter { get; private set; }
    }
}
