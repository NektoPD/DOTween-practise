using DG.Tweening;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    [SerializeField] private Transform _sphere;
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _repeats;

    private void Start()
    {
        transform.DOMove(_position, _duration).SetLoops(_repeats, _loopType);
    }
}
