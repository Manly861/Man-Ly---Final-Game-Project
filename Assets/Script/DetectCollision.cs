using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager;
    public LiveManager liveManager;
    public int pointValue; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        liveManager = FindObjectOfType<LiveManager>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHitBySmallRock()
    {
        if (CompareTag("Obstacle"))
        {
            scoreManager.UpdateScore(pointValue);
        }
        else if (CompareTag("Animal"))
        {
            liveManager.UpdateLiveText(-1);
        }
        Destroy(gameObject);

        
    }   
    
}