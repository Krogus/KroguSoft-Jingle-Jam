using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    //IDLE SPRITES//
    public Sprite Left;
    public Sprite Right;
    public Sprite Up;
    public Sprite Down;
    public Sprite TopLeft;
    public Sprite TopRight;
    public Sprite BottomLeft;
    public Sprite BottomRight;
    //ANIMATED SPRITES//
    public Sprite WalkLeft;
    public Sprite WalkRight;
    public Sprite WalkUp;
    public Sprite WalkDown;
    public Sprite WalkTopLeft;
    public Sprite WalkTopRight;
    public Sprite WalkBottomleft;
    public Sprite WalkBottomRight;

    public GameObject Rotato;

    public int Rotation;

    public Animator _animator;

   




    /*
    public bool Moving = false;

    private IEnumerator CheckMoving()
    {
        Vector3 startPosition = transform.position;
        yield return new WaitForSeconds(1f);
        Vector3 finalPosition = transform.position;

        if (startPosition.x != finalPosition.x || startPosition.y != finalPosition.y || startPosition.z != finalPosition.z)
        {
            Moving = true;
        }
    }
    */

    



    // Update is called once per frame
    void Update()
    {
        //ANIMATOR SETUP
        //UP
        if (Rotato.transform.eulerAngles.y >= 0 && Rotato.transform.eulerAngles.x <= 15)
        {
            Rotation = 10;
            _animator.SetInteger("Rotation", Rotation);
        }
        if (Rotato.transform.eulerAngles.y >= 345 && Rotato.transform.eulerAngles.y <= 360)
        {
            Rotation = 10;
            _animator.SetInteger("Rotation", Rotation);
        }
        //TOPRIGHT
        if (Rotato.transform.eulerAngles.y >= 15 && Rotato.transform.eulerAngles.y <= 75)
        {
            Rotation = 20;
            _animator.SetInteger("Rotation", Rotation);
        }
        //RIGHT
        if (Rotato.transform.eulerAngles.y >= 75 && Rotato.transform.eulerAngles.y <= 105)
        {
            Rotation = 30;
            _animator.SetInteger("Rotation", Rotation);
        }
        //BOTTOMRIGHT
        if (Rotato.transform.eulerAngles.y >= 105 && Rotato.transform.eulerAngles.y <= 165)
        {
            Rotation = 40;
            _animator.SetInteger("Rotation", Rotation);
        }
        //DOWN
        if (Rotato.transform.eulerAngles.y >= 165 && Rotato.transform.eulerAngles.y <= 195)
        {
            Rotation = 50;
            _animator.SetInteger("Rotation", Rotation);
        }
        //BOTTOMLEFT
        if (Rotato.transform.eulerAngles.y >= 195 && Rotato.transform.eulerAngles.y <= 255)
        {
            Rotation = 60;
            _animator.SetInteger("Rotation", Rotation);
        }
        //LEFT
        if (Rotato.transform.eulerAngles.y >= 255 && Rotato.transform.eulerAngles.y <= 285)
        {
            Rotation = 70;
            _animator.SetInteger("Rotation", Rotation);
        }
        //UPPERLEFT
        if (Rotato.transform.eulerAngles.y >= 285 && Rotato.transform.eulerAngles.y <= 345)
        {
            Rotation = 80;
            _animator.SetInteger("Rotation", Rotation);
        }

        if (Input.GetKey("a") || Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("d"))
        {
            _animator.SetBool("Moving", true);
            //print("true");
        }

        if (!(Input.GetKey("a")) && !(Input.GetKey("w")) && !(Input.GetKey("s")) && !(Input.GetKey("d")))
        {
            _animator.SetBool("Moving", false);

            //print("false");
        }

        




    }
}
