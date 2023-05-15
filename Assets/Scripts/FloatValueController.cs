using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatValueController : MaterialController
{
    public float Value;

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

    private void ApplyValue()
    {
        _mat.SetFloat(_propertyId, Value);
    }
}
