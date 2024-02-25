using DG.Tweening;
using UnityEngine;

public class ChangePositionRotationScale : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private Quaternion _targetRotation;
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMove(_targetPosition, _duration).SetRelative());
        sequence.Insert(0f, transform.DORotate(_targetRotation.eulerAngles, _duration));
        sequence.Insert(0f, transform.DOScale(_targetScale, _duration));
        sequence.SetLoops(_repeats, _loopType);
    }
}
