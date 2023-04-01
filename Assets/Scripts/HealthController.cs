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

    void Update()
    {
        if (invincibleC > 0)
        {
        invincibleC -= Time.deltaTime;}
    }

    void Start()
    {
        current_health = max_health;
    }

    public void DealDamage()
    {
        if (invincibleC <=0)
        {
        current_health -= 1;

        if (current_health <= 0)
        {
            current_health = 0;
            gameObject.SetActive(false);
        } else
        {
            invincibleC = invincibleL;
        }
        UIController.instance.UpdateHealthDisplay();
        }
    }
}
