using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScaler : MonoBehaviour
{
    public float ScaleSpeed = 0.5f;
    private float _originalScale;
    private float _additionalScale;

    private void Awake()
    {
        _originalScale = transform.localScale.x;
    }

    private void OnEnable()
    {
        _additionalScale = 0;
    }

    private void Update()
    {
        _additionalScale += ScaleSpeed * Time.deltaTime;
        transform.localScale = Vector3.one * (_additionalScale + _originalScale);
    }
}
