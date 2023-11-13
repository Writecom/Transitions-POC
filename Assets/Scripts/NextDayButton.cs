using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextDayButton : MonoBehaviour
{
    public void transition(string SceneName)
    {
        SceneManager.LoadScene(SceneName);

    }

}
