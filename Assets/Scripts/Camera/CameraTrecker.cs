using UnityEngine;

public class CameraTrecker : MonoBehaviour
{
    [SerializeField] Transform _birdTransform;
    [SerializeField] Vector3 _cameraOffset;

    private void Awake()
    {
        if (_birdTransform == null)
        {
            gameObject.SetActive(false);
        }
    }

    private void LateUpdate()
    {
        _cameraOffset = _birdTransform.transform.position;
        _cameraOffset.y = transform.position.y;
        _cameraOffset.z = transform.position.z;
        transform.position = _cameraOffset;

        //transform.position = _birdTransform.position + _cameraOffset;
    }
}
