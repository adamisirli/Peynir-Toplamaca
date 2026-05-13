using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    [SerializeField] List<GameObject> Roads = new List<GameObject>();
    [SerializeField] private Transform playerPrefab;
    private float roadLenght = 4.751863f;
    private int count = 5;
    void Start()
    {
        // ilk zemini üret
        Instantiate(Roads[0], transform.position, transform.rotation);
        for (int i = 0; i < count; i++)
        {
            CreateRoad();

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerPrefab.position.z > roadLenght - 4.751863f*count)
        {
            CreateRoad();
        }
    }
    void CreateRoad()
    {
        Instantiate(Roads[Random.Range(0, Roads.Count)], position: transform.forward * roadLenght, transform.rotation);
        roadLenght += 4.751863f;
    }
}
