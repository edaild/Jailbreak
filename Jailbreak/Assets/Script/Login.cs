using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
public class Login : MonoBehaviour
{
    public InputField userIdInput;      // ���� ���̵�
    public InputField userPassInput;    // ���� ��й�ȣ

    public GameObject loginMenuUI;
    public GameObject membershipMenuUI;

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }

    public void OnButtonClick_membershipButton()   // �ɹ��� ��ư
    {
        loginMenuUI.SetActive(false);
        membershipMenuUI.SetActive(true);
    }
}
