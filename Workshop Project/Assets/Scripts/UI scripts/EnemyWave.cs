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
        string WaveIndex = EnemiesManager.GetComponent<EnemiesManager>().waveIndex.ToString();

        waveCounterUI.text = WaveIndex;
    }
}
