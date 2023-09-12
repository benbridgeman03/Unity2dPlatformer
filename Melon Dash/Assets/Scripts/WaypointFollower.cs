using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] public GameObject[] waypoints;
    private int currentWaypoint = 0;
    private Vector3 currentLocation;
    private Vector3 previousLocation;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        currentLocation = transform.position;

        if (Vector2.Distance(waypoints[currentWaypoint].transform.position, transform.position) < .1f)
        {
            currentWaypoint++;
            if(currentWaypoint >= waypoints.Length)
            {
                currentWaypoint = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypoint].transform.position, Time.deltaTime * speed);
        previousLocation = transform.position;
    }

    public int getCurrentWaypoint()
    {
        return currentWaypoint;
    }

    public Vector3 getCurrentLocation()
    {
        return currentLocation;
    }

    public Vector3 getPreviousLocation()
    {
        return previousLocation;
    }
}
