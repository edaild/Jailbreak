using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class Login : MonoBehaviour
{
    public InputField userIdInput;      // 유저 아이디
    public InputField userPassInput;    // 유저 비밀번호

    public GameObject loginMenuUI;
    public GameObject membershipMenuUI;
    public GameObject gameStart;

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }

    public void OnButtonClick_membershipButton()   // 맴버쉽 버튼
    {
        loginMenuUI.SetActive(false);
        membershipMenuUI.SetActive(true);
    }

    public void OnButtonclick_Gamestart()
    {
        loginMenuUI.SetActive(true);
    }
}
