using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoCloud : MonoBehaviour
{
    [SerializeField] private Transform ControladorDisparo1;
    [SerializeField] private Transform ControladorDisparo2;
    [SerializeField] private GameObject lightin;
    private float spawntime = 0.5f;
    private float Tiempo;


    private void Update()
    {

        spawntime = Random.Range(1.5f, 4f);
        Tiempo += Time.deltaTime;

        if (Tiempo > spawntime)
        {
            Disparar();
            Disparar2();
        }


    }

    private void Disparar()
    {
        Tiempo = 0f;
        Instantiate(lightin, ControladorDisparo1.position, ControladorDisparo1.rotation);
    }
    private void Disparar2()
    {
        Tiempo = 0.5f;
        Instantiate(lightin, ControladorDisparo2.position, ControladorDisparo2.rotation);
    }
}
