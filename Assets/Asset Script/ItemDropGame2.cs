using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDropGame2 : MonoBehaviour, IDropHandler
{
    public int b;
    public GameObject parenting, parentingON;
    public GameObject Pita, Tali, Trolly, TT, Alas, Powersuplay, Beban;
    public GameObject PitaB, TaliB, TrollyB, TTB, AlasB, PowersuplayB, BebanB;
    public GameObject PitaD, TaliD, TrollyD, TTD, AlasD, PowersuplayD, BebanD;
    public GameObject PitaOn, TaliOn, TrollyOn, TTOn, AlasOn, PowersuplayOn, BebanOn;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            //ubahan
            if (b == 1)
            {
                Pita.SetActive(false);
                Tali.SetActive(false);
                Trolly.SetActive(false);
                TT.SetActive(false);
                Alas.SetActive(false);
                Powersuplay.SetActive(false);
                Beban.SetActive(false);
                PitaD.SetActive(false);
                PitaB.SetActive(false);
                PitaOn.SetActive(true);

                PitaD.transform.parent = parenting.transform;
                PitaD.transform.localPosition = new Vector2(204.6f, -257.5f);
            }
            else if (b == 2)
            {
                Pita.SetActive(false);
                Tali.SetActive(false);
                Trolly.SetActive(false);
                TT.SetActive(false);
                Alas.SetActive(false);
                Powersuplay.SetActive(false);
                Beban.SetActive(false);
                TaliD.SetActive(false);
                TaliB.SetActive(false);
                TaliOn.SetActive(true);

                TaliD.transform.parent = parenting.transform;
                TaliD.transform.localPosition = new Vector2(279.0f, -287.2f);
            }
            else if (b == 3)
            {
                Pita.SetActive(false);
                Tali.SetActive(false);
                Trolly.SetActive(false);
                TT.SetActive(false);
                Alas.SetActive(false);
                Powersuplay.SetActive(false);
                Beban.SetActive(false); 
                TrollyD.SetActive(false);
                TrollyB.SetActive(false);
                TrollyOn.SetActive(true);

                TrollyD.transform.parent = parenting.transform;
                TrollyD.transform.localPosition = new Vector2(339.3f, -257.8f);
            }
            else if (b == 4)
            {
                Pita.SetActive(false);
                Tali.SetActive(false);
                Trolly.SetActive(false);
                TT.SetActive(false);
                Alas.SetActive(false);
                Powersuplay.SetActive(false);
                Beban.SetActive(false); 
                TTD.SetActive(false);
                TTB.SetActive(false);
                TTOn.SetActive(true);

                TTD.transform.parent = parenting.transform;
                TTD.transform.localPosition = new Vector2(455.8f, -275.0f);
            }
            else if (b == 5)
            {
                Pita.SetActive(false);
                Tali.SetActive(false);
                Trolly.SetActive(false);
                TT.SetActive(false);
                Alas.SetActive(false);
                Powersuplay.SetActive(false);
                Beban.SetActive(false);
                AlasD.SetActive(false);
                AlasB.SetActive(false);
                AlasOn.SetActive(true);

                AlasD.transform.parent = parenting.transform;
                AlasD.transform.localPosition = new Vector2(583.0f, 14.0f);
            }
            else if (b == 6)
            {
                Pita.SetActive(false);
                Tali.SetActive(false);
                Trolly.SetActive(false);
                TT.SetActive(false);
                Alas.SetActive(false);
                Powersuplay.SetActive(false);
                Beban.SetActive(false); 
                PowersuplayD.SetActive(false);
                PowersuplayB.SetActive(false);
                PowersuplayOn.SetActive(true);

                PowersuplayD.transform.parent = parenting.transform;
                PowersuplayD.transform.localPosition = new Vector2(226.5f, -261.5f);
            }
            else if (b == 7)
            {
                Pita.SetActive(false);
                Tali.SetActive(false);
                Trolly.SetActive(false);
                TT.SetActive(false);
                Alas.SetActive(false);
                Powersuplay.SetActive(false);
                Beban.SetActive(false);
                BebanD.SetActive(false);
                BebanB.SetActive(false);
                BebanOn.SetActive(true);

                BebanD.transform.parent = parenting.transform;
                BebanD.transform.localPosition = new Vector2(354.0f, -285.0f);
            }
        }
    }
}
