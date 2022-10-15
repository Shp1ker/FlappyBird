using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]
public class CollisionHandler : MonoBehaviour
{
    public GameObject Panel;
    [SerializeField] private UnityEvent _achivment;
    private BirdMover _birdMover;

    private void Awake()
    {
        _birdMover = GetComponent<BirdMover>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent(out Gates gate))
        {
            _achivment.Invoke();
        }
        if (other.gameObject.TryGetComponent(out Pipes Pipe))
        {
            _birdMover.Stop();
            Panel.SetActive(true);
            _achivment.Invoke();
        }
    }
}
