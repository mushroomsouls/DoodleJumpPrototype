using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformHeight;

    private void Start()
    {
        platformHeight = thePlatform.GetComponent<BoxCollider2D>().size.y;
    }

    private void Update()
    {
        if (transform.position.y < generationPoint.position.y)
        {
            transform.position = new Vector3(Random.Range(-8f, 8f), transform.position.y + platformHeight + distanceBetween, transform.position.x);

            Instantiate(thePlatform, transform.position, transform.rotation);
        }
    }
}