using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void SceneChange(int i)
    {
        SceneManager.LoadScene(i);
    }

    public void TimeStart()
    {
        
        Time.timeScale=1f;
    }
}
