using UnityEngine;
using System.Collections;
using Holoville.HOTween;
using Holoville.HOTween.Plugins;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {
    public GameObject target;
    public string downMessage = "OnClickDown";
    public string upMessage = "OnClickUp";

    void OnMouseDown()
    {
        if (target && downMessage.Length>0) target.SendMessage(downMessage, SendMessageOptions.DontRequireReceiver);
    }
    void OnMouseUp()
    {
        if (target && upMessage.Length > 0) target.SendMessage(upMessage, SendMessageOptions.DontRequireReceiver);
    }
    public void nachalo()
    {
        // Application.LoadLevel(Application.loadedLevel);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex ,0);
        SceneManager.LoadScene("Game");

    }

}
