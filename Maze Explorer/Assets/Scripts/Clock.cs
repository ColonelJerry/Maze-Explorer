using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    public TextMeshProUGUI clockText;
    private float startTime;
    private bool finnished = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (finnished)
            return;

        float t = startTime += Time.deltaTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");

        clockText.text = "Time: " + minutes + "Min " + seconds + "Sec";
    }

    public void Finnish()
    {
        finnished = true;
    }
}
