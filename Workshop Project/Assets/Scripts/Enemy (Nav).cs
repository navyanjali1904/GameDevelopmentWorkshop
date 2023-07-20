using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 10f;
    public Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        target = WaypointManager.waypoints[0];
    }


    private void Update()
    {
        {
            Vector3 dir = target.position - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        }

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWayPoint();
        }
    }

    void GetNextWayPoint()
    {
        if   (wavepointIndex >= WaypointManager.waypoints.Length - 1) 
        {
            Destroy(gameObject);
            return;
        }

        wavepointIndex++;
        target = WaypointManager.waypoints[wavepointIndex];
    }
}

