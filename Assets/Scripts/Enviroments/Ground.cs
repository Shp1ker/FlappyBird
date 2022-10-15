using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] Transform _birdTransform;
    [SerializeField] Vector3 _GroundOffset;

    private void Awake()
    {
        if (_birdTransform == null)
        {
            gameObject.SetActive(false);
        }
    }

    private void LateUpdate()
    {
        _GroundOffset = _birdTransform.transform.position;
        _GroundOffset.y = transform.position.y;
        _GroundOffset.z = transform.position.z;
        transform.position = _GroundOffset;

        //transform.position = _birdTransform.position + _GroundOffset;
    }
}
