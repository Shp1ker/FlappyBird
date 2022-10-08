using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] private Transform _topPipeTransform;
    [SerializeField] private Transform _downPipeTransform;
    [SerializeField] private float _height = 2;
    float topHeight;
    float downHeight;

    public void Init(Vector3 position)
    {
        Vector3 startPosition = transform.position;
        transform.position = startPosition + position;    
    }
    private void Awake()
    {
        Vector3 startPosition = transform.position;
        topHeight = _topPipeTransform.gameObject.GetComponent<BoxCollider2D>().size.y;
        downHeight = _downPipeTransform.gameObject.GetComponent<BoxCollider2D>().size.y;

        _topPipeTransform.position = startPosition + new Vector3(0, _height / 2 + topHeight / 2, 0);
        _downPipeTransform.position = startPosition + new Vector3(0, _height / 2 + downHeight / 2, 0);
    }
}
