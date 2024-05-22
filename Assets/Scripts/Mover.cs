using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_endValue, _duration).SetLoops(_repeats, _loopType);
    }
}
