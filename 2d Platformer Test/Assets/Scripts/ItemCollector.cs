using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int melonCount = 0;

    [SerializeField] private Text melonsText;

    [SerializeField] private AudioSource collectionSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Melon"))
        {
            Destroy(collision.gameObject);
            melonCount++;
            melonsText.text = "Melons: " + melonCount;

            collectionSound.Play();
        }
    }
}
