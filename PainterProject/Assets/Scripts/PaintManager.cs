using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PaintManager : MonoBehaviour
{
    public GameObject pyoreaPrefab;
    public GameObject FollowUpCursor;

    //public Text teksti;


    //public Slider slider;

    [SerializeField] private float aikaennen_kuin_tuhoutuu;


    public int maxPaint = 100;
    public int paint;

    private void Start()
    {
        paint = maxPaint;
        StartCoroutine(StartRegenerating());
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            LuoPyorea();
        }


        //slider.value = paint; Slider kuollut kouluampumisessa. Slider saa valtion järjestämät hautajaiset

    }

    void LuoPyorea()
    {
        if (paint > 0)
        {
            GameObject uusiPyorea = Instantiate(pyoreaPrefab, FollowUpCursor.transform.position, Quaternion.identity);

            Destroy(uusiPyorea, aikaennen_kuin_tuhoutuu);

            paint -= 1;
        }
    }

    private IEnumerator StartRegenerating()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            if (paint < maxPaint)
            {
                paint += 1;
            }
        }
    }
}