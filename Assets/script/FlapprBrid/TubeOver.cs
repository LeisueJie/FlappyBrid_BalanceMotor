using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeOver : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GameOver.isActive = false;
            //play gameOver audio
        }
    }
}
