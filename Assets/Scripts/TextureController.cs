using UnityEngine;

public class TextureController : MaterialController
{
    public Texture Value;
    public Texture[] Pool;

    private void Start()
    {
        ApplyValue();
    }

    public void SetTexture(int valueId)
    {
        if (valueId >= Pool.Length) return;
        Value = Pool[valueId];
        ApplyValue();
    }

    private void ApplyValue()
    {
        _mat.SetTexture(_propertyId, Value);
    }
}
