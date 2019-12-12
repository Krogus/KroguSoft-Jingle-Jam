using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDialogue : MonoBehaviour
{
    //public GameObject[] dialoguePanels;
    public GameObject farmerDialogue;

    private void Start()
    {
        farmerDialogue = GameObject.Find("FarmerText");
        farmerDialogue.gameObject.SetActive(false);
    }

    [SerializeField] private GameObject[] targets;
    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.name == "Player")
        {
            foreach (GameObject Player in targets)
            {
                farmerDialogue.gameObject.SetActive(true);
            }
        }



    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            foreach (GameObject target in targets)
            {
                farmerDialogue.gameObject.SetActive(false);
            }
        }

    }
}
