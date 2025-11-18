using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public Camera cmr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        x = Mathf.Clamp(x, -12.82f, 100f);
        Vector3 temp = cmr.transform.position;
        temp.x = x;
    
        cmr.transform.position = temp;
  
        
    }
}
