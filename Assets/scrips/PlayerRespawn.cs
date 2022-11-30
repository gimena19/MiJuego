using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerRespawn : MonoBehaviour
{
    public GameObject[] hearts;
    private float checkPointX, checkPointY;

    public Animator animator;
    private int life;

    void Start()
    {
        life = hearts.Length;
        if (PlayerPrefs.GetFloat("checPointPositionX") != 0)
        {
            transform.position=(new Vector2(PlayerPrefs.GetFloat("checkPointPosition"), PlayerPrefs.GetFloat("checkPointPosition")));
        }
    }

    private void CheckLife()
    {
        if (life< 1)
        {
            Destroy(hearts[0].gameObject);
            animator.Play("PlayerHit");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if(life < 2)
        {
            Destroy(hearts[1].gameObject);
            animator.Play("PlayerHit");
        }
        else if(life < 3)
        {
            Destroy(hearts[2].gameObject);
            animator.Play("PlayerHit");
        }
    }


    public void ReachedCheckPoint(float x, float y)
    {
        PlayerPrefs.SetFloat("checkPointX", x);
        PlayerPrefs.SetFloat("checkPointY", x );
    }
    public void PlayerDamaged()
    {
        life--;
        CheckLife();




    }

   
}

