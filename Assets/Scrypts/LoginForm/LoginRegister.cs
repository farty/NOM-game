using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginRegister : MonoBehaviour {

    InputField _loginInput, _passwordInput;
    private IEnumerator corutine;

	// Use this for initialization
	void Start () {
        _loginInput = GameObject.Find("LoginInput").GetComponent<InputField>();
        _passwordInput = GameObject.Find("PassInput").GetComponent<InputField>();
        ResultTextBox.SetTextBox(GameObject.Find("Message").GetComponent<Text>());
    }
	
    public void LoginOnClick()
    {
        corutine=WebAction("Login");
        StartCoroutine(corutine);
        Debug.Log("Login click!");
    }

    public void ResgisterOnClick()
    {
        corutine = WebAction("Register");
        StartCoroutine(corutine);
        Debug.Log("Register click!");
    }

    private IEnumerator WebAction(string action)
    {
        var url = UrlHelper.ConstructUrl(action, _loginInput.text, _passwordInput.text);
        var username = _loginInput.text;
        var request = new WWW(url);
        _loginInput.text = "";
        _passwordInput.text = "";
        yield return request;
        Debug.Log(request.text);
        if(request.error != null)
        {
            ResultTextBox.SetResultMessage(request.error);
        }
        else
        {
            if(request.text.Trim() == "Correct")
            {
                ResultTextBox.SetResultMessage("Login Succesful!",true);
                yield return new WaitForSeconds(5);
                PlayerPrefs.SetString("Username", username);
                SceneManager.LoadScene(21);
            }
            if(request.text.Trim() == "Wrong"|| request.text.Trim() == "No User")
            {
                ResultTextBox.SetResultMessage("Incorrect login or password");
                yield return new WaitForSeconds(5);
                ResultTextBox.Clear();
            }
            if(request.text.Trim() == "ERROR")
            {
                ResultTextBox.SetResultMessage("Error accured, retarting...");
                yield return new WaitForSeconds(5);
                SceneManager.LoadScene(20);
            }
            if(request.text.Trim() == "ILLEGAL REQUEST")
            {
                ResultTextBox.SetResultMessage("Internal server error!");
                yield return new WaitForSeconds(5);
                ResultTextBox.Clear();
            }
            if(request.text.Trim()== "Registered")
            {
                //Should we log user in as soon as they register?
                ResultTextBox.SetResultMessage("Registration Succesful! Now you can login.", true);
                yield return new WaitForSeconds(5);
                ResultTextBox.Clear();
            }
            if (request.text.Trim() == "TAKEN")
            {
                ResultTextBox.SetResultMessage("This username is already taken!");
                yield return new WaitForSeconds(5);
                ResultTextBox.Clear();
            }
        }
        request.Dispose();
    }
}
