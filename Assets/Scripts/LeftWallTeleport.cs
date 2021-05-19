using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWallTeleport : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform teleportPoint;

    void OnTriggerEnter2D(Collider2D other)
    {
        teleportPoint.transform.position = player.transform.position + new Vector3(22, 0, 0);
        player.transform.position = teleportPoint.transform.position;
    }

    public Transform targetTransform;
    Vector3 tempVec3 = new Vector3();

    private void Update()
    {
        tempVec3.x = this.transform.position.x;
        tempVec3.y = targetTransform.position.y;
        tempVec3.z = this.transform.position.z;
        this.transform.position = tempVec3;
    }
}
