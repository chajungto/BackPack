using UnityEngine;

public class GameManager : MonoBehaviour
{
    //싱글톤 인스턴스
    public static GameManager Instance { get; private set; }

    public Player Player;
    public TalkManager TalkManager;

    private void Awake()
    {
        //이미 인스턴스가 있으면 자신을 파괴 
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        //인스턴스를 할당
        Instance = this;
        //파괴 방지
        DontDestroyOnLoad(gameObject);
    }
}