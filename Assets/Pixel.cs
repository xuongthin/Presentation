using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Pixel : MonoBehaviour
{
    [Range(0, 1)] public float Value;
    private Image _image;
    private TMPro.TextMeshProUGUI _text;

    private void Start()
    {
        _image = GetComponent<Image>();
        _text = GetComponentInChildren<TMPro.TextMeshProUGUI>();

        _image.color = new Color(Value, Value, Value, 1);
        _text.color = new Color(1 - Value, 1 - Value, 1 - Value, 1);
        var roundedValue = Math.Round(Value, 2, MidpointRounding.AwayFromZero);
        _text.text = roundedValue.ToString(CultureInfo.InvariantCulture);
    }
}