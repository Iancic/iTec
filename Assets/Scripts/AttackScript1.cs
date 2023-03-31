using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript1 : MonoBehaviour
{
    public Transform player2;
    public float distance_x;

    void Update()
    {
        distance_x = this.transform.position.x - player2.transform.position.x;
        if (distance_x < 0)
        distance_x = -distance_x;

        if (Input.GetButtonDown("Fire_1"))
        {
            if (distance_x < 2)
            HealthController2.instance.DealDamage2();
        }
    }
}
