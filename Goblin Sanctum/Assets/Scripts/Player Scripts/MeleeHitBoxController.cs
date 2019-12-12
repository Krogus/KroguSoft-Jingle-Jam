using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeHitBoxController : MonoBehaviour
{
    //You can probably remove this?
    public float speed = 0;

    public float lifeTime;

    public int damageToGive;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            print("HIT");
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
            other.gameObject.GetComponent<EnemyHealthManagerBug>().HurtEnemy(damageToGive);
            Destroy(gameObject);
        }
    }

}
