using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed = -1f;

    private SpriteRenderer sprite;
    private WaypointFollower wp;

    private void Start()
    {
        wp = GetComponent<WaypointFollower>();
        sprite = GetComponent<SpriteRenderer>();

    }

    private void Update()
    { 
        bool flipX = (wp.currentLocation.x - wp.previousLocation.x) > 0f || (wp.currentLocation.y - wp.previousLocation.y) < 0f;
        sprite.flipX = flipX;

        transform.Rotate(0f, 0f, 360 * speed * Time.deltaTime);
    }
    
}
