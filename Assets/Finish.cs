using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public Movement movement;
    public P2Movement p2Movement;
    public bool bothDone;

    //private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        //gm = GameManager.GM;
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.isFinished == true && p2Movement.isFinished == true)
        {
            
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            movement.isFinished = true;
        }

        if (col.gameObject.tag == "Player2")
        {
            p2Movement.isFinished = true;
        }

    }
}
