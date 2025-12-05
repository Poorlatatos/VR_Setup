using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.XR.CoreUtils;
using TMPro;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public TMP_Text wrongCredentialsText;
    public void AttemptLogin()
    {   
        if (IsValidCredentials(usernameInput.text, passwordInput.text))
        {
            Debug.Log("Login successful!");
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            Debug.Log("Invalid username or password.");
            wrongCredentialsText.text = "Invalid username or password.";
        }
    }

    private bool IsValidCredentials(string user, string pass)
    {
        // Placeholder for actual authentication logic
        return user == "admin" && pass == "password123";
    }

}
