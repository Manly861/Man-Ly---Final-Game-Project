using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
   public MissingRockCounting missingRockCounting;
     private float topBound = 30;
     private float lowerBound = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        missingRockCounting = FindObjectOfType<MissingRockCounting>();
    }

    // Update is called once per frame
    void Update()
    {
      if (transform.position.z > topBound)
      {
         Destroy(gameObject);

      }
      else if (transform.position.z < lowerBound)
      {
         if (CompareTag("Obstacle") || CompareTag("Medium Obstacle") || CompareTag("Huge Obstacle"))
         {
            missingRockCounting.UpdateMissingText(1);
            if (missingRockCounting.amount == 10)
            {
               Time.timeScale = 0.0f;
            }
         }
         Destroy(gameObject);
         
      }
    }
}
