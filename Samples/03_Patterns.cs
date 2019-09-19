using System;

public partial class Tester
{

    public RgbColor TestThree()
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




}
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
    public RgbColor(float r, float g, float b)
    {

    }
}