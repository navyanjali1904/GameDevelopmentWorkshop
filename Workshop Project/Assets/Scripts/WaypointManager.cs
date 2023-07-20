using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
    public static Transform[] waypoints;
    public Rigidbody2D player;

    private void Awake()
    {
        waypoints = new Transform[transform.childCount]; 
        for(int i = 0; i < waypoints.Length; i++ )
        {
            waypoints[i] = transform.GetChild(i);

        }
    }
    private void Update()
    {
        // Continuously update the last waypoint to the player's position
        if (waypoints.Length > 0 && player != null)
        {
            waypoints[waypoints.Length - 1].position = player.position;
        }
    }

}
