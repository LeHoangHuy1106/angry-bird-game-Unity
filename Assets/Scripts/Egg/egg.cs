using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egg : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameObject.Find("Canvas").GetComponent<buttonController>().setPoint(2);
            GameObject.FindGameObjectWithTag("Player").GetComponent<sound>().Play(2);
        }
    }

}
