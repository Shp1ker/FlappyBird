using UnityEngine;

public class CameraTracker : MonoBehaviour
{
    [SerializeField] Transform _cameraTransform;
    private void Awake()
    {
        if (_cameraTransform == null)
        {
            gameObject.SetActive(false);
        }
    }
}
