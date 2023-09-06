using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Flip : MonoBehaviour
{
    private SpriteRenderer sprite;
    private WaypointFollower wp;
    private Rotate rt;

    private void Start()
    {
        wp = GetComponent<WaypointFollower>();
        sprite = GetComponent<SpriteRenderer>();
        rt = GetComponent<Rotate>();

    }

    private void Update()
    {
        bool flipX = (wp.getCurrentLocation().x - wp.getPreviousLocation().x) > 0f;

        /*
        if(gameObject.tag == "trap")
        {
            rt.changeSpeed(flipX ? rt.getSpeed() : -rt.getSpeed());
        }
        
        rt.changeSpeed(flipX ? -rt.getSpeed() * -1 : -1); //fix this
        */

        sprite.flipY = flipX;  //this is all i need to flip any sprtie thats not rotating i.e saws

    }

}
