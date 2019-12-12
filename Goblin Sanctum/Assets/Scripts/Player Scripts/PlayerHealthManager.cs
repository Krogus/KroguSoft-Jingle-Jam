using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public int startingHealth;
    private int currentHealth;

    // try re-using this to show damage on the sprite? {
    public float flashLength;
    private float flashCounter;

    private Renderer rend;
    private Color storedColor;
    // }

    public Text countHealth;

    public Font NDStyle;

    public Font gothic;

    public Text flavourStuff;

    public Font bigTitles;

    public Text names;





    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;

        //rend = GetComponent<Renderer>();
        //storedColor = rend.material.GetColor("_Color");
        SetHealthText();


        countHealth = GetComponent<Text>();
        //countHealth.font = NDStyle;
        //flavourStuff.font = gothic;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
        /*
        if(flashCounter > 0)
        {
            flashCounter -= Time.deltaTime;
            if(flashCounter <= 0)
            {
                rend.material.SetColor("_Color", storedColor);
            }
        }
        */
    }

    public void HurtPlayer(int damageAmount)
    {
        currentHealth -= damageAmount;
        //flashCounter = flashLength;
        //rend.material.SetColor("_Color", Color.white);
        SetHealthText();
    }

    public void SetHealthText()
    {
        //countHealth.text = "Health: " + currentHealth.ToString();
    }

    void OnGUI()
    {
        //HEALTH
        GUIStyle playerHealth = new GUIStyle(GUI.skin.label);
        playerHealth.fontSize = 60;
        playerHealth.font = NDStyle;
        GUI.Label(new Rect(50, 75, 500, 500), "HEALTH: " + currentHealth.ToString(), playerHealth);
        //NAME
        GUIStyle flavourStuff = new GUIStyle(GUI.skin.label);
        flavourStuff.font = gothic;
        flavourStuff.fontSize = 30;
        GUI.Label(new Rect(105, 360, 750, 750), "Name", flavourStuff);

        GUIStyle titles = new GUIStyle(GUI.skin.label);
        titles.fontSize = 40;
        titles.font = bigTitles;
        GUI.Label(new Rect(45, 395, 750, 750), "DemoPlayer", titles);
        //CHAR NAME

        GUI.Label(new Rect(90, 480, 750, 750), "Location", flavourStuff);
        GUI.Label(new Rect(36, 515, 750, 750), "Demo Village", titles);

        GUI.Label(new Rect(70, 600, 750, 750), "Temperature", flavourStuff);
        GUI.Label(new Rect(105, 635, 750, 750), "37°C", titles);






    }




}
