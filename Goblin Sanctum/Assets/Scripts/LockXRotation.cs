using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockXRotation : MonoBehaviour
{
    //Quaternion rotation;
    Transform t;
    public float fixedRotation = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        t = transform;
    }

    // Update is called once per frame
    void Update()
    {
        t.eulerAngles = new Vector3(fixedRotation, t.eulerAngles.y, t.eulerAngles.z);
        //transform.rotation = rotation;
        //Quaternion rotation = new Quaternion(0, 0, 10, 10);
        //transform.rotation = rotation;

        //FIX THIS DONT FORGET
    }
}
