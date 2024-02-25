using DG.Tweening;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    [SerializeField] private Transform _capsule;
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_targetScale, _duration).SetLoops(_repeats, _loopType);
    }
}
