using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    bool shootingMode;

    public GunController theGun;

    public MeleeController melee;

    public int count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && (Input.GetMouseButton(1)))
        {
           
            theGun.isFiring = true;
        }
    

        if (Input.GetMouseButtonUp(0))
        {
            theGun.isFiring = false;
        }
        
        if (Input.GetMouseButton(0) && (!Input.GetMouseButton(1)))
        {
            melee.isAttacking = true;
        }
        else
        {
            melee.isAttacking = false;
        }

            
        }
    }
   

