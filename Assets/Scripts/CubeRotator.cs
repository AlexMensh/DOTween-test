using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _position;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType;

    void Start()
    {
        transform.DORotate(_position, _duration, RotateMode.LocalAxisAdd).SetLoops(_repeats, _loopType).SetEase(_easeType);
    }
}
