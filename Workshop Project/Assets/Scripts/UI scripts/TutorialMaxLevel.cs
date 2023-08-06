using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TutorialMaxLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public EnemiesManager EnemiesManager;

    public int WaveIndex;
    public GameObject canvasToEnable;
    public float displayTime = 5f;
    public float timer;
    void Start()
    {
        canvasToEnable.SetActive(false);
    }
        
    private void Update()

    {
        WaveIndex = EnemiesManager.GetComponent<EnemiesManager>().waveIndex;
        
        timer = displayTime;
        if (WaveIndex > 1 && !canvasToEnable.activeSelf && timer >0)
        {
            Debug.Log("redtutorial complete");
            canvasToEnable.SetActive(true);
            timer = displayTime;

        }
        timer -= Time.deltaTime;

        // If the timer has expired, load the next scene
        if (timer <= 0f)
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


}
