using UnityEngine;

[CreateAssetMenu(fileName = "NewNPC", menuName = "NPC/NPCData")]

public class NPCData : ScriptableObject
{
    //NPC 아이디
    [SerializeField] private string npcId;
    public string NpcId { get { return npcId; } set { npcId = value; } }

    //NPC 이름
    [SerializeField] private string npcName;        
    public string NpcName { get { return npcName; } set { npcName = value; } }
}   
