using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChladniPlateController : MonoBehaviour
{
    private Material _mat;
    [SerializeField] private Vector2 _eigenValue;
    [SerializeField] private Vector2 _vibrationMode;
    [SerializeField] private Vector2 _smoothStep;
    private static readonly int EigenValues = Shader.PropertyToID("_EigenValues");
    private static readonly int VibrationModes = Shader.PropertyToID("_VibrationModes");
    private static readonly int Smoothstep = Shader.PropertyToID("_Smoothstep");

    private void Awake()
    {
        _mat = GetComponent<Renderer>().material;
        ApplyMat();
    }

    public void OnXEigenValueChange(float value)
    {
        _eigenValue.x = value;
        ApplyMat();
    }

    public void OnYEigenValueChange(float value)
    {
        _eigenValue.y = value;
        ApplyMat();
    }

    public void OnXVibrationValueChange(float value)
    {
        _vibrationMode.x = value;
        ApplyMat();
    }

    public void OnYVibrationValueChange(float value)
    {
        _vibrationMode.y = value;
        ApplyMat();
    }

    public void OnXSmoothValueChange(float value)
    {
        _smoothStep.x = value;
        ApplyMat();
    }

    public void OnYSmoothValueChange(float value)
    {
        _smoothStep.y = value;
        ApplyMat();
    }

    private void ApplyMat()
    {
        _mat.SetVector(EigenValues, _eigenValue);
        _mat.SetVector(VibrationModes, _vibrationMode);
        _mat.SetVector(Smoothstep, _smoothStep);
    }
}
