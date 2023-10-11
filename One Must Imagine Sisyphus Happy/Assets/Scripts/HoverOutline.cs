using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoverOutline : MonoBehaviour
{
    private SpriteRenderer boulder;
    private bool isSelected;
    private bool isClicked;
    public CinemachineVirtualCamera boulderCam;

    void Start()
    {
        boulder = GetComponent<SpriteRenderer>();
        isSelected = false;
        isClicked = false;
    }
    
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit)
        {
            if (hit.transform.CompareTag("Player"))
            {
                if (Input.GetMouseButtonDown(0) && !isClicked)
                {
                    isClicked = true;
                    boulderCam.enabled = true;
                    Invoke("LoadNextScene", 2);
                }
                if(!isSelected)  boulder.DOFade(0, 0.5f).OnStart((() => { isSelected = true; }));
            }
            else if (!isClicked)
            {
                boulder.DOFade(1, 0.5f).OnStart((() => { isSelected = false; }));
            }
        }
        
        if (!hit)
        {
            if(isSelected && !isClicked) boulder.DOFade(1, 0.5f).OnStart((() => { isSelected = false; }));
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % 3);
    }
}
