using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject pauseScreen;
    private bool isPaused;
    private void Start()
    {
        isPaused = false;
        pauseScreen.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            WhenPaused();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            WhenResumed();
        }
    }

    public void WhenResumed()
    {
        Time.timeScale = 1;
        isPaused = false;
        pauseScreen.SetActive(false);
    }

    private void WhenPaused()
    {
        Time.timeScale = 0;
        isPaused = true;
        pauseScreen.SetActive(true);
    }
}
