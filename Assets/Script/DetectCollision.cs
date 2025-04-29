using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private bool hasScored = false;
    private int scoreValuable = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (hasScored) return;
        hasScored = true;

        UIManager.Instance.UpdateScore(scoreValuable);
        Destroy(other.gameObject);
        Destroy(gameObject);
        
    }
}