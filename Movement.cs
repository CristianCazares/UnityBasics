using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10;
	public void Update()
    {
        float xDir = Input.GetAxis("Horizontal");
        float zDir = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(xDir, 0.0f, zDir);
        movement = movement.normalized * speed * Time.deltaTime;

        transform.position += movement;
    }

}
