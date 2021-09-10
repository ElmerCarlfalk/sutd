using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButton : MonoBehaviour
{
    public GameObject Tower;
    Vector3 mousePosition;

    public void Start()
    {
        mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void ClickBuyButton()
    {
        Instantiate(Tower, mousePosition, Quaternion.identity);
    }
}
