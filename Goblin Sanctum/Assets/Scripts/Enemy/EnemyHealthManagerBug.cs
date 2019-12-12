using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManagerBug : MonoBehaviour
{

    public int health;

    public int currentHealth;

    public AudioClip hurt;

    AudioSource audioSource;

    public DeadBug deadBug;

    public Transform deathPoint;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            DeadBug newCorpse = Instantiate(deadBug, deathPoint.position, deathPoint.rotation);
            audioSource.PlayOneShot(hurt, .1f);
            Destroy(gameObject);
        }
    }

    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
        audioSource.PlayOneShot(hurt, .1f);
    }



}
