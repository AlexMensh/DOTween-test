using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("NEW TEXT", _duration));
        sequence.Append(_text.DOText(" ADDED TEXT", _duration).SetRelative());
        sequence.Append(_text.DOText("SCRAMBLE MODE", _duration, true, ScrambleMode.All));
    }
}
