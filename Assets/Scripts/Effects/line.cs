using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    public LineRenderer line1, line2;
    public GameObject player;
    public GameObject p1;
    

    private void Start()
    {
        
    }

    private void Update()
    {

        line1.GetComponent<LineRenderer>().SetPosition(0,player.transform.position);
        line1.GetComponent<LineRenderer>().SetPosition(1,p1.transform.position);
    }
}
