using UnityEngine;
using System.Collections;

public class SmallRockCollision : MonoBehaviour
{
    private bool hasHit = false;
    public PlayerController playerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (hasHit) return;
        hasHit = true;

        if (other.CompareTag("Power"))
        {
            playerController.SetPowerUp(true);
            Destroy(other.gameObject);
            
        }
        else
        {
            DetectCollision detect = other.GetComponent<DetectCollision>();
            if (detect != null)
            {
                detect.OnHitBySmallRock();
            }
        }
        Destroy(gameObject);
    }
}
