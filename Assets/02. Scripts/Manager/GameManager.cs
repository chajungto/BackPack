using UnityEngine;

public class GameManager : MonoBehaviour
{
    //�̱��� �ν��Ͻ�
    public static GameManager Instance { get; private set; }

    public Player Player;
    public TalkManager TalkManager;

    private void Awake()
    {
        //�̹� �ν��Ͻ��� ������ �ڽ��� �ı� 
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        //�ν��Ͻ��� �Ҵ�
        Instance = this;
        //�ı� ����
        DontDestroyOnLoad(gameObject);
    }
}