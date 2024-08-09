# UwUifier - UwUify youw messages ヾ(≧▽≦*)o

[![NuGet](https://img.shields.io/nuget/v/UwUifier.svg?label=NuGet)](https://nuget.org/packages/UwUifier)
[![Discord Server](https://img.shields.io/discord/1219353398307065986.svg?label=Discord&color=506de2)](https://discord.gg/wKAbqUPUSZ)

## Overview

The UwUifier library is a playful tool designed to transform plain text into the whimsical and charming "UwU" style, often seen in various online communities and memes. This C# library provides a simple extension method for strings to convert regular text by modifying certain characters and adding cute emoticons.

## Features

- **Character replacement:** Transforms "r" and "l" to "w"
- **Vowel transformation:** Changes "na", "ne", "ni", "no", "nu" to their "ny" variants
- **Pronoun Simplification:** Replace "you" with "u"
- **Emoticon Addition:** Appends random cute emoticons to the uwuified text

## Usage

To transform a given text into "UwU" style, simply call the `UwU` extension method on any string. You can also specify the number of random emoticons to add to the end of the text.

```csharp
string originalText = "Hello, world! How are you?";
string uwuText = originalText.UwU();
Console.WriteLine(uwuText); // Output: "Hewwo, wowwd! How awe u? UwU"

string uwuTextWithTwoEmoticons = originalText.UwU(2);
Console.WriteLine(uwuTextWithTwoEmoticons); // Output: "Hewwo, wowwd! How awe u? UwU ♡~"
```

## Emoticons

List of emoticons:
- `owo`
- `>w<`
- `UwU`
- `^w^`
- `;w;`
- `(*^ω^*)`
- `(✿◡‿◡)`
- `(⁠◕⁠ᴗ⁠◕✿⁠⁠)`
- `(p≧w≦q)`
- `♡~`

## Contribution

Feel free to fork the repository and make improvements or add new features. Pull requests are welcome! ♡~

## License

This project is licensed under the MIT License.

Enjoy uwuify your text and spread the cuteness! ♡~
