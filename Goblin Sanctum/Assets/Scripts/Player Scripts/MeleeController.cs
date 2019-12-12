using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeController : MonoBehaviour
{
    public bool isAttacking;

    public MeleeHitBoxController hitbox;

    public float timeBetweenHits;
    public float hitCounter;

    public Transform firePoint;



    // Start is called before the first frame update
    void Start()
    {
        //finish writing melee
    }

    // Update is called once per frame
    void Update()
    {
        if (isAttacking)
        {
            hitCounter -= Time.deltaTime;
            if(hitCounter <= 0)
            {
                hitCounter = timeBetweenHits;
                MeleeHitBoxController newHitbox = Instantiate(hitbox, firePoint.position, firePoint.rotation) as MeleeHitBoxController;
            }
        }
        else
        {
            hitCounter = 0;
        }
    }
}
