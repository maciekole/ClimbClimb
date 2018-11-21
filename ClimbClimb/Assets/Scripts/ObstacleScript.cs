﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour {

    private GameControllerScript gameController;

	// Use this for initialization
	void Start () {

        gameController = GameObject.Find("mainObject").GetComponent<GameControllerScript>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (gameController.GetGameOver() == false)
        {
            transform.Translate(Vector3.down * 7 * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }

    }


}
