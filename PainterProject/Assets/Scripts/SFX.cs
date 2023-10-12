using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource Jump;
    /*
        public void PlayCollect1()
        {
            Starcollect1.Play();
        }
        public void PlayCollect2()
        {
            Starcollect2.Play();
        }
        public void PlayCollect3()
        {
            Starcollect3.Play();
        }*/
    public void PlayJump()
    {
        Jump.Play();
    }
}
