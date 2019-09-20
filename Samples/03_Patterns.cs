using System;

public partial class Tester
{
    public void TestPatterns()
    {
        var result = DoTheWork();
    }

    public RgbColor DoTheWork()
    {
        Rainbow redColor = Rainbow.Red;
        RgbColor result;

        #region Old style
        switch (redColor)
        {

            case Rainbow.Red:
                result = new RgbColor(1.0f, 0.0f, 0.0f);
                break;
            case Rainbow.Orange:
                result = new RgbColor(1.0f, 0.0f, 0.0f);
                break;
            case Rainbow.Yellow:
                result = new RgbColor(1.0f, 0.0f, 0.0f);
                break;
            case Rainbow.Green:
                result = new RgbColor(1.0f, 0.0f, 0.0f);
                break;
            case Rainbow.Blue:
                result = new RgbColor(1.0f, 0.0f, 0.0f);
                break;
            case Rainbow.Indigo:
                result = new RgbColor(1.0f, 0.0f, 0.0f);
                break;
            case Rainbow.Violet:
                result = new RgbColor(1.0f, 0.0f, 0.0f);
                break;
            default:
                throw new ArgumentException("Unknown value");
        }

        #endregion

        #region New style

        result = redColor switch
        {
            Rainbow.Red => new RgbColor(1.0f, 0.0f, 0.0f),
            Rainbow.Orange => new RgbColor(1.0f, 0.0f, 0.0f),
            Rainbow.Yellow => new RgbColor(1.0f, 0.0f, 0.0f),
            Rainbow.Green => new RgbColor(1.0f, 0.0f, 0.0f),
            Rainbow.Blue => new RgbColor(1.0f, 0.0f, 0.0f),
            Rainbow.Indigo => new RgbColor(1.0f, 0.0f, 0.0f),
            Rainbow.Violet => new RgbColor(1.0f, 0.0f, 0.0f),
            _ => throw new ArgumentException("Unknown value")
        };

        #endregion

        return result;
    }
    #region Property switch

    public float CalcBTW(BtwType btwType) => btwType switch
    {
        BtwType.Low => 9.0f,
        BtwType.High => 21.0f,
        _ => throw new ArgumentOutOfRangeException(nameof(btwType))
    };

    #endregion

    #region Tuple switch
    public string RockPaperScissors(string first, string second)
    => (first, second) switch
    {
        ("rock", "paper") => "rock is covered by paper. Paper wins.",
        ("rock", "scissors") => "rock breaks scissors. Rock wins.",
        ("paper", "rock") => "paper covers rock. Paper wins.",
        ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
        ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
        ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
        (_, _) => "tie"
    };

    #endregion

    #region Positional
    public Hue GetHue(RgbColor color) => color switch
    {
        var (r, g, b) when r < 0.2 && g < 0.2 && b < 0.2 => Hue.Dark,
        var (r, g, b) when r < 0.6 && g < 0.6 && b < 0.6 => Hue.Medium,
        _ => Hue.Light

    };
    #endregion
}


public enum Rainbow
{
    Red,
    Orange,
    Yellow,
    Green,
    Blue,
    Indigo,
    Violet
}

public class RgbColor
{
    public float R { get; set; }
    public float G { get; set; }
    public float B { get; set; }

    public RgbColor(float r, float g, float b)
    {
        R = r;
        G = g;
        B = b;
    }

    #region Deconstruct
    public void Deconstruct(out float r, out float g, out float b)
    {
        r = R;
        g = G;
        b = B;
    }
    #endregion
}

public enum BtwType
{
    Low,
    High
}

public enum Hue
{
    Light,
    Medium,
    Dark
}

