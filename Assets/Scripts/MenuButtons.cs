using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuButtons : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
            Play();
        if (Input.GetKeyDown(KeyCode.JoystickButton1))
            Quit();   
    }

    public void Play(){
        SceneManager.LoadScene(levelSelect);
        Time.timeScale = 1f;
    }

    public void Quit(){
        Application.Quit();
    }
}
