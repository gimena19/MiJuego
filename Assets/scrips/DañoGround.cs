using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoGround : MonoBehaviour
{
    [SerializeField] private float daño;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ground"))
        {
            other.GetComponent<TimeLife>().TomarDaño(daño);
           

        }
    }
}
