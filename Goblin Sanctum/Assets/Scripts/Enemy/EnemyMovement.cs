using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private bool _following = false;

    public Transform target;

    float speed = 2;

    private CharacterController _charController;

    Vector3 movement = new Vector3();

    //Sounds below
    public AudioClip agro;
    public AudioClip deAgro;
    public AudioClip hurt;

    AudioSource audioSource;


    private void Start()
    {
        _charController = GetComponent<CharacterController>();
        _charController.isTrigger = false;
        audioSource = GetComponent<AudioSource>();
    }






    public void Agro()
    {
        if (!_following)
        {
            _following = true;
            audioSource.PlayOneShot(agro, .1f);
        }
    }

    public void DeAgro()
    {
        if (_following)
        {
            _following = false;
            audioSource.PlayOneShot(deAgro, .1f);
        }
    }

    void Update()
    {
       
        
        if (_following)
        {
            //transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 1);
            //print("working");
            //transform.position += transform.forward * Time.deltaTime * speed;
            var forward = transform.TransformDirection(Vector3.forward);


            //movement *= Time.deltaTime;
            //movement = transform.TransformDirection(movement);

            //movement.x = 1;

            //_charController.Move(forward * speed);
            _charController.SimpleMove(forward * speed);

        }

        if (!_following)
        {
           // print("not following");
        }





    }
}
