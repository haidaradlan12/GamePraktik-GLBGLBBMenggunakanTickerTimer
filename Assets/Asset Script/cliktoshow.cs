using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class cliktoshow : MonoBehaviour, IPointerDownHandler
{
    public GameObject Show;
    private int a = 0;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (a==0)
        {
            Show.SetActive(true);
            a = 1;
        }
    }

    public void kembali()
    {
        a = 0;
    }
}
