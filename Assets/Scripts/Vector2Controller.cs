using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector2Controller : MaterialController
{
    public Vector2 Value;
    
    private void Start()
    {
        _mat = Rend.material;
        _mat.SetVector(_propertyId, Value);
    }
}
