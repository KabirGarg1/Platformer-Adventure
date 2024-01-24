using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollectable : MonoBehaviour
{
    [SerializeField] private Text cherriesText;
    private int cherries;
    [SerializeField] private AudioSource cherrySound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            cherrySound.Play();
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = "Cherries:" + cherries;
        }
    }
}
