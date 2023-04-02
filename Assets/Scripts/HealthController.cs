using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public static HealthController instance;
    public int current_health, max_health;

    public float invincibleL;
    private float invincibleC;

    void Awake() 
    {
        instance = this;
    }

    void Start()
    {
        current_health = max_health;
    }

    void Update()
    {
        if (invincibleC > 0)
        {
        invincibleC -= Time.deltaTime;}
    }

    public void DealDamage()
    {
        if (invincibleC <=0)
        {
        current_health -= 1;

        if (current_health <= 0)
        {
            current_health = 0;
            Audio.instance.PlaySFX(3);
            gameObject.SetActive(false);
        } else
        {
            Audio.instance.PlaySFX(1);
            invincibleC = invincibleL;
            PlayerController.instance.knock();
        }
        UIController.instance.UpdateHealthDisplay();
        }
    }

    public void Fall()
    {
        current_health = 0;
        Audio.instance.PlaySFX(3);
        gameObject.SetActive(false);
        UIController.instance.UpdateHealthDisplay();
    }

    public void HealPlayer()
    {
        current_health++;
        if (current_health > max_health)
            current_health = max_health;
        UIController.instance.UpdateHealthDisplay();
    }
}
