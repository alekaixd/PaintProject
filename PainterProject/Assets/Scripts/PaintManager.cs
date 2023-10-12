using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PaintManager : MonoBehaviour
{
    public GameObject[] PaintPrefab;
    public GameObject FollowUpCursor;

    //public Text teksti;


    //public Slider slider;

    [SerializeField] private float aikaennen_kuin_tuhoutuu;
    private bool isRegenerating;
    private bool spawningPaint;
    private bool startFading;


    public float maxPaint = 40;
    public float paint;

    private void Start()
    {
        paint = maxPaint;
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            LuoPyorea();
        }
        else if (isRegenerating == false)
        {
            StartCoroutine(Regenerate());
        }
        //slider.value = paint; Slider kuollut kouluampumisessa. Slider saa valtion j�rjest�m�t hautajaiset

    }

    void LuoPyorea()
    {
        if (paint > 0 && spawningPaint == false)
        {
            StartCoroutine(spawnPaint());
        }
    }

    private IEnumerator spawnPaint()
    {
        spawningPaint = true;
        GameObject uusiPyorea = Instantiate(PaintPrefab[Random.Range(0, PaintPrefab.Length)], FollowUpCursor.transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
        paint -= 1;
        yield return new WaitForSeconds(.01f);
        spawningPaint = false;
    }

    private IEnumerator Regenerate()
    {
        isRegenerating = true;
        yield return new WaitForSeconds(0.1f);
        if (paint < maxPaint)
        {
            paint += 2;
            if (paint > maxPaint)
            {
                paint = maxPaint;
            }
        }
        isRegenerating = false;
    }
}