using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLIne : MonoBehaviour
{
    [SerializeField] float restartDelay = 3f;
    void OnTriggerEnter2D(Collider2D collision)
    {
        int layerIndex = LayerMask.NameToLayer("Player");

        if (collision.gameObject.layer == layerIndex)
        {
            Invoke("ReloadScene", restartDelay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }


}
