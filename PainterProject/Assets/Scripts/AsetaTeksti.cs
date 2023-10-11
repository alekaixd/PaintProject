using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class AsetaTeksti : MonoBehaviour
{
    public Text tekstiKomponentti; 

    public PaintManager paintManager;

    public Slider slider;

    void Update()
    {
        
        tekstiKomponentti.text = paintManager.paint.ToString();
        slider.value = (paintManager.paint / paintManager.maxPaint) * 100;
    }
}