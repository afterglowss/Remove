using System.IO;
using UnityEngine;
using Yarn.Unity;

[System.Serializable]
public class Data
{
    public bool sawStoryScene;
    public bool sawTrueEnding;
}

public class DataManager : MonoBehaviour
{
    Data data = new Data();

    string path;

    public static DataManager instance;
    private void Awake()
    {
        path = Path.Combine(Application.dataPath, "database.json");
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(instance);
        }
    }
    private void Start()
    {
        string loadJson = File.ReadAllText(path);
        data = JsonUtility.FromJson<Data>(loadJson);
    }
    public void LoadData()
    {
        string loadJson = File.ReadAllText(path);
        data = JsonUtility.FromJson<Data>(loadJson);
    }
    public void SaveData()
    {
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(path, json);
    }

    [YarnFunction("getSawStoryScene")]
    public static bool GetSawStoryScene()
    {
        instance.LoadData();
        return instance.data.sawStoryScene;
    }

    [YarnCommand("setTrueSawStoryScene")]
    public static void SetTrueSawStoryScene()
    {
        instance.data.sawStoryScene = true;
        instance.SaveData();
    }
    [YarnFunction("getSawTrueEnding")]
    public static bool GetSawTrueEnding()
    {
        instance.LoadData();
        return instance.data.sawTrueEnding;
    }
    [YarnCommand("setTrueSawTrueEnding")]
    public static void SetTrueIsBlizzardCleared()
    {
        instance.data.sawTrueEnding = true;
        instance.SaveData();
    }

}
