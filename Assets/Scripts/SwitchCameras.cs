using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject LookCamera;
    private Transform main;

    void Start()
    {
        main = MainCamera.GetComponent<Transform>();
        //print(main.position);
    }

    void Update()
    {
        //print("main = " + main.position);
        if (Input.GetKeyDown("space"))
        {
            main.position = MainCamera.transform.position;
            LookCamera.SetActive(true);
            MainCamera.SetActive(false);
            print(main.position);
        }

        if (Input.GetKeyUp("space"))
        {
            LookCamera.SetActive(false);
            MainCamera.SetActive(true);
        }
 
    }
}
