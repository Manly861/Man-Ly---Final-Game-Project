using UnityEngine;
using TMPro;

public class LiveManager : MonoBehaviour
{
    public TextMeshProUGUI liveText;
    public PlayTheSound playTheSound;
    private int live;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        live = 3;
        UpdateLiveText(0);
        playTheSound = GameObject.Find("Ground").GetComponent<PlayTheSound>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateLiveText(int Minuslive)
    {
        live += Minuslive;
        liveText.text = "Live: " + live;
        if (live == 0)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        Debug.Log("Game Over!");
        Time.timeScale = 0.0f;
        playTheSound.backGroundAudio.Stop();
    }


}
