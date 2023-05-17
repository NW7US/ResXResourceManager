
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// 
// This template generates PublicResXFileCodeGenerator compatible code plus some
// useful extensions. 
// 
// The original version provided by ResXResourceManager is restricted to resource key names
// that are valid c# identifiers to keep this template simple (KISS!).
// 
// Us it as it is or as a scaffold to generate the code you need.
//
// As long as you have ResXResourceManager running in the background, the generated code 
// will be kept up to date.
//  
//------------------------------------------------------------------------------

namespace ResXManager.Translators.Properties {
    using System;

    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by a text template.
    // To add or remove a member, edit your .ResX file.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ResXResourceManager", "1.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ResXManager.Translators.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to "Automatically detect HTML"
        /// </summary>
        public static string AutoDetectHtml {
            get {
                return ResourceManager.GetString("AutoDetectHtml", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to "Custom prompt to append to all translation request..."
        /// </summary>
        public static string CustomPrompt {
            get {
                return ResourceManager.GetString("CustomPrompt", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to "Include comments in prompt"
        /// </summary>
        public static string IncludeCommentsInPrompt {
            get {
                return ResourceManager.GetString("IncludeCommentsInPrompt", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to "Max characters per minute"
        /// </summary>
        public static string MaxCharactersPerMinute {
            get {
                return ResourceManager.GetString("MaxCharactersPerMinute", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to "Max tokens"
        /// </summary>
        public static string MaxTokens {
            get {
                return ResourceManager.GetString("MaxTokens", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to "Temperature"
        /// </summary>
        public static string Temperature {
            get {
                return ResourceManager.GetString("Temperature", resourceCulture) ?? string.Empty;
            }
        }
    }

    /// <summary>
    /// Keys of all available strings in the applications resx-resources.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    public enum StringResourceKey
    {
        /// <summary>
        ///   Looks up a localized string similar to Automatically detect HTML.
        /// </summary>
        AutoDetectHtml,
        /// <summary>
        ///   Looks up a localized string similar to Custom prompt to append to all translation request....
        /// </summary>
        CustomPrompt,
        /// <summary>
        ///   Looks up a localized string similar to Include comments in prompt.
        /// </summary>
        IncludeCommentsInPrompt,
        /// <summary>
        ///   Looks up a localized string similar to Max characters per minute.
        /// </summary>
        MaxCharactersPerMinute,
        /// <summary>
        ///   Looks up a localized string similar to Max tokens.
        /// </summary>
        MaxTokens,
        /// <summary>
        ///   Looks up a localized string similar to Temperature.
        /// </summary>
        Temperature,
    }

    /// <summary>
    /// Specifies a localized description for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        private readonly string _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedDescriptionAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedDescriptionAttribute(StringResourceKey resourceKey)
        {
            _resourceKey = resourceKey.ToString();
        }

        /// <summary>
        /// Gets the localized description from the resource id stored in this attribute.
        /// </summary>
        public override string Description
        {
            get
            {
                return Resources.ResourceManager.GetString(_resourceKey);
            }
        }
    }

    /// <summary>
    /// Specifies a localized display name for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedDisplayNameAttribute : System.ComponentModel.DisplayNameAttribute
    {
        private readonly string _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedDisplayNameAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedDisplayNameAttribute(StringResourceKey resourceKey)
        {
            _resourceKey = resourceKey.ToString();
        }

        /// <summary>
        /// Gets the localized display name from the resource id stored in this attribute.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return Resources.ResourceManager.GetString(_resourceKey);
            }
        }
    }

    /// <summary>
    /// Specifies a localized category for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedCategoryAttribute : System.ComponentModel.CategoryAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedCategoryAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedCategoryAttribute(StringResourceKey resourceKey)
            : base(resourceKey.ToString())
        {
        }

        /// <summary>
        /// Gets the localized category name from the resource id stored in this attribute.
        /// </summary>
        protected override string GetLocalizedString(string value)
        {
            return Resources.ResourceManager.GetString(value);
        }
    }

    /// <summary>
    /// Specifies a localized display name for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public sealed class LocalizedTextAttribute : global::TomsToolbox.Essentials.TextAttribute
    {
        // This code is generated by Resources.Designer.t4
        // If you get compile errors because you don't use the TomsToolbox.Essentials NuGet package, 
        // either remove this part in the Resources.Designer.t4 file, or add a reference to the TomsToolbox.Essentials NuGet package.
        // Just search for this text and follow the instructions above.

        private readonly string _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedTextAttribute"/> class.
        /// </summary>
        /// <param name="key">Any user defined key to specify the usage of this text.</param>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedTextAttribute(object key, StringResourceKey resourceKey)
            : base(key)
        {
            _resourceKey = resourceKey.ToString();
        }

        /// <summary>
        /// Gets the localized text from the resource id stored in this attribute.
        /// </summary>
        public override string Text
        {
            get
            {
                return Resources.ResourceManager.GetString(_resourceKey);
            }
        }
    }

    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.DataTypeAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class DataTypeAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeAttribute"/> class.
        /// </summary>
        public DataTypeAttribute(StringResourceKey resourceKey, System.ComponentModel.DataAnnotations.DataType dataType)
            : base(dataType)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeAttribute"/> class.
        /// </summary>
        public DataTypeAttribute(StringResourceKey resourceKey, string customDataType)
            : base(customDataType)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.RangeAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class RangeAttribute : System.ComponentModel.DataAnnotations.RangeAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeAttribute"/> class.
        /// </summary>
        public RangeAttribute(StringResourceKey resourceKey, int minimum, int maximum)
            : base(minimum, maximum)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeAttribute"/> class.
        /// </summary>
        public RangeAttribute(StringResourceKey resourceKey, double minimum, double maximum)
            : base(minimum, maximum)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeAttribute"/> class.
        /// </summary>
        public RangeAttribute(StringResourceKey resourceKey, Type type, string minimum, string maximum)
            : base(type, minimum, maximum)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.RegularExpressionAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class RegularExpressionAttribute : System.ComponentModel.DataAnnotations.RegularExpressionAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegularExpressionAttribute"/> class.
        /// </summary>
        public RegularExpressionAttribute(StringResourceKey resourceKey, string pattern)
            : base(pattern)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.RequiredAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class RequiredAttribute : System.ComponentModel.DataAnnotations.RequiredAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredAttribute"/> class.
        /// </summary>
        public RequiredAttribute(StringResourceKey resourceKey)
            : base()
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.StringLengthAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class StringLengthAttribute : System.ComponentModel.DataAnnotations.StringLengthAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringLengthAttribute"/> class.
        /// </summary>
        public StringLengthAttribute(StringResourceKey resourceKey, int maximumLength)
            : base(maximumLength)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    

}
