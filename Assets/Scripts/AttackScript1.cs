using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript1 : MonoBehaviour
{
    public Transform player2;
    private float distance_x;

    void Update()
    {
        distance_x = this.transform.position.x - player2.transform.position.x;
        if (distance_x < 0)
        distance_x = -distance_x;

        if (Input.GetButtonDown("Fire_1"))
        {
            if (distance_x < 1.5f)
            HealthController2.instance.DealDamage2();
        }
    }
}
