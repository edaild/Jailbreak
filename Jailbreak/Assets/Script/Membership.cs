using UnityEngine;
using UnityEngine.UI;
public class Membership : MonoBehaviour
{
    public InputField userIdInput;                  // ���� ���̵�
    public InputField userPasswordInput;            // ���� ��й�ȣ
    public InputField userRecheckPasswordInput;     // ���� ��й�ȣ ��Ȯ��
    public InputField userNameInput;                // ���� �̸�
    public InputField UseremailInput;               // ���� �̸���

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
