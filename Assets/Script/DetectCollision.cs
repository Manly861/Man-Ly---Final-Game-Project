using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private ScoreManager scoreManager;
    private bool getScore = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GetComponent<ScoreManager>();
    }
    // Update is called once per frame
    void Update()
    {
    if (getScore)
            {
                // Update score
                scoreManager.UpdateScore(5);
                getScore = false;
            }
    }
    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
        getScore = true;
    }
    
}