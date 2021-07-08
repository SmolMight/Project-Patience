using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Stackable : MonoBehaviour
{
    [SerializeField]
    private bool isStackable;

    private RectTransform rectTransform;
    private Vector2 offset;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    /*
    public void OnDrop(PointerEventData eventData)
    {
        if (!isStackable) return;
         RectTransform draggedObject = eventData.pointerDrag.GetComponent<RectTransform>();
         draggedObject.SetParent(rectTransform);
    }*/
}
