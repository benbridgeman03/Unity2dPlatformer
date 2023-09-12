using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text melonsText;
    [SerializeField] private AudioSource collectionSound;
    public int melonCount;

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
