using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PaintManager : MonoBehaviour
{
    public GameObject pyoreaPrefab;
    public GameObject FollowUpCursor;
    public TextMeshProUGUI paintText;

    [SerializeField] private float aikaennen_kuin_tuhoutuu;


    public int maxPaint = 100;
    public int paint;

    private void Start()
    {
        paint = maxPaint;
    }

    void Update()
    {
        paintText.text = "Paint: " + paint;
        if (Input.GetMouseButton(0))
        {
            LuoPyorea();
        }
        
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
        yield return new WaitForSeconds(0.1f);
        paint += 1;
    }
}