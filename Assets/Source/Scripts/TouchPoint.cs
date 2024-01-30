using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPoint : MonoBehaviour
{
    private bool isSelected = false;
    public void SetData(Sprite ic)
    {
        isSelected = false;
        GetComponent<CircleCollider2D>().enabled = true;
        GetComponent<SpriteRenderer>().sprite = ic;
        SetUnCollected();
    }

    public void SetCollected()
    {
        if(isSelected) return;
        isSelected = true;
        transform.localScale = Vector3.one*0.35f;
        GetComponent<CircleCollider2D>().enabled = false;
    }
    public void SetUnCollected()
    {
        isSelected = false;
        transform.localScale = Vector3.one*0.3f;
        GetComponent<CircleCollider2D>().enabled = true;
    }
}