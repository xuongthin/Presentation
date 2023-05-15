using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ImageCreator : MonoBehaviour
{
    public Pixel PixelPrefab;
    private GridLayoutGroup _gridLayoutGroup;
    public float ActionDuration = 1;
    public Vector3 DstPos;
    public float DstScale;

    private void OnEnable()
    {
        _gridLayoutGroup = GetComponent<GridLayoutGroup>();
        for (int i = 0; i < _gridLayoutGroup.constraintCount; i++)
        {
            for (int j = 0; j < _gridLayoutGroup.constraintCount; j++)
            {
                var pixel = Instantiate(PixelPrefab, transform);
                pixel.Value = Random.Range(0.0f, 1.0f);
            }
        }
    }

    public void Action()
    {
        StartCoroutine(ZoomOut());
    }

    IEnumerator ZoomOut()
    {
        var texts = GetComponentsInChildren<TMPro.TextMeshPro>();
        foreach (var text in texts)
            text.text = "";

        var t = 0.0f;
        var transform1 = transform;
        var originalPosition = transform1.localPosition;
        var originalScale = transform1.localScale;

        var dstScale = new Vector3(DstScale, DstScale, DstScale);
        while (t < ActionDuration)
        {
            t += Time.deltaTime;
            yield return null;
            transform1.localScale =
                Vector3.Lerp(originalScale, dstScale, t / ActionDuration);
            transform1.localPosition = Vector3.Lerp(originalPosition, DstPos, t / ActionDuration);
        }
    }
}