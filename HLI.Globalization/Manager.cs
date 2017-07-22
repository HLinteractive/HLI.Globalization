// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="HLI.Globalization.Manager.cs" company="HL Interactive">
// //   Copyright © HL Interactive, Stockholm, Sweden, 2017
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------

using System;
using System.Globalization;

using HLI.Globalization.Dictionaries;

namespace HLI.Globalization
{
    /// <summary>
    ///     Static class to get access to localized resources
    /// </summary>
    public static class Manager
    {
        #region Public Methods and Operators

        /// <summary>
        ///     Translates the provided string using HLi dictionaries
        /// </summary>
        /// <param name="key">Phrase to translate</param>
        /// <param name="cultureInfo">Culture or null to have it retrieved</param>
        /// <returns>Localized string or <paramref name="key" /> if no match was found</returns>
        /// <remarks>In debug throws exception when no key was found</remarks>
        /// <example>
        ///     <code>
        ///         var localized = HLI.Globalization.Manager.Translate("Save", new CultureInfo("de"));
        ///     </code>
        /// </example>
        public static string Translate(string key, CultureInfo cultureInfo = null)
        {
            var ci = cultureInfo ?? CultureInfo.DefaultThreadCurrentUICulture;
            HliDictionary.Culture = ci;
            HliMessages.Culture = ci;

            if (HliDictionary.ResourceManager != null)
            {
                var translation = HliDictionary.ResourceManager.GetString(key, ci);

                if (translation == null)
                {
                    translation = HliMessages.ResourceManager.GetString(key, ci);
                    if (translation == null)
                    {
#if DEBUG
                        throw new Exception($"Key '{key}' was not found in resources for culture '{ci.Name}'.");
#else
                        translation = key.ToUpper(); // Fallback: returns the key, which GETS DISPLAYED TO THE USER
#endif
                    }
                }
                
                return translation;
            }

            return key;
        }

        #endregion
    }
}