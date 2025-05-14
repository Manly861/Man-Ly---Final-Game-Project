using UnityEngine;

public class SmallRockCollision : MonoBehaviour
{
    private bool hasHit = false;
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
        if (hasHit) return;
        if (other.CompareTag("Obstacle"))
            {
                DetectCollision detect = other.GetComponent<DetectCollision>();
                if (detect != null)
                {
                    detect.OnHitByBullet();  // chỉ 1 obstacle được xử lý
                }
                hasHit = true;
                Destroy(gameObject);
            }
    }
}
