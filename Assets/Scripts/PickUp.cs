using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool isHeal, isSnow;

    private bool isCollected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !isCollected)
        {
            if(isHeal)
            {
                if(HealthController.instance.current_health != HealthController.instance.max_health) //|| HealthController2.instance.current_health != HealthController2.instance.max_health )
                {    
                    HealthController.instance.HealPlayer();
                    isCollected = true;
                    Audio.instance.PlaySFX(4);
                    Destroy(gameObject);
                }
            }

            if(isSnow)
            {
                SnowTrigger.instance.SnowsStart();
                isCollected = true;
                Audio.instance.PlaySFX(4);
                Destroy(gameObject);
            }
        }
    }
}
