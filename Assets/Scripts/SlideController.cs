using System.Linq;
using UnityEngine;

public class SlideController : MonoBehaviour
{
    public Transform[] Slides;
    private Transform _activeSlide;
    private void Awake()
    {
        Slides = transform.Cast<Transform>().ToArray();
    }

    private void Start()
    {
        _activeSlide = Slides[0];
        _activeSlide.gameObject.SetActive(true);
        for (var i = 1; i < Slides.Length; i++)
        {
            Slides[i].gameObject.SetActive(false);
        }
    }
    
    void Update()
    {
        for (var i = (int)KeyCode.F1; i <= (int)KeyCode.F12; i++)
        {
            if (!Input.GetKeyDown((KeyCode)i)) continue;
            
            OpenSlide(i - (int)KeyCode.F1);
            return;
        }
    }

    private void OpenSlide(int id)
    {
        if (id >= Slides.Length) return;
        
        _activeSlide.gameObject.SetActive(false);
        _activeSlide = Slides[id];
        _activeSlide.gameObject.SetActive(true);
    }
}
