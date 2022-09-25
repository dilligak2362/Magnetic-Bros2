using UnityEngine;
using System.Collections;

public class PlayersMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    float translation;
    float rotation;

    void Update()
    {
        if (this.CompareTag("FirstPlayer")
        {
            //1st player
            translation = Input.GetAxis("Vertical") * speed;
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        }

        if (this.CompareTag("SecondPlayer")
        {
            //2nd player
            translation = Input.GetAxis("Vertical") * speed;
            rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        }

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}