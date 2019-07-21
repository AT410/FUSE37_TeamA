using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Director : MonoBehaviour
{
    [SerializeField]
    AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            var audio = this.gameObject.AddComponent<AudioSource>();
            audio.PlayOneShot(clip);

            
            StartCoroutine(CoroutineLoadScene());
        }
    }

    IEnumerator CoroutineLoadScene()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("MainScene");
    }
}
