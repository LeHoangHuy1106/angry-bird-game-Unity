using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ban : MonoBehaviour
{

    Vector3 initPos;
    public line line;
    Rigidbody2D rb;
    public Vector2 addforce;
  
    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.localPosition;
        rb = GetComponent<Rigidbody2D>();

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
        Vector3 vtForce = initPos - transform.localPosition;
        addforce = vtForce * 800;

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float maxX = Mathf.Clamp(mousePos.x, initPos.x - 3, initPos.x + 3);
            float maxY = Mathf.Clamp(mousePos.y, initPos.y - 3, initPos.y + 3);
            
            transform.localPosition = new Vector2(maxX, maxY);
        GetComponent<sound>().Play(3);

        //       
    }
    private void OnMouseUp()
    {

        
        rb.AddForce(addforce);
        rb.gravityScale = 1;
        GetComponent<sound>().Play(4);
        line.check = true;
        


    }


}
    
