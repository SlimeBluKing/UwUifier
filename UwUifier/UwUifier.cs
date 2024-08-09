namespace UwUifier;

/// <summary>
/// Provide a method to transform text into "UwU" style.
/// </summary>
public static class UwUifier
{
    /// <summary>
    /// A collection of emoticons used to enhance the "UwU" effect.
    /// </summary>
    private static readonly string[] Emoticons =
    {
        "owo",
        ">w<",
        "UwU",
        "^w^",
        ";w;",
        "(*^ω^*)",
        "(✿◡‿◡)",
        "(⁠◕⁠ᴗ⁠◕✿⁠⁠)",
        "(p≧w≦q)",
        "♡~"
    };

    /// <summary>
    /// Transforms the given text into "UwU" style by replacing certain characters and adding emoticons.
    /// </summary>
    /// <param name="text">The input text to be transformed.</param>
    /// <param name="n">The number of random emoticons to add to the end of the text. Default is 1.</param>
    /// <returns>The transformed text with "UwU" style.</returns>
    /// <example>
    /// <code>
    /// string transformedText = "Hello, world!".UwU();
    /// // Result: "Hewwo, wowwd! UwU"
    /// </code>
    /// <code>
    /// string transformedText = "Hello, world!".UwU(2);
    /// // Result: "Hewwo, wowwd! UwU ♡~"
    /// </code>
    /// </example>
    public static string UwU(this string text, int n = 1)
    {
        // Replace 'r' and 'l' with 'w'
        text = text.Replace("r", "w").Replace("l", "w").Replace("R", "W").Replace("L", "W");

        // Replace "na", "ne", "ni", "no", "nu" with their "ny" variants
        text = text.Replace("na", "nyaa").Replace("ne", "nyee").Replace("ni", "nyii").Replace("no", "nyoo").Replace("nu", "nyuu")
            .Replace("Na", "Nyaa").Replace("Ne", "Nyee").Replace("Ni", "Nyii").Replace("No", "Nyoo").Replace("Nu", "Nyuu");

        // Replace "you" with "u"
        text = text.Replace("you", "u").Replace("You", "U");

        // Add random emoticons from the Emoticons array to the end of the text
        for (var i = 0; i < n; i++)
        {
            text += " " + Emoticons[new Random().Next(Emoticons.Length)];
        }

        return text;
    }
}