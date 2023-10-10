using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuoPyoreaObjekti : MonoBehaviour
{
    public GameObject pyoreaPrefab;
    public GameObject FollowUpCursor;

    [SerializeField] private float aikaennen_kuin_tuhoutuu;
    

    private bool hiiriPohjassa = false;

    void Update()
    {
        //Oon IF & Else GOD

        if (Input.GetMouseButtonDown(0))
        {
            hiiriPohjassa = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            hiiriPohjassa = false;
        }

        if (hiiriPohjassa)
        {
            LuoPyorea();
        }
    }

    void LuoPyorea()
    {
        GameObject uusiPyorea = Instantiate(pyoreaPrefab, FollowUpCursor.transform.position, Quaternion.identity);

        Destroy(uusiPyorea, aikaennen_kuin_tuhoutuu);
    }
}