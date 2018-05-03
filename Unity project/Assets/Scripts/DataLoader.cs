using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataLoader : MonoBehaviour {

    public string[] itms;
    public InputField username;
    public InputField password;
    public GameObject Message;

    private Text MessageText;

	// Use this for initialization
    void Start()
    {
        MessageText = Message.GetComponentInChildren<Text>();
        print(MessageText.text);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator logintoDB()
    {
        MessageText.text = "Loading data ...";
        WWWForm form = new WWWForm();
        form.AddField("username", username.text);
        form.AddField("password", password.text);


        WWW answer = new WWW("localhost/unitytest/login.php", form);


        yield return answer;

        int answerInt = int.Parse(answer.text);

        switch(answerInt) {
            case (1):

                MessageText.text = "Login success";
                break;
            case (0):

                MessageText.text = "Password incorrect";
                break;
            case (-1):

                MessageText.text = "UserName incorrect";
                break;
            default:

                MessageText.text = "Entry username and password";
                break;
        }

    }
    public void Login()
    {

        if (username.text.Equals("") || username.text == null)
        {
            MessageText.text = "Entry your username";
            return;
        }
        if (password.text.Equals("") || password.text == null)
        {
            MessageText.text = "Entry your password";
            return;
        }

        StartCoroutine(logintoDB());
    }

}
