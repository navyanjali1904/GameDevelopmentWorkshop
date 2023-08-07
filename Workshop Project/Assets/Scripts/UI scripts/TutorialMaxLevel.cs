using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TutorialMaxLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public EnemiesManager EnemiesManager;

    public int WaveIndex;
    public GameObject canvasToEnable;
    
    void Start()
    {
        canvasToEnable.SetActive(false);
    }
        
    private void Update()

    {
        WaveIndex = EnemiesManager.GetComponent<EnemiesManager>().waveIndex;
        
        
        if (WaveIndex > 1 && !canvasToEnable.activeSelf)
        {
          
            Debug.Log("tutorial complete");
            canvasToEnable.SetActive(true);
           


        }

       

        // If the timer has expired, load the next scene


    }

    


}
