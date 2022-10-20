using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdMover))]
public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private GameObject Panel;
    [SerializeField] private UnityEvent _achivment;
    [SerializeField] private UnityEvent _hit;
    private BirdMover _birdMover;

    private void Awake()
    {
        _birdMover = GetComponent<BirdMover>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Gates gate))
        {
            _achivment.Invoke();
        }
        if (other.TryGetComponent(out Ground ground))
        {
            _hit.Invoke();
            Time.timeScale = 0;
            Panel.SetActive(true);
        }
    }
}
