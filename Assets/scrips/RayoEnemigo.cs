using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoEnemigo : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float tiempoDeVida;
    //[SerializeField] private float daño;
    private void Update()
    {


        transform.Translate(Vector2.down * velocidad * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Damage");
            Destroy(collision.gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tiempoDeVida);
    }

}
