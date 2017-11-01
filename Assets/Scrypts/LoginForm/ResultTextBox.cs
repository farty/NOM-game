using UnityEngine;
using UnityEngine.UI;

public class ResultTextBox : MonoBehaviour {

    private static Text _text;

    public static void SetTextBox(Text textBox)
    {
        _text = textBox;
    }

    public static void SetResultMessage(string message, bool wasSuccessful=false)
    {
        _text = GameObject.Find("Message").GetComponent<Text>();
        if (wasSuccessful) _text.color = Color.green;
        else _text.color = Color.red;
        _text.text = message;
    }

    public static void Clear()
    {
        _text.text = "";
    }
}
