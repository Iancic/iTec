using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuButtons : MonoBehaviour
{
    public string levelSelect1, levelSelect2, levelSelect3;
    public GameObject pauseScreen;
    public bool paused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton2))
            Play3();
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
            Play();
        if (Input.GetKeyDown(KeyCode.JoystickButton3))
            Play2();
        if (Input.GetKeyDown(KeyCode.JoystickButton1))
            Quit();   
    }

    public void Play(){
        SceneManager.LoadScene(levelSelect1);
        Time.timeScale = 1f;
    }

     public void Play2(){
        SceneManager.LoadScene(levelSelect2);
        Time.timeScale = 1f;
    }

    public void Play3(){
        SceneManager.LoadScene(levelSelect3);
        Time.timeScale = 1f;
    }

    public void Quit(){
        Application.Quit();
    }
}
