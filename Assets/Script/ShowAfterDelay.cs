using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAfterDelay : MonoBehaviour
{
    public float delayInSeconds = 5f;
    public float fadeRate = 0.25f;

    public GameObject windShieldGroup;
    private CanvasGroup canvasGroup;

    private float startTimer;
    private float fadeoutTimer;
    float timer = 0f;
    void Start()
    {
        windShieldGroup = GameObject.Find("WindshieldGroup");
        canvasGroup = windShieldGroup.GetComponent<CanvasGroup>();
        windShieldGroup.SetActive(false);
        canvasGroup.alpha = 0f;


        startTimer = Time.time + delayInSeconds;
        fadeoutTimer = fadeRate;

    }
    void Update()
    {
        // time to fade out
        if (Time.time >= startTimer)
        {
                timer += Time.deltaTime;

            // is fade out complete?
            if (timer >= 0.1f)
            {
                windShieldGroup.SetActive(true);
                canvasGroup.alpha = timer / 0.9f;
            }
        }
    }
}
