using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType;

    void Start()
    {
        transform.DORotate(_endValue, _duration, RotateMode.LocalAxisAdd).SetLoops(_repeats, _loopType).SetEase(_easeType);
    }
}
