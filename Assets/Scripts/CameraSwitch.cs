using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public static int cameraChange = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "CameraChange")
        {
            cameraChange = 1;
        }
        else if (collision.transform.tag == "CameraChange2")
        {
            cameraChange = 2;
        }
    }
}
