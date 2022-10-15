using System.Collections;
using UnityEngine;

public class BirdMover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed = 2;
    [SerializeField] private float _hightJump = 2;
    [SerializeField] private float _minAngle = -45f;
    [SerializeField] private float _maxAngle = 45f;
    [SerializeField] private float _speedRotation = 2f;
    [SerializeField] private float _maxHeight;
    [SerializeField] Vector3 _startPosition = Vector3.zero;
    private IEnumerator _RotatationEn;
    public void Jump()
    {
        if (transform.position.y > _maxHeight)
        {
            return;
        }
        Vector2 currentSpeed = _rigidbody2D.velocity;
        float startSpeed = Mathf.Sqrt(_hightJump * 2 * Mathf.Abs(Physics.gravity.y));
        _rigidbody2D.velocity = new Vector2(currentSpeed.x, 0);
        _rigidbody2D.AddForce(new Vector2(0, startSpeed * _rigidbody2D.mass), ForceMode2D.Impulse);
        Rotate();
    }

    private void Awake()
    {
        _rigidbody2D.velocity = new Vector2(_speed, 0);
    }
    private void Update()
    {
        _rigidbody2D.rotation = Mathf.Lerp(_rigidbody2D.rotation, _maxAngle, Time.deltaTime * _speedRotation);
    }

    private void Rotate()
    {
        _rigidbody2D.rotation = _minAngle;
    }
    public void Start()
    {
        _rigidbody2D.velocity = new Vector2(_speed, 0);
        _rigidbody2D.isKinematic = false;
    }

    public void Stop()
    {
        _rigidbody2D.velocity = new Vector2(0, 0);
        transform.position = _startPosition;
        _rigidbody2D.isKinematic = true;
    }

    /*
    private void Rotate()
    {
        int minAngle = -45;
        int maxAngle = 45;
        if (_RotatationEn != null)
        {
            StopCoroutine(_RotatationEn);
        }
        _RotatationEn = RotateBird(minAngle, maxAngle);
        StartCoroutine(_RotatationEn);
    }

    private IEnumerator RotateBird(int minAngle, int maxAngle)
    {
        float timeAnimation = 1f;
        float timeOnFrame = timeAnimation / (maxAngle - minAngle);
        WaitForSeconds wait = new WaitForSeconds(timeOnFrame);
        for (int i = minAngle; i < maxAngle; i++)
        {
            _rigidbody2D.rotation = (float)i;
            yield return wait;
        }
    }
*/
}
    