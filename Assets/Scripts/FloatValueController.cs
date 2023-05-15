using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class FloatValueController : MaterialController
{
    public float Value;
    public Slider Slider;
    public TMPro.TextMeshProUGUI Text;

    private void Start()
    {
        ApplyValue();
    }

    public void OnValueChange(float value)
    {
        Value = value;
        ApplyValue();
    }

    public void ChangeValue(float additional)
    {
        Value += additional;
        ApplyValue();
    }

    public void Multiply(float multiValue)
    {
        Value *= multiValue;
        ApplyValue();
    }

    private void ApplyValue()
    {
        _mat.SetFloat(_propertyId, Value);
        if (Slider != null)
            Slider.value = Value;
        if (Text != null)
        {
            var roundedValue = Math.Round(Value, 2, MidpointRounding.AwayFromZero);
            Text.text = roundedValue.ToString(CultureInfo.InvariantCulture);
        }
    }
}
