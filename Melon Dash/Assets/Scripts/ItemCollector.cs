using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text melonsText;
    [SerializeField] private AudioSource collectionSound;

    private int totalMelons;

    public int melonCount;

    private void Start()
    {
        totalMelons = GameObject.FindGameObjectsWithTag("Melon").Length;

        melonsText.text = "Melons: 0" + " / " + totalMelons;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Melon"))
        {
            Destroy(collision.gameObject);
            melonCount++;
            melonsText.text = "Melons: " + melonCount + " / " + totalMelons;
            collectionSound.Play();
        }
    }
}
