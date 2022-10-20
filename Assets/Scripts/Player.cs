using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private static int _currentScore;
    [SerializeField] private int _maxScore = 150;
    private void AddScore()
    {
        ++_currentScore;
    }
}
