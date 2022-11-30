using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daño : MonoBehaviour
{
    // [SerializeField] private float daño;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Damage");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }

   

}
