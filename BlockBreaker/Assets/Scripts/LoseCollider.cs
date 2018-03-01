using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

    private LevelManager levelManager;
    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }
    //private void OnCollisionEnter2D(Collision2D collision){}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        levelManager.LoadLevel("Lose");
    }
}
