using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Transform nxtCamPointSM;
    [SerializeField] Transform originCamPointSM;
    [SerializeField] Vector3 nxtCamPointIT;
    [SerializeField] Vector3 originCamPointIT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CamPosition();
        
    }

    void CamPosition()
    {
        if (player.transform.position.x > 9.1)
        {
            //transform.position = Vector3.Lerp(transform.position, nxtCamPointSM.position, Time.deltaTime);
            transform.position = nxtCamPointIT;
        }
        else if (player.transform.position.x < 9)
        {
            //transform.position = Vector3.Lerp(transform.position, originCamPointSM.position, Time.deltaTime);
            transform.position = originCamPointIT;
        }
    }
}
