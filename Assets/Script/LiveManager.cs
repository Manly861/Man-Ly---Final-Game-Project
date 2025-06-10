using UnityEngine;
using TMPro;

public class LiveManager : MonoBehaviour
{
    public TextMeshProUGUI liveText;
    private int live;
    public GameOver gameOver;
    public GameObject restartButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        live = 3;
        UpdateLiveText(0);
        gameOver = GetComponent<GameOver>();
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
            gameOver.GameOverActive();
        }
    }

}
