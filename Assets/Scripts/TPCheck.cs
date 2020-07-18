using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPCheck : MonoBehaviour
{
    public bool gotTP = false;

    private Collider grab;

    // Start is called before the first frame update
    void Start()
    {
        grab = GetComponent<Collider>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "TP")
        {
            gotTP = true;
            other.gameObject.SetActive(false);
        }
    }
}
  