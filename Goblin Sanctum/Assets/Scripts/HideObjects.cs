using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class HideObjects : MonoBehaviour
{

    public Transform WatchTarget;
    public LayerMask OccluderMask;

    private List<Transform> _LastTransforms;

    void Start()
    {
        _LastTransforms = new List<Transform>();
    }

    void Update()
    {
        //reset and clear all the previous objects
        if (_LastTransforms.Count > 0)
        {
            foreach (Transform t in _LastTransforms)
                t.GetComponent<MeshRenderer>().enabled = true;
            _LastTransforms.Clear();
        }

        //Cast a ray from this object's transform the the watch target's transform.
        RaycastHit[] hits = Physics.RaycastAll(
          transform.position,
          WatchTarget.transform.position - transform.position,
          Vector3.Distance(WatchTarget.transform.position, transform.position),
          OccluderMask
        );

        //Loop through all overlapping objects and disable their mesh renderer
        if (hits.Length > 0)
        {
            foreach (RaycastHit hit in hits)
            {
                if (hit.collider.gameObject.transform != WatchTarget && hit.collider.transform.root != WatchTarget)
                {
                    var parent = hit.collider.gameObject.transform.parent.gameObject;
                    if (parent.tag == "ParentInvis")
                        foreach (var meme in parent.GetComponentsInChildren<MeshRenderer>())
                            meme.enabled = false;



                    /* //HAVE DAD HELP WITH THIS
                    foreach (var meme in parent.GetComponentsInChildren<GameObject>())
                    {
                        meme.gameObject.layer = 2;

                    }
                    */ //HAVE DAD HELP WITH THIS



                    hit.collider.gameObject.GetComponent<MeshRenderer>().enabled = false;
                    _LastTransforms.Add(hit.collider.gameObject.transform);
                }
            }
        }
        else
        {
                foreach (var obj in GameObject.FindGameObjectsWithTag("ParentInvis"))
                    foreach (var meme in obj.GetComponentsInChildren<MeshRenderer>())
                        meme.enabled = true;
        }
    }
}