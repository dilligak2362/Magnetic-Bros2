using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetField : MonoBehaviour
{
    
    public float force = 2.0f; //magnitude of the vector of force to apply
    public bool positive = true; //if the force applied is positive or not

    private GameObject positivePlayer; //holds a reference to the positive player when they enter, returned to null when they exit
    private GameObject negativePlayer; //holds a reference to the negative player when they enter, returned to null when they exit
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(positivePlayer != null)
        {
            ApplyForce(positivePlayer, true);
        }

        if(negativePlayer != null)
        {
            ApplyForce(negativePlayer, false);
        }
    }

    //When object enters the trigger check if they are a player. If so add them to their respective category
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject otherGO = other.gameObject;
        

        if (otherGO.CompareTag("PositivePlayer"))
        { //add check later for if the player is using their magnet ability
            positivePlayer = otherGO;
            
        }
        else if (otherGO.CompareTag("NegativePlayer"))
        {
            negativePlayer = otherGO;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        GameObject otherGO = other.gameObject;

        if (otherGO.CompareTag("PositivePlayer"))
        { //add check later for if the player has turned off their magnet ability
            positivePlayer = null;
            ApplyForce(otherGO, true);
        }
        else if (otherGO.CompareTag("NegativePlayer"))
        {
            negativePlayer = null;
            ApplyForce(otherGO, false);
        }
    }


    //Creates the force vector to apply to the player then applies it to their rigidbody2D
    private void ApplyForce(GameObject otherGO, bool playerPositive)
    {
        Rigidbody2D rb = otherGO.GetComponent<Rigidbody2D>();

        Vector3 forceApplied = Vector3.zero;
        Vector3 otherPos = otherGO.transform.position;

        forceApplied = otherPos - transform.position;
        forceApplied.Normalize();
        forceApplied *= force;

        //If player and field are opposite polarity flip the force vector
        if((positive && !playerPositive) || (!positive && playerPositive))
        {
            forceApplied *= -1;
        }

        Vector2 forceApplied2D = new Vector2(forceApplied.x, forceApplied.y);

        rb.AddForce(forceApplied2D, ForceMode2D.Impulse);
    }
}
