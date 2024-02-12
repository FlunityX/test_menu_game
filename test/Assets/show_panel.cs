using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class show_panel : MonoBehaviour
{
    [SerializeField ] GameObject _panel;
    [SerializeField ] GameObject player;
    [SerializeField] GameObject _hidebutton;
    [SerializeField] GameObject Onvolume;
    [SerializeField] GameObject Offvolume;
    // Start is called before the first frame update
    public void onclick()
    {
        player.SetActive(false);
        _panel.SetActive(true);
        Time.timeScale = 0f; 
        _hidebutton.SetActive(false);
    }
    public void onvolume()
    {
        AudioListener.pause = false;
        Onvolume.SetActive(true);
        Offvolume.SetActive(false);
    }
   public void offvolume()
    {
        AudioListener.pause = true;
        Offvolume.SetActive(true);
        Onvolume.SetActive(false);
    }
    public void offpanel()
    {
        _panel.SetActive(false);
        _hidebutton.SetActive(true);
        Time.timeScale = 1f;
        player.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void rescene()
    {
        SceneManager.LoadScene(0);
    }
    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
