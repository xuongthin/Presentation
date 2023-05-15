using UnityEngine;
using Random = UnityEngine.Random;

public class PixelDrawer : MonoBehaviour
{
    public Pixel PixelPrefab;
    public bool isColorize;
    public Transform Pointer;
    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > 1)
        {
            _timer = 0;
            var pixel = Instantiate(PixelPrefab, transform);
            if (isColorize)
            {
                pixel.isColorize = true;
                pixel.ColorValue = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
            }
            else
            {
                pixel.Value = Random.Range(0f, 1f);
            }

            Canvas.ForceUpdateCanvases();
            Pointer.position = pixel.transform.position;
        }
    }
}