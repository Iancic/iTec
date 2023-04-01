using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController2 : MonoBehaviour
{
    public static HealthController2 instance;
    public int current_health, max_health;

    void Awake() 
    {
        instance = this;
    }

    void Start()
    {
        current_health = max_health;
    }

    public void DealDamage2()
    {
        current_health -= 1;

        if (current_health <= 0)
        {
            current_health = 0;
            gameObject.SetActive(false);
        } 
        else 
        {
            PlayerController2.instance.knockBack();
        }
        UIController2.instance.UpdateHealthDisplay();
    }
}
