![HL Interactive](https://www.dropbox.com/s/fdyzvkso9zs9ndf/HLi.Signature.DVDs.jpg?dl=1)
> HL Interactive (HLi)

# HLI.Globalization
HL Interactive globalization library where resources for localization are kept.  
Neutral language is **Swedish (sv-SE)**.

Cultures are initally auto translated using **[Microsoft's Multiligual App Toolkit (MAT)](https://developer.microsoft.com/en-us/windows/develop/multilingual-app-toolkit "Multiligual App Toolkit at Microsoft.com")**.

When reviewed by a native speaking translator the translations are marked as "final".

## Usage
### From code
Read strings using the class **`Manager.cs`**. It has a static method for translating:

	var localized = HLI.Globalization.Manager.Translate("Save", new CultureInfo("de"));

### From XAML
Use the appropriate localization provider, for example **[Xamarin.Forms IMarkupExtension](https://developer.xamarin.com/guides/xamarin-forms/advanced/localization/ "Localizing Xamarin.Forms")**

## Translation status
**Auto translated cultures (not final)**

* Danish (da)
* Spanish (es)
* Finish (fi)
* Norwegian / Bokmål (nb)

**Reviewed cultures (final)**

* German (de)
* English (en)
* Frensh (fr)
* Swedish (se) - *source culture*

## Delivery & Deployment
Download the nuget package through Package Manager Console:

> install-package HLI.Globalization

## Repository File Structure
* **HLI.Globalization** - single project in solution
	* **Dictionaries** - RESX files generated from XLF files (below)
	* **MultilingualResources** - MAT toolkit source localization files (*.xlf)

## Changes and backward compatibility
* Initial public netstandard 1.4 library