using DG.Tweening;
using UnityEngine;

[RequireComponent (typeof(MeshRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Color _color;

    private MeshRenderer _meshRenderer;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer> ();

        _meshRenderer.material.DOColor(_color, _duration);
    }
}
