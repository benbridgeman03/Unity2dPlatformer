using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GetBestTimes : MonoBehaviour
{
    [SerializeField] private Text level1TimeText;
    [SerializeField] private Text level2TimeText;
    [SerializeField] private Text level3TimeText;

    private void Start()
    {
        level1TimeText.text = PlayerPrefs.GetString("Level 1");
        level2TimeText.text = PlayerPrefs.GetString("Level 2");
        level3TimeText.text = PlayerPrefs.GetString("Level 3");
    }

}
