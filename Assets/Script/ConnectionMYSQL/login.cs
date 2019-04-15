using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour
{
    public InputField playerName;
    public InputField playerPass;

    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(Login());
    }

    IEnumerator Login()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", playerName.text);
        form.AddField("password", playerPass.text);
        WWW www = new WWW("http://localhost/connexionmysqlunity/login.php");

        yield return www;

        if(www.text[0] == '0')
        {
            Debug.Log("Connected");
        }
        else
        {
            Debug.Log("user Log Failed" + www.text);
        }

    }
}
