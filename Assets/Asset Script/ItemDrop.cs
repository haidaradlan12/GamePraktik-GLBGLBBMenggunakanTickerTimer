using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDrop : MonoBehaviour, IDropHandler
{
    public int b;
    public GameObject parenting;
    public GameObject Pita, Trolly, Alas, Powersuplay, TT;
    public GameObject PitaD, TrollyD, AlasD, PowersuplayD, TTD;
    public GameObject PitaOn, TrollyOn, AlasOn, PowersuplayOn, TTOn;
    public GameObject PitaB, TrollyB, AlasB, PowersuplayB, TTB;

    public void OnDrop(PointerEventData eventData)
    { 
        if (eventData.pointerDrag != null)
        {
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            //ubahan
            if (b == 1) //pita
            {
                Pita.SetActive(false);
                Trolly.SetActive(false);
                Alas.SetActive(false);
                Powersuplay.SetActive(false);
                TT.SetActive(false);
                PitaD.SetActive(false);
                PitaB.SetActive(false);
                PitaOn.SetActive(true);

                PitaD.transform.parent = parenting.transform;
                PitaD.transform.localPosition = new Vector2(153.71f, -257.57f);
            }
            else if (b == 2) //trolly
            {
                Pita.SetActive(false);
                Trolly.SetActive(false);
                Alas.SetActive(false);
                Powersuplay.SetActive(false);
                TT.SetActive(false);
                TrollyD.SetActive(false);
                TrollyB.SetActive(false);
                TrollyOn.SetActive(true);

                TrollyD.transform.parent = parenting.transform;
                TrollyD.transform.localPosition = new Vector2(279.0f, -355.0f);
            }
            else if (b == 3) //alas
            {
                Pita.SetActive(false);
                Trolly.SetActive(false);
                Alas.SetActive(false);
                Powersuplay.SetActive(false);
                TT.SetActive(false);
                AlasD.SetActive(false);
                AlasB.SetActive(false);
                AlasOn.SetActive(true);

                AlasD.transform.parent = parenting.transform;
                AlasD.transform.localPosition = new Vector2(182.0f, -48.0f);
            }
            else if (b == 4) // PS
            {
                Pita.SetActive(false);
                Trolly.SetActive(false);
                Alas.SetActive(false);
                Powersuplay.SetActive(false);
                TT.SetActive(false);
                PowersuplayD.SetActive(false);
                PowersuplayB.SetActive(false);
                PowersuplayOn.SetActive(true);

                PowersuplayD.transform.parent = parenting.transform;
                PowersuplayD.transform.localPosition = new Vector2(11.909f, -255.0f);
            }
            else if (b == 5) //TT
            {
                Pita.SetActive(false);
                Trolly.SetActive(false);
                Alas.SetActive(false);
                Powersuplay.SetActive(false);
                TT.SetActive(false);
                TTD.SetActive(false);
                TTB.SetActive(false);
                TTOn.SetActive(true);

                TTD.transform.parent = parenting.transform;
                TTD.transform.localPosition = new Vector2(425.0f, -271.53f);
            }
        }
    }
    

}
