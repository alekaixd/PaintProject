using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class AsetaTeksti : MonoBehaviour
{
    public PaintManager paintManager;

    public Slider slider;

    void Update()
    {
        
        slider.value = (paintManager.paint / paintManager.maxPaint) * 100;
    }
}