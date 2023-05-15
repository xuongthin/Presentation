using System.Linq;
using UnityEngine;

public class SubSlideController : MonoBehaviour
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
        for (var i = (int)KeyCode.Alpha1; i <= (int)KeyCode.Alpha9; i++)
        {
            if (!Input.GetKeyDown((KeyCode)i)) continue;
            
            OpenSubSlide(i - (int)KeyCode.Alpha1);
            return;
        }
    }

    private void OpenSubSlide(int id)
    {
        if (id >= Slides.Length) return;
        
        _activeSlide.gameObject.SetActive(false);
        _activeSlide = Slides[id];
        _activeSlide.gameObject.SetActive(true);
    }
}
