using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour{
 public Transform[] target;
 public float speed;

 private int current;

 void Update (){
     if (transform.position != target[current].position)
     {
         Vector2 pos = Vector2.MoveTowards(transform.position,target[current].position, speed * Time.deltaTime);
         GetComponent<Rigidbody2D>().MovePosition(pos);
     }
     else current = (current + 1) % target.Length;
 }
}
