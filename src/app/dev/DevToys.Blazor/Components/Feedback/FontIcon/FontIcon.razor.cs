﻿namespace DevToys.Blazor.Components;

public partial class FontIcon : StyledComponentBase
{
    public FontIcon()
    {
        VerticalAlignment = VerticalAlignment.Center;
        HorizontalAlignment = HorizontalAlignment.Center;
    }

    [Parameter]
    public char Glyph { get; set; }

    [Parameter]
    public string FontFamily { get; set; } = "FluentSystemIcons";

    protected override void OnParametersSet()
    {
        CSS.Clear();
        CSS.Add(FontFamily);

        base.OnParametersSet();
    }
}
