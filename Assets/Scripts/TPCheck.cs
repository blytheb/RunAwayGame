using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPCheck : MonoBehaviour
{
    public bool gotTP = false;

    private Collider grab;
    private GameMaster Master;


    // Start is called before the first frame update
    void Start()
    {
        grab = GetComponent<Collider>();
        Master = GameObject.Find("GameMaster").GetComponent<GameMaster>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TP")
        {
            Master.MoveTP();
        }
    }
}
  