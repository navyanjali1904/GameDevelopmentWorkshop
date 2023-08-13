using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChromaHEalth : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ObjectivePrefab;
    public GameObject Chroma;
    private int ChromaHealth = 3;





    // Update is called once per frame
    

        
    void Update()
    {
        if(ObjectivePrefab.GetComponent<Objective>().currentHp < 0 && ChromaHealth > 0) 
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            ChromaHealth--;
        }
        if (ChromaHealth <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
