﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    //private Animator playerAnim;

    private bool isMove = true;

    public Rigidbody2D rb;
    
    public float speed = 5f;
   
    void Update() {
        if(!isMove){
            rb.MovePosition(rb.position + Vector2.right * speed * Time.deltaTime);
        }
    }

    //void Start() {
        //rb = GetComponent<Rigidbody2D>();
        //playerAnim = GetComponent<Animator>();
    //}

    //void Update() {
        //float x = Input.GetAxisRaw("Horizontal");

        //rb.velocity = new Vector2(x * speed, rb.velocity.y);

        //if(x == 0) {
            //playerAnim.SetBool("isWalking", false);
        //} else {
            //playerAnim.SetBool("isWalking", true);
        //}

        //if (x < 0) {
            //transform.eulerAngles = new Vector3(0, 180, 0);
        //} else if (x > 0) {
            //transform.eulerAngles = new Vector3(0, 0, 0);
        //}
    //}
    
    void OnTriggerEnter2D(Collider2D col){
        if(col.tag == "Guard") {
            isMove = true;
        } else if(col.tag == "Player") {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

