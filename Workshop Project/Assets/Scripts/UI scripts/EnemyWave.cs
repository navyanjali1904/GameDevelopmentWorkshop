using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyWave : MonoBehaviour
{
    public EnemiesManager EnemiesManager;
    
    public TextMeshProUGUI waveCounterUI;
    // Start is called before the first frame update
    

        

    // Update is called once per frame
    void Update()
    {
        int WaveIndex = EnemiesManager.GetComponent<EnemiesManager>().waveIndex ;

        waveCounterUI.text = WaveIndex.ToString();
    }
}
