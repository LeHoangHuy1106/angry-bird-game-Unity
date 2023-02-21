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
        float x = transform.localPosition.x;
        x = Mathf.Clamp(x, -5.06f,3.95f);
        Vector3 temp = cmr.transform.localPosition;
        temp.x = x;
    
        cmr.transform.localPosition = temp;
  
        
    }
}
