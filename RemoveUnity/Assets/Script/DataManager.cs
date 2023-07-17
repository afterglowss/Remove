using System.IO;
using UnityEngine;
using Yarn.Unity;

[System.Serializable]
public class Data
{
    public bool sawStoryScene;
    public bool sawTrueEnding;
    public bool sawEnding1;
    public bool sawEnding2;
    public bool sawEnding3;
    public bool sawEnding4;
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
    public static void SetTrueSawTrueEnding()
    {
        instance.data.sawTrueEnding = true;
        instance.SaveData();
    }
    [YarnCommand("setTrueSawEnding1")]
    public static void SetTrueSawEnding1()
    {
        instance.data.sawEnding1 = true;
        instance.SaveData();
    }
    [YarnCommand("setTrueSawEnding2")]
    public static void SetTrueSawEnding2()
    {
        instance.data.sawEnding2 = true;
        instance.SaveData();
    }
    [YarnCommand("setTrueSawEnding3")]
    public static void SetTrueSawEnding3()
    {
        instance.data.sawEnding3 = true;
        instance.SaveData();
    }
    [YarnCommand("setTrueSawEnding4")]
    public static void SetTrueSawEnding4()
    {
        instance.data.sawEnding4 = true;
        instance.SaveData();
    }

    [YarnCommand("isSawEnding")]
    public static bool IsSawEnding(int ending)
    {
        instance.LoadData();
        switch (ending)
        {
            case 1:
                if (instance.data.sawEnding1)
                    return true;
                break;
            case 2:
                if (instance.data.sawEnding2)
                    return true;
                break;
            case 3:
                if (instance.data.sawEnding3)
                    return true;
                break;
            case 4:
                if (instance.data.sawEnding4)
                    return true;
                break;
            case 5:
                if (instance.data.sawTrueEnding)
                    return true;
                break;
            default:
                return false;
        }
        return false;
    }
}
