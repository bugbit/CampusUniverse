using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplicationController : MonoBehaviour
{
    [SerializeField] private bool isDedicateServer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Launch();
    }

    void Launch()
    {
        Application.targetFrameRate = 60;

        // Si es server, se inicializa el servidor y se carga la escena del game
        // En otro caso se carga la escena del menu
        if (isDedicateServer || Application.platform == RuntimePlatform.LinuxServer || Application.platform == RuntimePlatform.OSXServer || Application.platform == RuntimePlatform.WindowsServer)
        {

        }
        else
            SceneManager.LoadScene("MainMenu");
    }
}
