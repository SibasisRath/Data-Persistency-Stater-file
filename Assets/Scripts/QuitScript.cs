using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    public void Exit()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit(); // original code to quit Unity player
    #endif
    }
}
