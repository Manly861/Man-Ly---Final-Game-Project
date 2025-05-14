using UnityEngine;
using TMPro;

public class LiveManager : MonoBehaviour
{
    public TextMeshProUGUI liveText;
    private int live;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        live = 3;
        liveText.text = "Live: "  +live;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
