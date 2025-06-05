using UnityEngine;

public class MoveForward : MonoBehaviour
{  
    private float speed = 15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CompareTag("Ground"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
        
    }
}
