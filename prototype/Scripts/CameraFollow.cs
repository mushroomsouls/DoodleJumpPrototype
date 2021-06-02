using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraFollow : MonoBehaviour
{
	public Transform target;

    private void Update()
    {
		if (target == null)
		{
			SceneManager.LoadScene(2);
		}
	}

    void LateUpdate()
	{
		if (target != null)
        {
			if (target.position.y > transform.position.y)
			{
				Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
				transform.position = newPos;
			}
		}
	}
}