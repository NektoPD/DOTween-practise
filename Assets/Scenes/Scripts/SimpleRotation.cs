using DG.Tweening;
using UnityEngine;

public class SimpleRotation : MonoBehaviour
{
    [SerializeField] private Transform _cube;
    [SerializeField] private Quaternion _quaternion;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _repeats;

    private void Start()
    {
        transform.DORotate(_quaternion.eulerAngles, _duration).SetLoops(_repeats,_loopType);
    }
}
