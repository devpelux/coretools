![icon](https://raw.githubusercontent.com/devpelux/coretools/1.2.0/Assets/Icon.png)


# CoreTools
Lightweight package with some utilities for .NET Core.

![release](https://img.shields.io/github/v/release/devpelux/coretools?sort=semver)
![nuget](https://img.shields.io/nuget/v/coretools)
![release_date](https://img.shields.io/github/release-date/devpelux/coretools)
![downloads](https://img.shields.io/nuget/dt/coretools)
![license](https://img.shields.io/github/license/devpelux/coretools)


# Dependencies
[![net5](https://img.shields.io/badge/.NET-v5.0-blue)](https://docs.microsoft.com/dotnet)
[![net6](https://img.shields.io/badge/.NET-v6.0-blue)](https://docs.microsoft.com/dotnet)
[![drawing_common](https://img.shields.io/badge/System.Drawing.Common-v6.0.0%2B-blue)](https://www.nuget.org/packages/System.Drawing.Common)


# Content
Content of the package:


## GraphicUtils
This static class contains the following functions:

#### `Point GetCursorPos()`
*Returns the current cursor position on display.*


## GDIUtils
This static class contains the following functions:

#### `Color GetPixelColor(Point pos, [bool takeScreenshotWhenPossible = false])`
*Returns the color of the pixel at a specified position.*  
Parameters:  
**pos**: Position of the pixel from to get the color.  
**takeScreenshotWhenPossible**: Take a screenshot when possible to get the pixel color (this may be slower and is supported only in Windows).

#### `Color GetPixelColorAtCursorPos([bool takeScreenshotWhenPossible = false])`
*Returns the color of the pixel at the current cursor position on display.*  
Parameters:  
**takeScreenshotWhenPossible**: Take a screenshot when possible to get the pixel color (this may be slower and is supported only in Windows). 

#### `Bitmap CaptureScreenshot(Point pos, Size size)`
*Captures a screenshot from a specified position, with a specified size.*  
Parameters:  
**pos**: Top-left corner of the screenshot.  
**size**: Size of the screenshot.

#### `Bitmap CaptureScreenshotAtCursorPos(Size size, Size offset)`
*Captures a screenshot from the current cursor position on display, with a specified size, and offset.*  
Parameters:  
**size**: Size of the screenshot.  
**offset**: Offset of the screenshot.

#### `Bitmap CaptureScreenshotAtCursorPos(Size size)`
*Captures a screenshot from the current cursor position on display, with a specified size.*  
Parameters:  
**size**: Size of the screenshot.


## SystemUtils
This static class contains the following functions:

#### `FileInfo GetExecutingFile()`
*Returns the current application executing file.*

#### `DirectoryInfo GetExecutingDirectory()`
*Returns the current application executing directory.*


## ColorExtensions
This static class provides a set of Color extensions:

#### `Color Invert()`
*Inverts the Color by subtracting every value R, G, B from 255.*


## SizeExtensions
This static class provides a set of Size extensions:

#### `Size Invert()`
*Inverts the Size by replacing every value with its negative.*

#### `Size UniformSize(int dim)`
*Initializes a new Size with uniform dimensions.*  
Parameters:  
**dim**: Dimensions.


## StringExtensions
This static class provides a set of string extensions:

#### `bool IsDouble()`
*Checks if the string is a double.*

#### `bool IsInt()`
*Checks if the string is an int.*

#### `bool IsNumeric()`
*Checks if the string contains only numeric chars.*

#### `string NormalizeForDouble([bool ignoreFractionalZeros = true])`
*Normalizes the string for the type double.*  
Parameters:  
**ignoreFractionalZeros**: Ignore if there are only zeros as the fractional part to speed up the algorithm.

#### `string NormalizeForInt()`
*Normalizes the string for the type int.*

#### `string Append(char c)`
*Appends a char at the end of the string.*  
Parameters:  
**c**: char to append.

#### `string Append(string str)`
*Appends a string at the end of the string.*  
Parameters:  
**str**: string to append.

#### `string Reduce(int count)`
*Cuts the string by removing a specified number of chars from the end of the string.*  
Parameters:  
**count**: Number of chars to remove from the end of the string.

#### `string TakeStr(int count)`
*Returns a string by taking only the specified number of chars from the start of the string.*  
Parameters:  
**count**: Number of chars to take from the start of the string.

#### `string ToInt(int defaultValue)`
*Converts the string to an int. In case of errors returns a specified default value.*  
Parameters:  
**defaultValue**: The default value used in case of errors.

#### `string ToDouble(double defaultValue)`
*Converts the string to a double. In case of errors returns a specified default value.*  
Parameters:  
**defaultValue**: The default value used in case of errors.

#### `T? ParseTo<T>(T? defaultValue)`
*Converts the string to the specific type using a TypeDescriptor converter. In case of errors returns a specified default value.*  
Parameters:  
**defaultValue**: The default value used in case of errors.


# License
Copyright (C) 2021-2022 devpelux (Salvatore Peluso)  
Licensed under MIT license.

[![mit](https://raw.githubusercontent.com/devpelux/coretools/1.2.0/Assets/Mit.png)](https://github.com/devpelux/coretools/blob/1.2.0/LICENSE)
