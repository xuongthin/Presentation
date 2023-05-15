using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GrayController : MonoBehaviour
{
    public Slider ValueSlider;
    public TMPro.TextMeshProUGUI Text;
    private Material _material;
    private float _value;
    private static readonly int GrayValue = Shader.PropertyToID("_GrayValue");

    private void Start()
    {
        _material = GetComponent<Renderer>().material;
    }

    public void OnValueChange(float value)
    {
        _value = value;
        UpdateMaterial();
    }

    public void AddValue(float additional)
    {
        _value += additional;
        ValueSlider.value = Mathf.Clamp01(_value);
        UpdateMaterial();
    }

    private void UpdateMaterial()
    {
        _material.SetFloat(GrayValue, _value);
        Text.text = Math.Round(_value, 3, MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);
    }
}