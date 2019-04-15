using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    public InputField playersName;
    public InputField playersPass;


    public Button submitButton;
    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", playersName.text);
        form.AddField("password", playersPass.text);

        WWW www = new WWW("http://localhost/connexionmysqlunity/register.php", form);



        yield return www;

        if(www.text =="0")
        {
            Debug.Log("Created succes. Welcome");
           

        }
        else
        {
            Debug.Log("Failed" + www.text);
        }
    }
}
