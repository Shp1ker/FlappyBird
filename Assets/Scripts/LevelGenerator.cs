using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    private void Start()
    {
        Spawn();
    }
    private void Spawn()
    {
        Pipes temp = Instantiate(_template).GetComponent<Pipes>();
        temp.Init(new Vector3(2, 0, 0));
    }
}
