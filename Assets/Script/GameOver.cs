using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public PlayTheSound playTheSound;
    public Button restartButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        playTheSound = FindObjectOfType<PlayTheSound>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameOverActive()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0.0f;
        playTheSound.backGroundAudio.Stop();
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1.0f; 
    }

}
