using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcDialogue2 : MonoBehaviour
{
    //public GameObject[] dialoguePanels;
    public GameObject nephewDialogue;

    private void Start()
    {
        nephewDialogue = GameObject.Find("NephewText");
        nephewDialogue.gameObject.SetActive(false);
    }

    [SerializeField] private GameObject[] targets;
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == "Player")
        {
            foreach (GameObject Player in targets)
            {
                nephewDialogue.gameObject.SetActive(true);
            }
        }



    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            foreach (GameObject target in targets)
            {
                nephewDialogue.gameObject.SetActive(false);
            }
        }

    }
}
