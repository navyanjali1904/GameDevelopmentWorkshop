using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVoice : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] enemySounds;
    public float minTimeBetweenSounds = 3.0f;
    public float maxTimeBetweenSounds = 8.0f;

    private bool canPlaySound = true;

    private void Start()
    {
        // Assuming the AudioSource component is attached in the Inspector
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

        // Start the coroutine to play random sounds
        StartCoroutine(PlayRandomSound());
    }

    private IEnumerator PlayRandomSound()
    {
        while (true)
        {
            if (canPlaySound)
            {
                // Randomly select an enemy sound
                AudioClip selectedClip = enemySounds[Random.Range(0, enemySounds.Length)];

                // Play the selected sound
                audioSource.clip = selectedClip;
                audioSource.Play();

                // Calculate a random time interval before playing the next sound
                float randomTime = Random.Range(minTimeBetweenSounds, maxTimeBetweenSounds);
                canPlaySound = false;

                // Wait for the interval before allowing another sound to be played
                yield return new WaitForSeconds(randomTime);

                canPlaySound = true;
            }

            yield return null;
        }
    }
}
