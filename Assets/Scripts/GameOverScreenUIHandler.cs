using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreenUIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI gameOverText;
    [SerializeField] TextMeshProUGUI congratulationText;
    [SerializeField] TextMeshProUGUI yourScoreText;
    [SerializeField] TextMeshProUGUI bestScoreText;
    private GAmeOverLogicScript gAme;

    private GameObject player;
    private ISaveable saveable;

    private void Awake()
    {
        gameOverText.enabled = false;
        congratulationText.enabled = false;
        yourScoreText.enabled = false;
        bestScoreText.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        gAme = gameObject.GetComponent<GAmeOverLogicScript>();
        player = GameObject.Find("PlayerClass");
        saveable = player.GetComponent<ISaveable>();
        yourScoreText.enabled = true;
        if (gAme.IsHighestScore)
        {
            congratulationText.enabled = true;
            yourScoreText.text = "Your Score: " + saveable.GetPlayerScore();
        }
        else
        {
            gameOverText.enabled = true;
            bestScoreText.enabled = true;

            yourScoreText.text = "Your Score: " + saveable.GetPlayerScore();
            bestScoreText.text = "Best Score: " + gAme.ReturnBestPlayerData().playerScore;
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Main");
    }
}
