using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class TheEndController : MonoBehaviour
{
    public Renderer Rend;
    private Material _mat;
    private static readonly int T = Shader.PropertyToID("_T");

    private void Awake()
    {
        _mat = Rend.material;
    }

    private void OnEnable()
    {
        StartCoroutine(End());
    }

    IEnumerator End()
    {
        _mat.SetFloat(T, 0f);
        _mat = Rend.material;
        yield return new WaitForSeconds(2);
        var timer = 0f;
        var duration = 2f;
        while (timer < duration)
        {
            timer += Time.deltaTime;
            yield return null;
            _mat.SetFloat(T, timer / duration);
        }
    }

}
