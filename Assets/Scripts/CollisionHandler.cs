using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject Panel;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Pipes"))
        {
            Time.timeScale = 0;
            Panel.SetActive(true);
        }
    }
}
