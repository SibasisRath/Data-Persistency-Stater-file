using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class StartScript : MonoBehaviour
{
    [SerializeField] GameObject message;
    [SerializeField] TMP_InputField tMP;
    private void Start()
    {
        message.SetActive(false);
    }
    public void OnStart()
    {
        if (tMP.text == string.Empty)
        {
            message.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("main");
        }
        
    }
}
