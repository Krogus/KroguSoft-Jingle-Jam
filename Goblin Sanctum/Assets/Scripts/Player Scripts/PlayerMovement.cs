using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof (CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    public float moveSpeed = 3.0f;
    public float gravity = -9.8f;

    public float verticalVelocity;
    public float jumpForce = 40.0f;
    public float gravityJump = 3.0f;

    public Animator _animator;
    
    private CharacterController _charController;
    
    public bool sprint = false;

    float bingo;

    // Start is called before the first frame update
    void Start()
    {
        _charController = GetComponent<CharacterController>();       
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * moveSpeed;
        float deltaZ = Input.GetAxis("Vertical") * moveSpeed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, moveSpeed);

        //movement.y = gravity;
        //probably bring this back
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charController.Move(movement);
        //player.AddForce (movement * moveSpeed);

        //bingo = _animator2.GetFloat("Speed");

        
        if (_charController.velocity.x != 0 || _charController.velocity.z != 0 || _charController.velocity.y != 0)
        {
            
        }


        if (_charController.velocity.x == 0 && _charController.velocity.z == 0 && _charController.velocity.y == 0)
        {
           
        }


        /*

        if (_charController.isGrounded)
        {
            verticalVelocity = -gravityJump * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
        }
        else
        {
            verticalVelocity -= gravityJump * Time.deltaTime;
        }

        Vector3 jumpVector = new Vector3(0, verticalVelocity, 0);
        _charController.Move(jumpVector * Time.deltaTime);

        */

        /*

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //_charController.enabled = false;
            _animator.SetBool("Attacking", true);
            print(_animator.GetBool("Attacking"));
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _animator.SetBool("Attacking", false);
        }

        */

        if (Input.GetMouseButtonDown(0) && (!Input.GetMouseButton(1)))
        {
            //_charController.enabled = false;
            _animator.SetBool("Attacking", true);
            print(_animator.GetBool("Attacking"));
        }

        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetBool("Attacking", false);
        }

        // print(moveSpeed);


        if (sprint == true)
        {
            moveSpeed = 6.0f;
        }

       if (sprint == false)
        {
            moveSpeed = 3.0f;
        }


        //_animator2.SetFloat("Speed", movement.sqrMagnitude);

       /*
        if (movement.sqrMagnitude > 0.028)
        {
            _animator2.SetBool("Moving", true);
        }
        
        if (movement.sqrMagnitude < 0.028)
        {
            _animator2.SetBool("Moving", false);
        }

        print(movement.sqrMagnitude);

        */


    }
}
