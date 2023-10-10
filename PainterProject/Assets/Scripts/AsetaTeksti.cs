using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class AsetaTeksti : MonoBehaviour
{
    public Text tekstiKomponentti; 
    //public int maxpaint = 100;

    public PaintManager paintManager;

    public Slider slider;

    void Update()
    {
        
        tekstiKomponentti.text = paintManager.paint.ToString();

        slider.value = paintManager.paint;
    }
}