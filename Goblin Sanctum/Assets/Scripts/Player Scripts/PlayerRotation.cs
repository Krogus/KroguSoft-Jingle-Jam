using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    /*
    public GameObject Rotato;
    public int rotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Rotato.transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }

        if (Input.GetKeyDown("d"))
        {
            Rotato.transform.eulerAngles = new Vector3(0f, 90f, 0f);
        }

        if (Input.GetKeyDown("d") && Input.GetKeyDown("w"))
        {
            Rotato.transform.eulerAngles = new Vector3(0f, 45f, 0f);
        }

    */

    public float velocity = 5;
    public float turnSpeed = 10;

    Vector2 input;

    float angle;

    Quaternion targetRotation;
    Transform cam;

    void Start()
    {
        cam = Camera.main.transform;
    }

    void Update()
    {
        GetInput();

        if (Mathf.Abs(input.x) < 1 && Mathf.Abs(input.y) < 1)
            {
            return;
            }

        CalculateDirection();
        Rotate();
        


    }

    void GetInput()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
    }

    void CalculateDirection()
    {
        angle = Mathf.Atan2(input.x, input.y);
        angle = Mathf.Rad2Deg * angle;
        angle += cam.eulerAngles.y;
    }

    void Rotate()
    {
        targetRotation = Quaternion.Euler(0, angle, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
    }








}
