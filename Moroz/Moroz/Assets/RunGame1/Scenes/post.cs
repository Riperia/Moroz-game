using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class post : MonoBehaviour
{
    public void nachalok(string scene_name)
    {
        // Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene(scene_name);

    }
}
