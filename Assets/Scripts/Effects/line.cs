using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    public LineRenderer line1, line2,line3;
    public GameObject player;
    public GameObject p1;
    public bool check = false;
    

    private void Start()
    {
        
    }

    private void Update()
    {
        if (check == false)
        {
            line1.GetComponent<LineRenderer>().SetPosition(0, player.transform.position);
            line1.GetComponent<LineRenderer>().SetPosition(1, p1.transform.position);
            line2.GetComponent<LineRenderer>().SetPosition(1, player.transform.position);
           // createLine3();
        }
        else
        {
            line1.GetComponent<LineRenderer>().SetPosition(0, p1.transform.position);
            line1.GetComponent<LineRenderer>().SetPosition(1, p1.transform.position);
            line2.GetComponent<LineRenderer>().SetPosition(1, p1.transform.position);
        }

   
    }

    void createLine3()
    {

        List<Vector2> vectors =  new List<Vector2>();

        for (int i = 0; i<=4; i++)
        {
            float x, y;
            x = player.transform.localPosition.x + player.GetComponent<Ban>().addforce.x * i;
            y = player.transform.localPosition.y + player.GetComponent<Ban>().addforce.y*i;
            

           
        }
        line1.GetComponent<LineRenderer>().SetPosition(0, player.transform.position);

    }



}
