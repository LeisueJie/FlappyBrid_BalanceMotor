using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brid : MonoBehaviour {

    Rigidbody2D rg;
    public float upForce = 200f;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        rg = transform.GetComponent<Rigidbody2D>();
        StartCoroutine(WaitTime());
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && GameOver.isActive)
        {
            rg.AddForce(new Vector2(0, upForce));
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("UGUIDEMO");
        }
	}
    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "scoreObj")
        {
            GameOver.score += 1;
            scoreText.text = "Score:" + GameOver.score;
            //play score audio
        }
    }
    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(0.5f);
        transform.GetComponent<Rigidbody2D>().simulated = true;
    }
}
