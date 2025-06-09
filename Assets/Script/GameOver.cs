using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public PlayTheSound playTheSound;
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
    }
}
