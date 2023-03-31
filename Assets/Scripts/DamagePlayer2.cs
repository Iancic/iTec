using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player2"))
        {
            HealthController2.instance.DealDamage2();
        }
    }
}
