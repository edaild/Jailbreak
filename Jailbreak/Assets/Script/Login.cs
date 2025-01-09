using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class Login : MonoBehaviour
{
    // 임시 아이디와 비번
    public string id = "root";
    public string pw = "root";
    public string name = "GM릴리에";

    public InputField userIdInput;      // 유저 아이디
    public InputField userPassInput;    // 유저 비밀번호


    public GameObject loginMenuUI;          // 로그인 메뉴UI
    public GameObject membershipMenuUI;     // 회원가입 메뉴UI
    public GameObject gameStart;            // 게임 시작 버튼
    public GameObject functionUI;
    public Text functionText;


    // 내부 변수
    private bool logincheck;                // 로그인 체크 확인 여부

    private void Update()
    {

    }
    public void OnButtonClick_LogInButton()     // 로그인 버튼
    {
        string userId = userIdInput.text;       // 입력받은 아이디
        string userpw = userPassInput.text;     // 입력받은 비밀번호

        if (userId != id || userpw != pw)
        {
            functionUI.SetActive(true);
            functionText.text = "아이디와 비밀번호를 다시 확인해 주시오.";

            Invoke("HideFunctionText", 3);          // 확인 메세지 비활성화
        }
        else if (userId == id && userpw == pw)
        {
            logincheck = true;                      // 로그인 승인
            loginMenuUI.SetActive(false);
            functionUI.SetActive(true);
            functionText.text = $"{name}님 게임 방문을 환영합니다.";

            Invoke("HideFunctionText", 3);

        }

    }
    
    private void HideFunctionText()
    {
        functionUI.SetActive(false);
    }
    public void OnButtonClick_membershipButton()   // 맴버쉽 버튼
    {
        loginMenuUI.SetActive(false);
        membershipMenuUI.SetActive(true);
    }

    public void OnButtonclick_Gamestart()
    {
        if (!logincheck)
        {
            loginMenuUI.SetActive(true);                   
        }
        else
        {
            SceneManager.LoadScene("GameScene");            // Game Scene 으로이동
        }
    }
       
}
