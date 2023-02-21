using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distroy_enemy : MonoBehaviour
{
    public GameObject boom;
    bool check = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Rigidbody2D>().velocity.magnitude > 3f && check == false)
         {
            check = true;
            Instantiate(boom, transform.localPosition, Quaternion.identity);
            GameObject.Find("Canvas").GetComponent<buttonController>().setPoint(1);
            GameObject.FindGameObjectWithTag("Player").GetComponent<sound>().Play(1);
            Destroy(gameObject, 0.1f);
           
        }
    }
}
