using UnityEngine;
using System.Collections;

public class Down_Hide : MonoBehaviour
{
    public AudioClip keySound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            audioSource.PlayOneShot(keySound);

            StartCoroutine(HideAfterSound());
        }
    }

    private IEnumerator HideAfterSound()
    {
        yield return new WaitForSeconds(keySound.length);

        gameObject.SetActive(false);
    }
}