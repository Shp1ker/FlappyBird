using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField] Transform _birdTransform;
    [SerializeField] Vector3 _BGOffset;

    private void Awake()
    {
        if (_birdTransform == null)
        {
            gameObject.SetActive(false);
        }
    }

    private void LateUpdate()
    {
        _BGOffset = _birdTransform.transform.position;
        _BGOffset.y = transform.position.y;
        _BGOffset.z = transform.position.z;
        transform.position = _BGOffset;

        //transform.position = _birdTransform.position + _BGOffset;
    }
}
