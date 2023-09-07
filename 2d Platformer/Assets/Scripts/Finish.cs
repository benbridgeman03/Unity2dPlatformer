using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    private Animator anim;
    private ItemCollector itemCollector;

    private bool finished;
    private int totalMelons;
    private bool allMelons;
    private void Start()
    {
        finishSound = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        itemCollector = FindObjectOfType<ItemCollector>();

        totalMelons = GameObject.FindGameObjectsWithTag("Melon").Length;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int melonCount = itemCollector.melonCount;
        if (collision.gameObject.name == "Player" && melonCount == totalMelons && !finished)
        {
            finishSound.Play();
            finished = true;
            anim.SetTrigger("Finish");

        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
