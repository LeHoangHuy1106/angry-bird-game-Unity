using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ban : MonoBehaviour
{

    Vector3 initPos;
    Rigidbody2D rb;
    LineRenderer line1, line2;
    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.localPosition;
        rb = GetComponent<Rigidbody2D>();
 //       line1 = GameObject.Find("line1").GetComponent<LineRenderer>(); ;
 //       line2 = GameObject.Find("line2").GetComponent<LineRenderer>(); ;
    }

    // Update is called once per frame
    void Update()
    {
 
        

    }


    void blockPos()
    {
        Vector3 pos = transform.localPosition;
        pos.y = Mathf.Min(pos.y);
        transform.localPosition = pos;
    }

    private void OnMouseDrag()
    {

        
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float maxX = Mathf.Clamp(mousePos.x, initPos.x - 3, initPos.x + 3);
        float maxY = Mathf.Clamp(mousePos.y, initPos.y - 3, initPos.y + 3);

        transform.localPosition = new Vector2(maxX, maxY);
 //       
    }
    private void OnMouseUp()
    {

        Vector3 vtForce = initPos - transform.localPosition;

        rb.AddForce(vtForce * 800);
        rb.gravityScale = 1;
    }

}
    
