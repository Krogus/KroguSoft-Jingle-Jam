using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
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

    public GameObject Rotato; //This is the OBJECT that returns the ROTATION
    int Rotation;
    public Animator _animator; //This is the ANIMATOR that will change the VISUALS of the SPRITE

    // Update is called once per frame
    void Update()
    {
        switch (((int)Rotato.transform.eulerAngles.y + 14) / 30)
        {
            case 0:
                Rotation = 10;
                break;
            case 1:
            case 2:
                Rotation = 20;
                break;
            case 3:
                Rotation = 30;
                break;
            case 4:
            case 5:
                Rotation = 40;
                break;
            case 6:
                Rotation = 50;
                break;
            case 7:
            case 8:
                Rotation = 60;
                break;
            case 9:
                Rotation = 70;
                break;
            case 10:
            case 11:
                Rotation = 80;
                break;
            case 12:
                Rotation = 10;
                break;
            default:
                break;
        }
        _animator.SetInteger("Rotation", Rotation);
    }
}
