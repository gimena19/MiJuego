using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneCollected : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetComponent<SpriteRenderer>().enabled = false;
            //gameObject.transform.GetChild(0);



            Destroy(gameObject, 0.5f);
        } 
    }

}
