using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAggro : MonoBehaviour
{

    public float RangeCheckInterval = 1;
    public float AggroRadius = 1;
    public float DeAggroRadius = 4;
    public float MoveSpeed = 1;
    bool isAggro = false;
    Vector3 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CheckAggroRange());
    }

    // Update is called once per frame
    void Update()
    {
        if (isAggro)
        {
            targetPos = GameObject.Find("Player").transform.position;
            transform.LookAt(targetPos);
            float step = MoveSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
        }
    }

    IEnumerator CheckAggroRange()
    {
        CheckAggroRangeRoutine();
        yield return new WaitForSeconds(RangeCheckInterval);
    }

    private void CheckAggroRangeRoutine()
    {
        targetPos = GameObject.Find("Player").transform.position;
        if (Vector3.Distance(targetPos, transform.position) <= AggroRadius)
        {
            isAggro = true;
        }
        if (Vector3.Distance(targetPos, transform.position) >= DeAggroRadius)
        {
            isAggro = false;
        }
    }

}
