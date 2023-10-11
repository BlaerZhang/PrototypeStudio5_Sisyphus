using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PushScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Mountain"))
        {
            UpdateScore();
        }
    }

    void UpdateScore()
    {
        score.text = "Sisyphus Once Pushed The Boulder Up To " + transform.position.y.ToString("F1") + "m";
    }
}
