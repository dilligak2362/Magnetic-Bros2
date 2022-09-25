/****
*Created by: Alexander Zotov youtube.com
*Edited by: Bridget Kurr
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatedMovement : MonoBehaviour
{
	private Vector3 startPosition;

	[SerializeField]
	//moves the object faster or slower in its path
	private float frequency = 5f;

	[SerializeField]
	//distance traveled in path
	private float magnitude = 5f;

	[SerializeField]
	//shifts the starting point of the object in the path
	private float offset = 0f;

	//Start() is called before the first frame update
	void Start()
	{
		startPosition = transform.position;
	}

	//Update() is called once per frame
	void Update()
	{
		transform.position = startPosition + transform.right * Mathf.Sin(Time.time * frequency + offset) * magnitude;
	}
}