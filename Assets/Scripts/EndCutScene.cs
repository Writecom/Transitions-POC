using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndCutScene : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("GameScene");
    }

}