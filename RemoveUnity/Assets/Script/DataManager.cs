using System.IO;
using UnityEngine;
using Yarn.Unity;
using System.Security.Cryptography;
using System.Collections.Generic;
using static Cinemachine.DocumentationSortingAttribute;

[System.Serializable]
public class Data
{
    public bool sawStoryScene;
    public bool sawTrueEnding;
    public bool sawEnding1;
    public bool sawEnding2;
    public bool sawEnding3;
    public bool sawEnding4;

    public Data(bool sawStoryScene, bool sawTrueEnding, bool sawEnding1, bool sawEnding2, bool sawEnding3, bool sawEnding4)
    {
        this.sawStoryScene = sawStoryScene;
        this.sawTrueEnding = sawTrueEnding;
        this.sawEnding1 = sawEnding1;
        this.sawEnding2 = sawEnding2;
        this.sawEnding3 = sawEnding3;
        this.sawEnding4 = sawEnding4;
    }

}

public class DataManager : MonoBehaviour
{
    private static readonly string privateKey = "1718hy9dsf0jsdlfjds0pa9ids78ahgf81h32re";

    public Data data = new Data(false, false, false, false, false, false);
    //N65pRnwCAoNdGPdtNvEbbmj4EHt83AH7fjKy61cAOsJ7SEzlkn6JO/i9bNeQblWrRdGZ8qW+EAjuYlugUOZltn+nPmPXQrdMfsa+BcMjCEnGj2basYyKDqi7aRMSv7fYLbRVVKaCLpijN+zSiI0OpeZyiia0VaieyLsCX9k6uSY=
    string path;

    public static DataManager instance;
    private void Awake()
    {
        path = GetPath();
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(instance);
        }

        //Save();       //이거 잠깐 켰다가 끄면 모든 변수 false 처리됨.
        
    }
    public static void Save()
    {
        string jsonString = DataToJson(instance.data);
        string encryptString = Encrypt(jsonString);
        SaveFile(encryptString);
    }

    public static void Load()
    {
        if (!File.Exists(GetPath()))
        {
            Debug.Log("세이브 파일이 존재하지 않음.");
            return;
        }
        string encryptData = LoadFile(GetPath());
        //Debug.Log(encryptData);
        string decryptData = Decrypt(encryptData);

        //Debug.Log(decryptData);

        instance.data = JsonToData(decryptData);
    }
    static string DataToJson(Data data)
    {
        string jsonData = JsonUtility.ToJson(data);
        return jsonData;
    }

    //json string을 SaveData로 변환
    static Data JsonToData(string jsonData)
    {
        instance.data = JsonUtility.FromJson<Data>(jsonData);
        return instance.data;
    }

    static string GetPath()
    {
        return Path.Combine(Application.dataPath, "database.json");
    }

    static string GetTestPath()
    {
        return Path.Combine(Application.dataPath, "test.json");
    }
    private void Start()
    {
        //LoadData();
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

    //json string을 파일로 저장
    static void SaveFile(string jsonData)
    {
        using (FileStream fs = new FileStream(GetPath(), FileMode.Create, FileAccess.Write))
        {
            //파일로 저장할 수 있게 바이트화
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(jsonData);

            //bytes의 내용물을 0 ~ max 길이까지 fs에 복사
            fs.Write(bytes, 0, bytes.Length);
        }
    }

    //파일 불러오기
    static string LoadFile(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            //파일을 바이트화 했을 때 담을 변수를 제작
            byte[] bytes = new byte[(int)fs.Length];

            //파일스트림으로 부터 바이트 추출
            fs.Read(bytes, 0, (int)fs.Length);

            //추출한 바이트를 json string으로 인코딩
            string jsonString = System.Text.Encoding.UTF8.GetString(bytes);
            return jsonString;
        }
    }

    ////////////////////////////////////////////////////////////////////////////////////////

    private static string Encrypt(string data)
    {

        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(data);
        RijndaelManaged rm = CreateRijndaelManaged();
        ICryptoTransform ct = rm.CreateEncryptor();
        byte[] results = ct.TransformFinalBlock(bytes, 0, bytes.Length);
        return System.Convert.ToBase64String(results, 0, results.Length);

    }

    private static string Decrypt(string data)
    {

        byte[] bytes = System.Convert.FromBase64String(data);
        RijndaelManaged rm = CreateRijndaelManaged();
        ICryptoTransform ct = rm.CreateDecryptor();
        byte[] resultArray = ct.TransformFinalBlock(bytes, 0, bytes.Length);
        return System.Text.Encoding.UTF8.GetString(resultArray);
    }


    private static RijndaelManaged CreateRijndaelManaged()
    {
        byte[] keyArray = System.Text.Encoding.UTF8.GetBytes(privateKey);
        RijndaelManaged result = new RijndaelManaged();

        byte[] newKeysArray = new byte[16];
        System.Array.Copy(keyArray, 0, newKeysArray, 0, 16);

        result.Key = newKeysArray;
        result.Mode = CipherMode.ECB;
        result.Padding = PaddingMode.PKCS7;
        return result;
    }

    ////////////////////////////////////////////////////////////////////////////////////////


    [YarnFunction("getSawStoryScene")]
    public static bool GetSawStoryScene()
    {
        Load();
        return instance.data.sawStoryScene;
    }

    [YarnCommand("setTrueSawStoryScene")]
    public static void SetTrueSawStoryScene()
    {
        instance.data.sawStoryScene = true;
        Save();
    }
    [YarnFunction("getSawTrueEnding")]
    public static bool GetSawTrueEnding()
    {
        Load();
        return instance.data.sawTrueEnding;
    }
    [YarnCommand("setTrueSawTrueEnding")]
    public static void SetTrueSawTrueEnding()
    {
        instance.data.sawTrueEnding = true;
        Save();
    }
    [YarnCommand("setTrueSawEnding1")]
    public static void SetTrueSawEnding1()
    {
        instance.data.sawEnding1 = true;
        Save();
    }
    [YarnCommand("setTrueSawEnding2")]
    public static void SetTrueSawEnding2()
    {
        instance.data.sawEnding2 = true;
        Save();
    }
    [YarnCommand("setTrueSawEnding3")]
    public static void SetTrueSawEnding3()
    {
        instance.data.sawEnding3 = true;
        Save();
    }
    [YarnCommand("setTrueSawEnding4")]
    public static void SetTrueSawEnding4()
    {
        instance.data.sawEnding4 = true;
        Save();
    }

    [YarnCommand("isSawEnding")]
    public static bool IsSawEnding(int ending)
    {
        Load();
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
