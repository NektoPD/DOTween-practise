using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger: MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        _spriteRenderer.DOColor(_color, _duration).SetLoops(_repeats,_loopType);
    }
}
