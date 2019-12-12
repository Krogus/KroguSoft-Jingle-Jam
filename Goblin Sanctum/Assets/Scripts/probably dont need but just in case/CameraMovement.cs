using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    public float moveSpeed = 3.0f;
    //public float gravity = -9.8f;
    //find a way to fix gravity with the rotated character first!

    private CharacterController _charController;

    //Transform t;

    //public float fixedRotation = 5;
    Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        _charController = GetComponent<CharacterController>();
        rotation = transform.rotation;
    }
    

    private void LateUpdate()
    {
        transform.rotation = rotation;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * moveSpeed;
        float deltaZ = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, moveSpeed);

        //movement.y = gravity;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);

        //t.eulerAngles = new Vector3(t.eulerAngles.x, fixedRotation, t.eulerAngles.z);
     






    }
}
