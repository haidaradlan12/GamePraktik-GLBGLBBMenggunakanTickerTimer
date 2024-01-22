using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButton : MonoBehaviour
{
    public GameObject[] bendaGLB;
    public GameObject[] tampilGLB;
    public GameObject[] bendaGLBB;
    public GameObject[] tampilGLBB;
    // gambar kabel
    public GameObject TTGLB, PSGLB, TTGLBB, PSGLBB;
    public GameObject tampilkabelGLB, tampilkabelGLBB;

    private void Update()
    {
        for (int i=0; i < bendaGLB.Length; i++)
        {
            if (bendaGLB[i].gameObject.activeSelf)
            {
                for (int j=0; j<tampilGLB.Length; j++)
                {
                    tampilGLB[j].SetActive(true);
                }
            }
            else
            {
                for (int j = 0; j < tampilGLB.Length; j++)
                {
                    tampilGLB[j].SetActive(false);
                }
            }
        }
        
        for (int i = 0; i < bendaGLBB.Length; i++)
        {
            if (bendaGLBB[i].gameObject.activeSelf)
            {
                for (int j = 0; j < tampilGLBB.Length; j++)
                {
                    tampilGLBB[j].SetActive(true);
                }
            }
            else
            {
                for (int j = 0; j < tampilGLBB.Length; j++)
                {
                    tampilGLBB[j].SetActive(false);
                }
            }
        }

        if (TTGLB.gameObject.activeSelf && PSGLB.gameObject.active)
        {
            tampilkabelGLB.SetActive(true);
        }
        else
        {
            tampilkabelGLB.SetActive(false);
        }

        if (TTGLBB.gameObject.activeSelf && PSGLBB.gameObject.active)
        {
            tampilkabelGLBB.SetActive(true);
        }
        else
        {
            tampilkabelGLBB.SetActive(false);
        }
    }
}
