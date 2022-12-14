using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    private static System.Random rnd = new System.Random();
    [SerializeField] private GameObject _template;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private float _spaceBetweenPipes;
    [SerializeField] private int _countPipesOnStart = 3;
    [SerializeField] private int _maxPipesOnScene = 6;
    [SerializeField] private float _heightRange = 3;
    [SerializeField] private float _maxHeight = rnd.Next(10, 25);
    private Queue<Pipes> _pipesQueue;
    private Vector3 _nextPosition;

    private void Awake()
    {
        _maxHeight /= 10;
        _pipesQueue = new Queue<Pipes>();
        _nextPosition = _startPosition;

        for (int i = 0; i < _countPipesOnStart; i++)
        {
            Spawn();
        }
    }

    public void Spawn()
    {
        while (_pipesQueue.Count > _maxPipesOnScene)
        {
            Pipes oldPipe = _pipesQueue.Dequeue();
            Destroy(oldPipe.gameObject);
        }

        float offset = rnd.Next(6, 12);
        float coefficient = rnd.Next(10, 200);
        float coefficient2 = rnd.Next(10, 20);
        offset /= 10;
        coefficient /= 10;
        coefficient2 /= 10;
        float height = Mathf.PerlinNoise(1, coefficient * coefficient2 * _nextPosition.x) * _heightRange - _heightRange / 2 + offset;
        float difference = _nextPosition.y - height;
        if (difference > _maxHeight)
        {
            if (height - _nextPosition.y > 0f)
            {
                height = _nextPosition.y - _maxHeight;
            }
            else
            {
                height = _nextPosition.y + _maxHeight;
            }
        }


        Pipes temp = Instantiate(_template).GetComponent<Pipes>();
        _pipesQueue.Enqueue(temp);
        temp.Init(_nextPosition + Vector3.up * height);
        _nextPosition += _spaceBetweenPipes * Vector3.right;
    }
}
