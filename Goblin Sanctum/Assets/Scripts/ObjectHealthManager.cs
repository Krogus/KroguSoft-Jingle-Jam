﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHealthManager : MonoBehaviour
{

    public int health;

    public int currentHealth;



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = health;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {       
            Destroy(gameObject);
        }
    }

    public void HurtEnemy(int damage)
    {
        currentHealth -= damage;
    }



}
