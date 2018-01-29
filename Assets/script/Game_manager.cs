using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Game_manager : MonoBehaviour {

    public Animator ani_text;
    public Animator win_out;
    public Animator setwin_in;
    public Animator audio_anim;
    public Animator vadeo_anim;

    void Start()
    {
        ani_text = this.gameObject.transform.Find("Text_synopsis").GetComponent<Animator>();
        win_out = this.gameObject.transform.Find("main_menu").Find("mian_window").GetComponent<Animator>();
        setwin_in = this.gameObject.transform.Find("main_set").Find("mian_window").GetComponent<Animator>();
        audio_anim = this.gameObject.transform.Find("main_set_audio").Find("audio_window").GetComponent<Animator>();
    }

    public void text_in()//点击syposis按钮事件
    {
        ani_text.SetBool("font_in",true);
        win_out.SetBool("menuwinout",true);
        StartCoroutine(WaitTime(9.5f));//点击后十秒启动协程
    }
    IEnumerator WaitTime(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        win_out.SetBool("menuwinout", false);
    }
    public void startGame()//开始游戏按钮
    {
        Application.LoadLevel("YOUXI");
    }
    public void Seting()
    {
        win_out.SetBool("menuwinout", true);
        gameObject.transform.Find("main_menu").gameObject.SetActive(false);
        gameObject.transform.Find("main_set").gameObject.SetActive(true);
        setwin_in.SetBool("setwin_in", true);
    }
    public void QuitApp()//退出按钮
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    //设置按钮
    public void PlayGame()//继续游戏按钮
    {
        Application.LoadLevel("YOUXI");
    }
    public void AudioOpen()//set界面audio按钮
    {
        gameObject.transform.Find("main_set_audio").gameObject.SetActive(true);
        gameObject.transform.Find("main_set_video").gameObject.SetActive(false);
        //audio_anim.SetBool("main_set_audio", true);
    }
    public void VideoOpen()//set界面vadeo按钮
    {
        gameObject.transform.Find("main_set_video").gameObject.SetActive(true);
        gameObject.transform.Find("main_set_audio").gameObject.SetActive(false);

    }
    public void SetBack()//返回主菜单按钮
    {
        setwin_in.SetBool("setwin_in", false);
        gameObject.transform.Find("main_set").gameObject.SetActive(false);
        gameObject.transform.Find("main_menu").gameObject.SetActive(true);
        win_out.SetBool("menuwinout", false);
        gameObject.transform.Find("main_set_audio").gameObject.SetActive(false);
        gameObject.transform.Find("main_set_video").gameObject.SetActive(false);
    }
    //audioClose按钮
    public void CloseAudio()
    {
        //audio_anim.SetBool("main_set_audio", false);
        gameObject.transform.Find("main_set_audio").gameObject.SetActive(false);
    }
    //audioClose按钮
    public void CloseVideo()
    {
        //audio_anim.SetBool("main_set_audio", false);
        gameObject.transform.Find("main_set_video").gameObject.SetActive(false);
    }
}
