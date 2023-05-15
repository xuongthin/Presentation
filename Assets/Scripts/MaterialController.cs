using UnityEngine;

public class MaterialController : MonoBehaviour
{
    public string PropertyRef;
    public Renderer Rend;
    protected Material _mat;
    protected int _propertyId;

    private void Awake()
    {
        _mat = Rend.material;
        _propertyId = Shader.PropertyToID(PropertyRef);
        if (!_mat.HasProperty(_propertyId))
            _propertyId = Shader.PropertyToID("_" + PropertyRef);
    }
}