using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public static Respawn instance;
    // Start is called before the first frame update
    public bool over;
    public GameObject overScreen;

    void Awake(){
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HealthController.instance.current_health <= 0 || HealthController2.instance.current_health <= 0)
        {
            over = true;
            overScreen.SetActive(true);
        }
        if (over)
        {
            if(Input.GetKeyDown(KeyCode.JoystickButton3))
            {
                SceneManager.LoadScene("Map1");
            }
            if(Input.GetKeyDown(KeyCode.JoystickButton1))
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
