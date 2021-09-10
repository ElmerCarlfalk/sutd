using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITower : MonoBehaviour
{
    bool placed = false;

    private void Update()
    {
        if (!placed)
        {
            if (!Input.GetKeyDown(KeyCode.Mouse0))
            {
                transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            else
            {
                placed = true;
            }
        }
        else
        {
        }
    }
}
