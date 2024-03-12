using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public int maxHealth;
    public TextMeshProUGUI healthText;
    public float invincibilityTimer = 1.0f;
    public bool canTakeDamage = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            if(canTakeDamage)
            {
                TakeDamage(10);
            }
            
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            HealDamage(15);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthText.text = "Health: " + health;

        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        canTakeDamage = false;
        StartCoroutine(InvincibilityCo());
    }

    public void HealDamage(int healing)
    {
        health += healing;

        if(health >= maxHealth)
        {
            health = maxHealth;
        }
        healthText.text = "Health: " + health;
    }

    IEnumerator InvincibilityCo()
    {
        Debug.Log("Can no longer take damage");
        yield return new WaitForSeconds(invincibilityTimer);
        canTakeDamage = true;
        Debug.Log("Can take damage again!");
        
    }

}
