using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public Image heart1, heart2, heart3, heart4, heart5;

    public Sprite heartFull, heartEmpty;

    public void Awake(){
        instance = this;
    }

    public void UpdateHealthDisplay(){
        switch(HealthController.instance.current_health)
        {
            case 0:
                heart1.sprite = heartEmpty;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                heart4.sprite = heartEmpty;
                heart5.sprite = heartEmpty;
                break;
            case 1:
                heart1.sprite = heartFull;
                heart2.sprite = heartEmpty;
                heart3.sprite = heartEmpty;
                heart4.sprite = heartEmpty;
                heart5.sprite = heartEmpty;
                break;
            case 2:
                heart1.sprite = heartFull;
                heart2.sprite = heartFull;
                heart3.sprite = heartEmpty;
                heart4.sprite = heartEmpty;
                heart5.sprite = heartEmpty;
                break;
            case 3:
                heart1.sprite = heartFull;
                heart2.sprite = heartFull;
                heart3.sprite = heartFull;
                heart4.sprite = heartEmpty;
                heart5.sprite = heartEmpty;
                break;
            case 4:
                heart1.sprite = heartFull;
                heart2.sprite = heartFull;
                heart3.sprite = heartFull;
                heart4.sprite = heartFull;
                heart5.sprite = heartEmpty;
                break;
            case 5:
                heart1.sprite = heartFull;
                heart2.sprite = heartFull;
                heart3.sprite = heartFull;
                heart4.sprite = heartFull;
                heart5.sprite = heartFull;
                break;
            

        }
    }
}
