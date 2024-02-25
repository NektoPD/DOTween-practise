using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _textToAdd;
    [SerializeField] private string _textToChange;
    [SerializeField] private string _textToScramble;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_textToChange, _duration));
        sequence.Append(_text.DOText(_textToAdd, _duration).SetRelative());
        sequence.Append(_text.DOText(_textToScramble, _duration, true, ScrambleMode.All));
        sequence.SetLoops(_repeats, _loopType);
    }
}
