using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class StartGame : MonoBehaviour
{
    public AudioClip audioClip;

    private AudioSource audioSource;

    void Start()
    {
        if (GetComponent<AudioSource>() == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        else
        {
            audioSource = GetComponent<AudioSource>();
        }
        
        audioSource.clip = audioClip;
    }

    public void PlayAudio()
    {
        // Play the audio
        audioSource.Play();

        // Start a coroutine to delay the scene transition
        StartCoroutine(LoadSceneAfterAudio());
    }

    IEnumerator LoadSceneAfterAudio()
    {
        // Wait until the audio has finished playing
        yield return new WaitForSeconds(audioClip.length);

        // Load the next scene
        SceneManager.LoadScene("Menu");
    }
}
