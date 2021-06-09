using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWallTeleport : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform teleportPoint;
    public Transform targetTransform;
    Vector3 tempVec3 = new Vector3();

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player != null)
        {
           teleportPoint.transform.position = player.transform.position - new Vector3(18, 0, 0);
           player.transform.position = teleportPoint.transform.position;
        }
    }

    private void Update()
    {
        if (player != null)
        {
            tempVec3.x = this.transform.position.x;
            tempVec3.y = targetTransform.position.y;
            tempVec3.z = this.transform.position.z;
            this.transform.position = tempVec3;
        }
    }
}
