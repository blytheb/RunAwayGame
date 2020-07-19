using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public GameObject TP;
    public GameObject TPSpawnPointsParent;

    public int count = 0;

    private Transform[] TPSpawnPoints;
    private int spawnIndex = 1;
    private int newIndex;
    private TPCheck tpGrab;

    // Start is called before the first frame update
    void Start()
    {
        tpGrab = GameObject.Find("GrabCollider").GetComponent<TPCheck>();
        TPSpawnPoints = TPSpawnPointsParent.GetComponentsInChildren<Transform>();
        spawnIndex = Random.Range(1, TPSpawnPoints.Length-1);
        print("tp waypoints = " + (TPSpawnPoints.Length-1));
        print("spawn index = " + spawnIndex);
        TP.transform.position = TPSpawnPoints[spawnIndex].position;
        TP.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (tpGrab.gotTP)
        {
            print("UPDATE");
            count += 1;
            newIndex = Random.Range(1, TPSpawnPoints.Length-1);
            while (newIndex == spawnIndex)
            {
                newIndex = Random.Range(1, TPSpawnPoints.Length - 1);
            }
            print("old = " + spawnIndex);
            print("new = " + newIndex);
            spawnIndex = newIndex;
            TP.transform.position = TPSpawnPoints[spawnIndex].position;
            TP.SetActive(true);
            print(" new spawn index = " + spawnIndex);
            print("count = " + count);
            tpGrab.gotTP = false;
        }
    }
}
