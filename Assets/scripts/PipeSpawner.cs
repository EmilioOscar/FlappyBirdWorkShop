using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

   public float maxTime = 1;
   private float timer = 0;
   public GameObject pipe;
   public float height;


   // Update is called once per frame
   void Update()
{
   
   //if the timer is greater than maxTime
   if(timer > maxTime)
{
   //create a new pipe
   GameObject newpipe = Instantiate(pipe);
   //this sets the position of the pipe and randomises it
   newpipe.transform.position = transform.position + new

  Vector3(0, Random.Range(-height, height), 0);
  //this removes the pipe
  Destroy(newpipe, 15);
  timer = 0;



    }
    //this sets timer a=a+b is the same as a+=b
    timer += Time.deltaTime;

  }

}