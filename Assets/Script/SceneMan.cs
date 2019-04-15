using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void CallRegisterScene()
    {
        SceneManager.LoadScene(1);
    }
    public void CallLoginScene()
    {
        SceneManager.LoadScene(2);
    }
    public void CallSelectScene()
    {
        SceneManager.LoadScene(0);
    }
}
