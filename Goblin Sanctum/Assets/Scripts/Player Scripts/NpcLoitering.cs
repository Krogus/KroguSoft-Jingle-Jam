using UnityEngine;
using System.Collections;

/// <summary>
/// Creates wandering behaviour for a CharacterController.
/// </summary>
[RequireComponent(typeof(CharacterController))]
public class NpcLoitering : MonoBehaviour
{
    public float speed = 5;
    public float directionChangeInterval = 1;
    public float walkDistance = 10;

    CharacterController controller;
    float heading;
    bool isColliding;
    Vector3 prevRotation;
    Vector3 startingPos;
    Vector3 targetRotation;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        startingPos = transform.position;
        // Set random initial rotation
        heading = 45 * Random.Range(0, 7);
        transform.eulerAngles = new Vector3(0, heading, 0);

        StartCoroutine(NewHeading());
    }

    void Update()
    {
        transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
        var forward = transform.TransformDirection(Vector3.forward);
        controller.SimpleMove(forward * speed);
        prevRotation = targetRotation;
    }

    /// <summary>
    /// Repeatedly calculates a new direction to move towards.
    /// Use this instead of MonoBehaviour.InvokeRepeating so that the interval can be changed at runtime.
    /// </summary>
    IEnumerator NewHeading()
    {
        while (true)
        {
            NewHeadingRoutine();
            yield return new WaitForSeconds(directionChangeInterval);
        }
    }

    /// <summary>
    /// Calculates a new direction to move towards.
    /// </summary>
    void NewHeadingRoutine()
    {
        heading = (heading + (45 * (1 - Random.Range(0, 2))) + 360) % 360;
        if (Vector3.Distance(transform.position, startingPos) <= walkDistance && !isColliding)
        {
            targetRotation = new Vector3(0, heading, 0);
        }
        else
        {
            //heading = the absolute value of the angle between the current position and the starting position, 
            heading = (((int)Vector3.SignedAngle(startingPos, transform.position, Vector3.up) / 45) * 45 + 360) % 360;
            targetRotation = new Vector3(0, heading, 0);
            isColliding = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isColliding = true;
        }

    }

}