using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RunesManager : MonoBehaviour
{
    public Text levelCleared;
    public Text totalFruits;
    public Text fruitsCollected;
    private int totalFruitsInLevel;

    private void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }


    private void Update()
    {
        AllRunesCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        fruitsCollected.text = transform.childCount.ToString();

    }



    public void AllRunesCollected()
    {

        if(transform.childCount == 0)
        {
            Debug.Log("No quedan mas runas, Victoria");
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeSecene", 1);
        }
    }

    void ChangeSecene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
