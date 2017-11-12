using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CompleteGame : MonoBehaviour
{

    public AudioSource a;
    private bool colliding = false;


    void OnCollisionEnter(Collision collide)
    {
        if (colliding == false)
        {
            StartCoroutine(playCollide());

        }


        if (collide.gameObject.tag == "EndPoint")
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    IEnumerator playCollide()
    {
        
        colliding = true;
        a.Play();
        yield return new WaitForSeconds(3f);

        colliding = false;

    }
}
