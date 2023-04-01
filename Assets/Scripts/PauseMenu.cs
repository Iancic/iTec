using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu instance;
    public string levelSelect;

    public GameObject pauseScreen;
    public bool paused;
    // Start is called before the first frame update
    void Awake(){
        instance = this;
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton7))
            PauseUnpause();
        if (paused)
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton0))
                Menu();
        } 
    }


    public void PauseUnpause(){
        if (paused)
            {
            paused = false;
            pauseScreen.SetActive(false);
            Time.timeScale=1f;
            }
        else
            {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale=0f;
            }
    }

    public void Quit(){
        Application.Quit();
    }

    public void Menu(){
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
}
