using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.UI;

public class PlayerNameScript : MonoBehaviour
{
    private bool isFilled;
    private string playerName;
    [SerializeField] TMP_InputField _InputField;

    public bool IsFilled { get => isFilled; set => isFilled = value; }
    public string PlayerName { get => playerName; set => playerName = value; }

    private void Start()
    {
        IsFilled = false;
        PlayerName = string.Empty;
    }

    public void GetPlayeName()
    {
        PlayerName = _InputField.text;
        Debug.Log(playerName);
        GameObject.Find("PlayerClass").GetComponent<PlayerClass>().PlayerName = playerName;
    }


}
