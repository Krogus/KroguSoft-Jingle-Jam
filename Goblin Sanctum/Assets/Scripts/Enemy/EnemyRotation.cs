using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotation : MonoBehaviour
{
    private bool _following;
    
    public Transform target;

    float speed;



   public void Agro()
    {
        if (!_following)
        {
            _following = true;
            
        }
    }

    public void DeAgro()
    {
        if (_following)
        {
            _following = false;
        }
    }

    void Update()
    {
        /*
        Vector3 targetDir = target.position - transform.position;

        float step = speed * Time.deltaTime;

        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        Debug.DrawRay(transform.position, newDir, Color.red);

        transform.rotation = Quaternion.LookRotation(newDir);
        */
        if (_following)
        {
            transform.LookAt(target);
        }
        
    }
}
