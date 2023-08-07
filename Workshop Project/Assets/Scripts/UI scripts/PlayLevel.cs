using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void  playlevel()
    {
        SceneManager.LoadScene("Main");

    }
}
