using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CombateJugador : MonoBehaviour
{

    [SerializeField] private float vida;
    [SerializeField] private GameObject efectoMuerte;
    public event EventHandler MuerteJugador;

    public void TomarDaño(float daño)
    {
        vida -= daño;

        if (vida <= 0)
        {
           // MuerteJugador?.Invoke(this, EventArgs.Empty);
            Muerte();

        }
    }

    private void Muerte()
    {
       // Instantiate(efectoMuerte, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
