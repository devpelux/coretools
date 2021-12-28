<!-- icon -->

<p align="center">
  <img width="90px" align="center" src="https://raw.githubusercontent.com/devpelux/coretools/1.1.0/Assets/Icon.png"></img>
</p>
<h2 align="center">CoreTools</h2>
<p align="center">Lightweight package with some utilities for .NET Core.</p>

<!-- badges -->

<p align="center">
  <img src="https://img.shields.io/github/v/release/devpelux/coretools?sort=semver"></img>
  <img src="https://img.shields.io/nuget/v/coretools"></img>
  <img src="https://img.shields.io/github/release-date/devpelux/coretools"></img>
  <img src="https://img.shields.io/nuget/dt/coretools"></img>
  <img src="https://img.shields.io/github/license/devpelux/coretools"></img>
</p>
<p align="center">
  <img src="https://img.shields.io/badge/code:release-v1.1.0-blue"></img>
  <img src="https://img.shields.io/badge/code:status-stable-blue"></img>
</p>

<!-- description -->

## Availability

**NUGET:** https://www.nuget.org/packages/CoreTools

## Dependencies

[![net5](https://img.shields.io/badge/.NET-v5.0-blue)](https://docs.microsoft.com/dotnet)
[![net6](https://img.shields.io/badge/.NET-v6.0-blue)](https://docs.microsoft.com/dotnet)

## Overview

### GraphicUtils

This static class contains the following functions:

- `Point GetCursorPos()`  
Returns the current cursor position on display.

### SystemUtils

This static class contains the following functions:

- `FileInfo GetExecutingFile()`  
Returns the current application executing file.

- `DirectoryInfo GetExecutingDirectory()`  
Returns the current application executing directory.

### ColorExtensions

This static class provides a set of **Color** extensions:

- `Color Invert()`  
Invert the **Color** by subtracting every value R, G, B from 255.

### SizeExtensions

This static class provides a set of **Size** extensions:

- `Size Invert()`  
Invert the **Size** by replacing every value with its negative.

- `Size UniformSize(int dim)`  
Initializes a new **Size** with uniform dimensions.

### StringExtensions

This static class provides a set of **string** extensions:

- `bool IsDouble()`  
Check if the **string** is a **double**.

- `bool IsInt()`  
Check if the **string** is an **int**.

- `bool IsNumeric()`  
Check if the **string** contains only **numeric** chars.

- `string NormalizeForDouble([bool ignoreFractionalZeros = true])`  
Normalize the **string** for the type **double**.

  - `ignoreFractionalZeros`: Ignore if there are only zeros as the fractional part to speed up the algorithm.

- `string NormalizeForInt()`  
Normalize the **string** for the type **int**.

- `string Append(char c)`  
Append a **char** at the end of the **string**.

- `string Append(string str)`  
Append a **string** at the end of the **string**.

- `string Reduce(int count)`  
Cut the **string** by removing a specified number of chars from the end of the **string**.

<!-- license -->

## License
Copyright (C) 2021-2022 devpelux (Salvatore Peluso)  
Licensed under MIT license.

[![mit](https://raw.githubusercontent.com/devpelux/coretools/1.1.0/Assets/Mit.png)](https://github.com/devpelux/coretools/blob/1.1.0/LICENSE)
