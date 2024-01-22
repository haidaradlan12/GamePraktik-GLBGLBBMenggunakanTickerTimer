using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrug2 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    public int can;
    private CanvasGroup canvasGroup;
    public GameObject Hilang1, Hilang2, Hilang3, Hilang4, Hilang5, Hilang6, Hilang7;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;

        if (can == 1)
        {
            Hilang1.SetActive(true);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 2)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(true);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 3)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(true);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 4)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(true);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 5)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(true);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 6)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(true);
            Hilang7.SetActive(false);
        }
        else if (can == 7)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(true);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;

        if (can == 1)
        {
            Hilang1.SetActive(true);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 2)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(true);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 3)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(true);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 4)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(true);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 5)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(true);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 6)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(true);
            Hilang7.SetActive(false);
        }
        else if (can == 7)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(true);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        if (can == 1)
        {
            Hilang1.SetActive(true);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 2)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(true);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 3)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(true);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 4)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(true);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 5)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(true);
            Hilang6.SetActive(false);
            Hilang7.SetActive(false);
        }
        else if (can == 6)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(true);
            Hilang7.SetActive(false);
        }
        else if (can == 7)
        {
            Hilang1.SetActive(false);
            Hilang2.SetActive(false);
            Hilang3.SetActive(false);
            Hilang4.SetActive(false);
            Hilang5.SetActive(false);
            Hilang6.SetActive(false);
            Hilang7.SetActive(true);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDown");
    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    
}