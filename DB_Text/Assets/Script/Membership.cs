using UnityEngine;
using UnityEngine.UI;
public class Membership : MonoBehaviour
{
    public InputField userIdInput;                  // 유저 아이디
    public InputField userPasswordInput;            // 유저 비밀번호
    public InputField userRecheckPasswordInput;     // 유저 비밀번호 재확인
    public InputField userNameInput;                // 유저 이름
    public InputField UseremailInput;               // 유저 이메일

    public GameObject LoginmenuUI;
    public GameObject membershipmenuUI;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void OnButtonClick_LogInButton()
    {
        membershipmenuUI.SetActive(false);
        LoginmenuUI.SetActive(true);
    }
}
