using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointToShowObject : MonoBehaviour, IPointerClickHandler
{
    public GameObject DaunPotong1, DaunPotong2, DaunPotong3, DaunPotong4;
    int coun =0;
    public void OnPointerClick(PointerEventData eventData)
    {
        coun = coun + 1;
        menghitung();
    }
    public void menghitung()
    {
        if (coun == 1)
        {
            DaunPotong1.SetActive(true);
        }
        else if (coun == 2)
        {
            DaunPotong2.SetActive(true);
        }
        else if (coun == 3)
        {
            DaunPotong3.SetActive(true);
        }
        else if (coun == 4)
        {
            DaunPotong4.SetActive(true);
        }
    }
    
}
