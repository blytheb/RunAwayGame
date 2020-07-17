using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Transform myTransform;
    public Transform target;
    public Vector3 offset = new Vector3(0, 5, -5);

    // Start is called before the first frame update
    void Start()
    {
        myTransform = this.transform;

    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = target.position + target.TransformDirection(offset);
        myTransform.LookAt(target);
    }
}
