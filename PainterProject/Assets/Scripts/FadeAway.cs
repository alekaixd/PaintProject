using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAway : MonoBehaviour
{
    public bool canFade = false;
    public float beforeFadeSeconds = 1.0f; 
    private float i = 1.0f;
    private SpriteRenderer spriteRenderer;
    private Material material;

    private void Start()
    {
        material = gameObject.GetComponentInChildren<Renderer>().material;
        spriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();
        StartCoroutine(WaitBeforeFade(beforeFadeSeconds)); 
        Debug.Log(material.color);
    }
    void Update()
    {
        if (canFade == true)
        {
            Debug.Log("Hello World");
            i -= .5f * Time.deltaTime;
            material.color = new Color(material.color.r, material.color.g, material.color.b, i);
            
            
            Debug.Log(i);
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, i);

            if (i <= 0)
            {
                Destroy(gameObject);
            }
            
        }
    }

    private IEnumerator WaitBeforeFade(float seconds)
    {
        
        yield return new WaitForSeconds(seconds);
        canFade = true;
    }
}
