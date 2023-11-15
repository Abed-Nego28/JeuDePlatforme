using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting;

public class Control : MonoBehaviour
{

    public void ResetTheScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Scene has been reset");
    }
}
