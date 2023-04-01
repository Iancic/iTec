using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public string levelSelect;

    public GameObject pauseScreen;
    public bool paused;
    // Start is called before the first frame update
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
            }
        else
            {
            paused = true;
            pauseScreen.SetActive(true);
            }
    }

    public void Quit(){
        Application.Quit();
    }

    public void Menu(){
        SceneManager.LoadScene("Menu");
    }
}
