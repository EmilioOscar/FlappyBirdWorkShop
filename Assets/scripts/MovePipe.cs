using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
//this float changes the speed of which the pipes move
public float speed;
// Update is called once per frame
void Update()
{
//this moves the pipe to the left
transform.position += Vector3.left * speed * Time.deltaTime;
}
}

