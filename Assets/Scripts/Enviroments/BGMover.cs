using UnityEngine;

public class BGMover : MonoBehaviour
{
    [SerializeField] Transform birdTransform;
    [SerializeField] Vector3 transf;

    private void FixedUpdate()
    {
        transf = birdTransform.transform.position;
        transf.y = transform.position.y;
        transf.z = transform.position.y;
        transf.x += BirdMover.CoefficientX;
        transform.position = transf;
    }
}
