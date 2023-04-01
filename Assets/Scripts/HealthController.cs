using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public static HealthController instance;
    public int current_health, max_health;

    void Awake() 
    {
        instance = this;
    }

    void Start()
    {
        current_health = max_health;
    }

    public void DealDamage()
    {
        current_health -= 1;

        if (current_health <= 0)
        {
            current_health = 0;
            gameObject.SetActive(false);
        } 
        else 
        {
            PlayerController.instance.knockBack();
        }
        UIController.instance.UpdateHealthDisplay();
        
    }
}
