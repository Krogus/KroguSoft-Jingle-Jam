using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject[] targets;
    

   


    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.name == "Player")
        {
            foreach (GameObject Player in targets)
            {
                Player.SendMessage("Agro");
            }
        }
        
        
       
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            foreach (GameObject target in targets)
            {
                target.SendMessage("DeAgro");
            }
        }
        
    }

    

}
