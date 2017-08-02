![HL Interactive](https://www.dropbox.com/s/fdyzvkso9zs9ndf/HLi.Signature.DVDs.jpg?dl=1)
> HL Interactive (HLi)

- [HLI.Globalization](#hliglobalization)
  * [Usage](#usage)
    + [From code](#from-code)
    + [From XAML](#from-xaml)
  * [Translation status](#translation-status)
  * [Delivery & Deployment](#delivery---deployment)
  * [Repository File Structure](#repository-file-structure)
  * [Changes and backward compatibility](#changes-and-backward-compatibility)

# HLI.Globalization
HL Interactive globalization library for localized resources (RESX) generated out for XLF using Multilingual App Toolkit (MAT).

[![NuGet](https://img.shields.io/nuget/v/HLI.Globalization.svg)
![Downloads](https://img.shields.io/nuget/dt/HLI.Globalization.svg)](https://preview.nuget.org/packages/HLI.Globalization/)
![Build Status VSTS](https://nodessoft.visualstudio.com/_apis/public/build/definitions/3a183231-51dc-48b1-93c8-1ecde648ef37/22/badge)

 
Neutral language is **Swedish (sv-SE)**.

Cultures are initally auto translated using **[Microsoft's Multiligual App Toolkit (MAT)](https://developer.microsoft.com/en-us/windows/develop/multilingual-app-toolkit "Multiligual App Toolkit at Microsoft.com")**.  
When reviewed by a native speaking translator the translations are marked as "final".

## Usage
### From code
Read strings using the class **`Manager.cs`**. It has a static method for translating:

	```csharp
	var localized = HLI.Globalization.Manager.Translate("Save", new CultureInfo("de"));
	```

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
* Multi-target NET45 / PCL / UAP 10 / NetStandard 1.4 using VS2017 CSPROJ
* Initial public netstandard 1.4 library