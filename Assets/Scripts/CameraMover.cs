using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    //Class variables up here
    public Transform target;
    //public Vector3 target_Offset;
   // private Vector3 velocity = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraSwitch.cameraChange == 1)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }
        Vector3 newPos = target.transform.position;
        newPos.z = transform.position.z;
        transform.position = newPos;
    }
}
