using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallWord : MonoBehaviour
{
    public GameObject correctForm;
    private bool moving;
    private bool Finish;

    private float startPosX;
    private float startPosY;
    public Movement Player;

    private Vector3 resetPosition;

    private void Start()
    {
        resetPosition = this.transform.localPosition;
    }

    void Update()
    {
        if (Finish == false)
        {
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
        }

    }

    public void OnMouseDown()
    {
        Player.contro = false;
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousepos;
            mousepos = Input.mousePosition;
            mousepos = Camera.main.ScreenToWorldPoint(mousepos);

            startPosX = mousepos.x - this.transform.localPosition.x;
            startPosY = mousepos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    public void OnMouseUp()
    {
//        Player.contro = true;
        moving = false;

        if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f &&
            Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.5f)
        {
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            Finish = true;
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
