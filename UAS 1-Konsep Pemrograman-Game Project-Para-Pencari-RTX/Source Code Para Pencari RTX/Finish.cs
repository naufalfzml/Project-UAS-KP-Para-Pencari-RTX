using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource suaraFinish;
    private bool selesaiLevel = false;
    // Start is called before the first frame update
    private void Start()
    {
        suaraFinish = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player" && !selesaiLevel)  
        {
            suaraFinish.Play();
            selesaiLevel = true;
            Invoke("LevelSelesai", 1.5f);
        }  
    }
    
    private void LevelSelesai()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
  
}
