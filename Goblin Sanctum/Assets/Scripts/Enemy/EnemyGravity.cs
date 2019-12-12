using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGravity : MonoBehaviour
{
    Vector3 movement = new Vector3();
    private CharacterController _charController;
    public float gravity = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);

        movement.y -= gravity * Time.deltaTime + 9;
        _charController.Move(movement * Time.deltaTime);

    
        //FINISH THIS

    }
}
