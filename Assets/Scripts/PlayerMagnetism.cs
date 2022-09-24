using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagnetism : MonoBehaviour
{
    public GameObject magnetHitboxGO;
    private Collider2D magnetHitbox;

    private bool magnetized = false;

    // Start is called before the first frame update
    void Start()
    {
        magnetHitbox = magnetHitboxGO.GetComponent<Collider2D>();
        magnetHitboxGO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!magnetized)
        {
            if(Input.GetKey("left shift"))
            {
                magnetHitboxGO.SetActive(true);
                magnetized = true;
            }
        }
        else
        {
            if (Input.GetKeyUp("left shift"))
            {
                magnetHitboxGO.SetActive(false);
                magnetized = false;
            }
        }
        
    }
}
