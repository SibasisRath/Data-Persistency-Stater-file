using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenuScreen : MonoBehaviour
{
    public void BackToMainManu()
    {
        SceneManager.LoadScene("Menu");
    }
}
