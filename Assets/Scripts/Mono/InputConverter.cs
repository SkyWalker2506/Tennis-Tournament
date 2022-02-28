using UnityEngine;

public class InputConverter : MonoBehaviour
{
    [SerializeField] TextAsset inputText;
    public Players Players;
    public Tournaments Tournaments;
    
    void Awake()
    {
        LoadData();
    }

    void LoadData()
    {
        Players = JsonUtility.FromJson<Players>(inputText.ToString());
        Tournaments = JsonUtility.FromJson<Tournaments>(inputText.ToString());
    }
}
