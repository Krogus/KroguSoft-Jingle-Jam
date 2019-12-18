using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAggro : MonoBehaviour
{

    public float RangeCheckInterval = 1;
    public float AggroRadius = 4;
    public float DeAggroRadius = 6;
    public float MoveSpeed = 1;
    public float attackRange = .5f;
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
            transform.eulerAngles = new Vector3(0, ((int)transform.eulerAngles.y / 45) * 45, 0);
            if (Vector3.Distance(targetPos, transform.position) >= attackRange)
            {
                float step = MoveSpeed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, targetPos, step);
            }
        }
    }

    IEnumerator CheckAggroRange()
    {
        while (true)
        {
            CheckAggroRangeRoutine();
            yield return new WaitForSeconds(RangeCheckInterval);
        }
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
