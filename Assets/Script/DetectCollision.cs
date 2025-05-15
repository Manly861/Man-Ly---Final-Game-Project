using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager;
    public LiveManager liveManager;
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
            scoreManager.UpdateScore(10);
        }
        else if (CompareTag("Animal"))
        {
            liveManager.UpdateLiveText(-1);
        }
        Destroy(gameObject);

        
    }   
    
}