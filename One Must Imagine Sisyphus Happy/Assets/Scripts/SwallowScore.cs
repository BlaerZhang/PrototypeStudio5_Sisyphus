using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SwallowScore : MonoBehaviour
{
    public EdgeCollider2D face;
    public CircleCollider2D faceTrigger;
    public TextMeshProUGUI scoreText;
    private Rigidbody2D rb2D;
    private float currentStayTime;
    public int score;
    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        currentStayTime = 0;
        score = 0;
    }
    
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other == faceTrigger)
        {
            if (rb2D.velocity.magnitude < 0.1)
            {
                currentStayTime += Time.deltaTime;
            }

            if (currentStayTime > 2) 
            {
                currentStayTime = 0;
                score++;
                UpdateScore();
                face.enabled = false;
                faceTrigger.enabled = false;
                Invoke("ResetCollider", 1);
            }
        } 
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        
    }

    void ResetCollider()
    {
        face.enabled = true;
        faceTrigger.enabled = true;
    }

    private void UpdateScore()
    {
        switch (score)
        {
            case 0:
                scoreText.text = "Sisyphus Once Imagined Himself Swallowing The Boulder For " + score +
                                 " Time Just For Fun";
                break;
            case 1:
                scoreText.text = "Sisyphus Once Imagined Himself Swallowing The Boulder For " + score +
                                 " Time Just For Fun\n" + "He Must Have Felt The Joy Of It Because";
                break;
            case 2:
                scoreText.text = "Sisyphus Once Imagined Himself Swallowing The Boulder For " + score +
                                 " Times Just For Fun\n" + "He Must Have Felt The Joy Of It Because\n" +
                                 '"' + "One Must Imagine Sisyphus Happy" + '"';
                break;
            case 3:
                scoreText.text = "Sisyphus Once Imagined Himself Swallowing The Boulder For " + score +
                                 " Times Just For Fun\n" + "He Must Have Felt The Joy Of It Because\n" +
                                 '"' + "One Must Imagine Sisyphus Happy" + '"' + "\nEven Himself";
                break;
            default:
                scoreText.text = "Sisyphus Once Imagined Himself Swallowing The Boulder For " + score +
                                 " Times Just For Fun\n" + "He Must Have Felt The Joy Of It Because\n" +
                                 '"' + "One Must Imagine Sisyphus Happy" + '"' + "\nEven Himself";
                break;
        }
    }
}
