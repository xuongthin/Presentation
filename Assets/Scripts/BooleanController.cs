using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanController : MaterialController
{
    public bool Value;

    public void SwitchValue()
    {
        Value = !Value;
        ApplyValue();
    }

    public void SetValue(bool value)
    {
        Value = value;
        ApplyValue();
    }

    private void ApplyValue()
    {
        _mat.SetFloat(_propertyId, Value ? 1 : 0);
    }
}
