
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadSpecificScene : MonoBehaviour
{
    public string sceneName;
    public Animator fadeSystem;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            Debug.Log("Player has entered the trigger");
        {
            StartCoroutine(loadNextScene());
        }
    }

    public void LoadScene()
    {
        StartCoroutine(loadNextScene());
    }

    public IEnumerator loadNextScene()
    {
        fadeSystem.SetTrigger("FadeIn");
        yield return new WaitForSeconds(1f);
        Debug.Log(sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
