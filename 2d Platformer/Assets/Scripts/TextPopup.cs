using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPopup : MonoBehaviour
{
    [SerializeField]private Text displayText;
    [SerializeField]private Button displayButton;
    [SerializeField]private float displayDuration = 2f;
    private float displayTimer = 0f;
    private bool isDisplaying = false;

    // Start is called before the first frame update
    void Start()
    {
        displayText.gameObject.SetActive(false);

        displayButton.onClick.AddListener(ShowText);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDisplaying)
        {
            displayTimer += Time.deltaTime;
            if(displayTimer >= displayDuration)
            {
                HideText();
            }
        }
        
    }

    private void ShowText()
    {
        displayText.gameObject.SetActive(true);
        isDisplaying = true;
        displayTimer = 0f;
    }

    private void HideText()
    {
        displayText.gameObject.SetActive(false);
        isDisplaying = false;
    }
}
