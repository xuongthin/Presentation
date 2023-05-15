using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ImageCreator : MonoBehaviour
{
    public Pixel PixelPrefab;
    private GridLayoutGroup _gridLayoutGroup;

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
}
