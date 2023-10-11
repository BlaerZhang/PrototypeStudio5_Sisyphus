using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StayScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    public float stayTime;
    private float currentStayTime;
    private bool isGrounded;
    
    void Start()
    {
        stayTime = 0;
        currentStayTime = 0;
    }


    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        // print("Current: " + currentStayTime);
        if (isGrounded) currentStayTime += Time.deltaTime;
        if(currentStayTime > stayTime) score.text = "Sisyphus Once Kept The Boulder At The Top Of The Mountain For " + currentStayTime.ToString("F1") + " Seconds";
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (currentStayTime > stayTime && isGrounded)
        {
            stayTime = currentStayTime;
            UpdateScore();
        }

        currentStayTime = 0;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // print("grounded");
        if (collision.gameObject.CompareTag("Mountain"))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    void UpdateScore()
    {
        score.text = "Sisyphus Once Kept The Boulder At The Top Of The Mountain For " + stayTime.ToString("F1") + " Seconds";
    }
}
