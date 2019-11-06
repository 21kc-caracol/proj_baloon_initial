using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;

    public GameObject pauseButtonUI;
    public GameObject resumeButtonUI;

    // Start is called before the first frame update
    void Start()
    {
        resumeButtonUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Pause()
    {
        //Now paused, show Resume button, Hide Pause button
        pauseButtonUI.SetActive(false);
        resumeButtonUI.SetActive(true);
        //stop the scene
        Time.timeScale = 0f;
        IsPaused = true;
    }

    public void Resume()
    {
        //Now Resumed, hide Resume button, show Pause button
        pauseButtonUI.SetActive(true);
        resumeButtonUI.SetActive(false);
        //regular scene
        Time.timeScale = 1f;
        IsPaused = false;
    }
}
