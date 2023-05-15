using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class MultiplyController : MonoBehaviour
{
    public Slider ValueSlider;
    public Slider ValueSlider2;
    public TMPro.TextMeshProUGUI Text;
    private Material _material;
    private float _value;
    private static readonly int GrayValue = Shader.PropertyToID("_GrayValue");

    private void Start()
    {
        _material = GetComponent<Renderer>().material;
        CalculateValue(0);
    }

    public void OnValueChange(float value)
    {
        _value = value;
        UpdateMaterial();
    }

    public void CalculateValue(float _)
    {
        _value = ValueSlider.value * ValueSlider2.value;
        _material.SetFloat(GrayValue, _value);
        Text.text = Math.Round(_value, 3, MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);
    }

    public void AddValue(float additional)
    {
        _value += additional;
        UpdateMaterial();
    }

    private void UpdateMaterial()
    {
        _material.SetFloat(GrayValue, _value);
        Text.text = Math.Round(_value, 3, MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);
        ValueSlider.value = Mathf.Clamp01(_value);

    }
}