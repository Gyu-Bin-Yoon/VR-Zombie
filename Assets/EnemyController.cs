using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{ 
//       private float latestDirectionChangeTime;
//  private readonly float directionChangeTime = 2f;
//  private float characterVelocity = 3f;
//  private Vector2 movementDirection;
//  private Vector2 movementPerSecond;
 
 
//  void Start(){
//      latestDirectionChangeTime = 0f;
//      calcuateNewMovementVector();
//  }
 
//  void calcuateNewMovementVector(){
//     //create a random direction vector with the magnitude of 1, later multiply it with the velocity of the enemy
//      movementDirection = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
//      movementPerSecond = movementDirection * characterVelocity;
//  }
 
//  void Update(){
//      //if the changeTime was reached, calculate a new movement vector
//      if (Time.time - latestDirectionChangeTime > directionChangeTime){
//          latestDirectionChangeTime = Time.time;
//          calcuateNewMovementVector();
//      }
     
//      //move enemy: 
//      transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime), 
//      transform.position.y + (movementPerSecond.y * Time.deltaTime));
 
//  }

public Transform[] movePoints;
public float speed;
private int amount;
private Transform currentTarget;
private float timer = 0f;

    void Start () {
        randoming ();
    }    

    void Update () {
        Movement ();
        timer += Time.deltaTime;
        if (timer > 5.05f)
        {
            randoming();
            timer = 0f;
        }
    }

    void randoming() {
        amount = Random.Range (0, movePoints.Length);
        currentTarget = movePoints[amount];
    }    

    void Movement() {
        transform.position = Vector3.MoveTowards (transform.position, currentTarget.position, speed * Time.deltaTime);
    }

}
