using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookTowards : MonoBehaviour
{

    RaycastHit m_HitInfo = new RaycastHit();

    public Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) || (Input.GetMouseButton(1)))
        {
            //print(_animator.GetBool("Shooting"));
            _animator.SetBool("Shooting", true);

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out m_HitInfo, Mathf.Infinity))
            {
                Vector3 hitPosition = m_HitInfo.point;
                transform.LookAt(hitPosition);
            }
        }

        
        if (!Input.GetMouseButton(0) && !(Input.GetMouseButton(1)))
        {
            _animator.SetBool("Shooting", false);
            //print("NOT SHOOTING");
        }
        


    }
}
