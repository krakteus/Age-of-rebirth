using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField playerName;
    public InputField playerPass;
    SceneMan sceneLoad;
    public Button submitButton;
    private void Start()
    {
        sceneLoad = new SceneMan();
    }
    public void CallLogin()
    {
        StartCoroutine(Loginn());
    }

    IEnumerator Loginn()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", playerName.text);
        form.AddField("password", playerPass.text);
        WWW www = new WWW("http://localhost/connexionmysqlunity/login.php");

        yield return www;

        if(www.text[0] == '0')
        {
            Debug.Log("Connected");
            sceneLoad.CallSelectScene();
        }
        else
        {
            Debug.Log("user Log Failed" + www.text);
        }

    }
}
