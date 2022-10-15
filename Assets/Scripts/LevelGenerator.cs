using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    private void Start()
    {
        float x = 2;
        for (int i = 0; i < 5; ++i)
        {
            Spawn(ref x);
        }
    }
    private void Spawn(ref float x)
    {
        Pipes temp = Instantiate(_template).GetComponent<Pipes>();
        temp.Init(new Vector3(x, 0, 0));
        x += 2;
    }
}
