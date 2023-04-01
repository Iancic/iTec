using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript2 : MonoBehaviour
{
    public Transform player1;
    private float distance_x;

    void Update()
    {
        distance_x = this.transform.position.x - player1.transform.position.x;
        if (distance_x < 0)
        distance_x = -distance_x;

        if (Input.GetButtonDown("Fire_2"))
        {
            if (distance_x < 1.5f)
            HealthController.instance.DealDamage();
        }
    }
}
