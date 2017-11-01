using System;
using UnityEngine;

public class UrlHelper : MonoBehaviour {
   private const string URL = "https://credentials-handler-vorby.c9users.io/Login.php?Act={0}&User={1}&Pass={2}";
    
    public static string ConstructUrl(string action,string login, string password)
    {
        if (!InputIsOkay(action, login, password)) throw new Exception("The input was not correct!");
        return string.Format(URL, action,login,password);
    }

    private static bool InputIsOkay(string action, string login, string password)
    {
        Debug.Log(action + login + password);
        return (!string.IsNullOrEmpty(action) && !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password) && login.Length < 51 && password.Length < 51);
    }
}
