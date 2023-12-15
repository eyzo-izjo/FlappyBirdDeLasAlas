using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{

    /*AudioSource audioSource;
    public AudioClip yipClip;*/

    
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Goose>()  != null)
        {
            GameControl.Instance.GooseScored();
            
        }
        //PlaySound(yipClip);
    }

   /* public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }*/
}
