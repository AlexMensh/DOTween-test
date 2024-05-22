using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _endValue;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    void Start()
    {
        transform.DOScale(_endValue, _duration).SetLoops(_repeats, _loopType);
    }

}
