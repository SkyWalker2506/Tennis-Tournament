using System.IO;
using UnityEditor;
using UnityEngine;

public class OutputWriter : MonoBehaviour
{
    [SerializeField] TextAsset outputText;
    [SerializeField] InputConverter inputConverter;

    private void Start()
    {
        SaveData();
    }

    void SaveData()
    {
        var tournamentsString = JsonUtility.ToJson(inputConverter.Tournaments);
        Debug.Log(tournamentsString);
        File.WriteAllText(AssetDatabase.GetAssetPath(outputText), tournamentsString);
    }
}
