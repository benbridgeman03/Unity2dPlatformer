using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] public GameObject[] waypoints;
    public int curretnWaypointIndex = 0;
    public Vector3 currentLocation;
    public Vector3 previousLocation;

    [SerializeField] private float speed = 2f;

    private void Update()
    {
        currentLocation = transform.position;

        if (Vector2.Distance(waypoints[curretnWaypointIndex].transform.position, transform.position) < .1f)
        {
            curretnWaypointIndex++;
            if(curretnWaypointIndex >= waypoints.Length)
            {
                curretnWaypointIndex = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, waypoints[curretnWaypointIndex].transform.position, Time.deltaTime * speed);
        previousLocation = transform.position;
    }
}
