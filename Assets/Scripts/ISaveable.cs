using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISaveable 
{
    public void SetPlayerName(string playerName);
    public string GetPlayerName();
    public void SetPlayerScore(int playerScore);
    public int GetPlayerScore();
}
