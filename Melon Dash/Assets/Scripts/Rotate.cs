using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Start()
    {
        speed = 1f;
    }

    private void Update()
    {

        transform.Rotate(0f, 0f, 360 * speed * Time.deltaTime);
    }
    
    public float getSpeed()
    {
        return speed;
    }

    public void changeSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
