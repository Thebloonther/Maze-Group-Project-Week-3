using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneTrans : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadSampleScene()
    {
        SceneManager.LoadScene("Level01");
    }
}
