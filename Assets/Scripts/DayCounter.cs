using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayTransition : MonoBehaviour
{

    public TMP_Text DayDisplay;

    public static int day;

    private void Start()
    {
        DayGoingBy2();
    }

    public void DayGoingBy2()
    {
        day++;
        DayDisplay.text = string.Format("Day {0}", day);
    }

}
