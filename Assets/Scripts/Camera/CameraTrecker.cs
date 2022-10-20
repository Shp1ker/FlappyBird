using UnityEngine;

public class CameraTrecker : MonoBehaviour
{
    [SerializeField] Transform birdTransform;
    [SerializeField] Vector3 _cameraOffset;
    private void Awake()
    {
        if (birdTransform == null)
        {
            gameObject.SetActive(false);
        }
    }

    private void LateUpdate()
    {
        _cameraOffset = birdTransform.transform.position;
        _cameraOffset.y = transform.position.y;
        _cameraOffset.z = transform.position.z;
        _cameraOffset.x += BirdMover.CoefficientX;
        transform.position = _cameraOffset;

        //transform.position = _birdTransform.position + _cameraOffset;
    }
}
