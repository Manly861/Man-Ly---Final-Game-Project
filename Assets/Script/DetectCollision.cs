using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHitByBullet()
    {
        scoreManager.UpdateScore(10);
        Destroy(gameObject); // phá huỷ obstacle
    }
    
}