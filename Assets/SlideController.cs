using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideController : MonoBehaviour
{
    public GameObject[] Slides;
    public GameObject ActiveSlide;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            OpenSlide(1);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            OpenSlide(2);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            OpenSlide(3);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            OpenSlide(4);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            OpenSlide(5);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            OpenSlide(6);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            OpenSlide(7);
        }
    }

    private void OpenSlide(int id)
    {
        ActiveSlide.SetActive(false);
        ActiveSlide = Slides[id];
        ActiveSlide.SetActive(true);
    }
}
