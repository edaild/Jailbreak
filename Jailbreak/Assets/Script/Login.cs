using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class Login : MonoBehaviour
{
    // �ӽ� ���̵�� ���
    public string id = "root";
    public string pw = "root";
    public string name = "GM������";

    public InputField userIdInput;      // ���� ���̵�
    public InputField userPassInput;    // ���� ��й�ȣ


    public GameObject loginMenuUI;          // �α��� �޴�UI
    public GameObject membershipMenuUI;     // ȸ������ �޴�UI
    public GameObject gameStart;            // ���� ���� ��ư
    public GameObject functionUI;
    public Text functionText;


    // ���� ����
    private bool logincheck;                // �α��� üũ Ȯ�� ����

    private void Update()
    {

    }
    public void OnButtonClick_LogInButton()     // �α��� ��ư
    {
        string userId = userIdInput.text;       // �Է¹��� ���̵�
        string userpw = userPassInput.text;     // �Է¹��� ��й�ȣ

        if (userId != id || userpw != pw)
        {
            functionUI.SetActive(true);
            functionText.text = "���̵�� ��й�ȣ�� �ٽ� Ȯ���� �ֽÿ�.";

            Invoke("HideFunctionText", 3);          // Ȯ�� �޼��� ��Ȱ��ȭ
        }
        else if (userId == id && userpw == pw)
        {
            logincheck = true;                      // �α��� ����
            loginMenuUI.SetActive(false);
            functionUI.SetActive(true);
            functionText.text = $"{name}�� ���� �湮�� ȯ���մϴ�.";

            Invoke("HideFunctionText", 3);

        }

    }
    
    private void HideFunctionText()
    {
        functionUI.SetActive(false);
    }
    public void OnButtonClick_membershipButton()   // �ɹ��� ��ư
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
            SceneManager.LoadScene("GameScene");            // Game Scene �����̵�
        }
    }
       
}
