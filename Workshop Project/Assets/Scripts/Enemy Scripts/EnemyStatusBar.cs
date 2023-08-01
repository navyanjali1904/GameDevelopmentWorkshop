using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatusBar : MonoBehaviour
{
    [SerializeField] Transform Enemybar;

    public void SetState(int current, int max)
    {
        float state = (float)current;
        state /= max;
        if (state < 0f)
            state = 0f;
        Enemybar.transform.localScale = new Vector3(state, 1f, 1f);
    }
}
