using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioValue : MonoBehaviour {

    public Text audio_text;
    // Use this for initialization
    void Start () {
        audio_text.text = gameObject.transform.GetComponent<Slider>().value*100 + "";
    }

    public void showValue()
    {
        audio_text.text = gameObject.transform.GetComponent<Slider>().value*100 + "";
    }
}
