using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    private Sprite cardFace;
    private Sprite cardBack;
    private bool faceUp;
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
        if (!image) gameObject.AddComponent<Image>();
        image.sprite = cardFace;
        faceUp = true;
    }
    public void Flip()  { faceUp = !faceUp; }
}
