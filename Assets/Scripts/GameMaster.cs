using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public GameObject TP;
    public GameObject TPSpawnPointsParent;

    private int count = 0;

    private Transform[] TPSpawnPoints;
    private List<int> spawns;
    private int newIndex;
    private int oldIndex;
    private int spawnIndex;
    private TPCheck tpGrab;

    // Start is called before the first frame update
    void Start()
    {
        tpGrab = GameObject.Find("GrabCollider").GetComponent<TPCheck>();
        TPSpawnPoints = TPSpawnPointsParent.GetComponentsInChildren<Transform>();
        spawns = new List<int>();
        for (int n = 1; n < TPSpawnPoints.Length; n++)
        {
            spawns.Add(n);
        }
        newIndex = Random.Range(0, spawns.Count- 1);
        spawnIndex = spawns[newIndex];
        print("tp waypoints = " + (TPSpawnPoints.Length-1));
        print("spawn index = " + spawnIndex);
        TP.transform.position = TPSpawnPoints[spawnIndex].position;
        TP.SetActive(true);
    }

    public void MoveTP()
    {
        print("UPDATE");
        count += 1;
        spawns.Add(spawns[newIndex]);
        spawns.RemoveAt(newIndex);
        printSpawn();
        newIndex = Random.Range(0, spawns.Count - 2);
        spawnIndex = spawns[newIndex];
        TP.transform.position = TPSpawnPoints[spawnIndex].position;
        TP.SetActive(true);
        print("count = " + count);
        tpGrab.gotTP = false;
       

    }

    private void printSpawn()
    {
        print("SPAWN");
        foreach (int n in spawns)
        {
            print(n + ", ");
        }
    }
}
