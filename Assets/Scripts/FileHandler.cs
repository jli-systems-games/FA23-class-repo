using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FileHandler
{
    /*private void Start()
    {
        CreateText();
    }

    void CreateText()
    {
        string path = Application.dataPath + "/Log.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Hello World!" + "\n");
        }

        string content = System.DateTime.Now + "\n";
        File.AppendAllText(path, content);
    }*/

    private string _dataDirectoryPath = "";
    private string _dataFileName = "";

    public FileHandler(string dataDirectoryPath, string dataFileName)
    {
        this._dataDirectoryPath = dataDirectoryPath;
        this._dataFileName = dataFileName;
    }


    public Data Load()
    {
        string fullPathName = Path.Combine(_dataDirectoryPath, _dataFileName);
        Data loadedData = null;

        if (File.Exists(fullPathName))
        {

            try
            {
                string dataToLoad = "";

                using (FileStream stream = new FileStream(fullPathName, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        dataToLoad = reader.ReadToEnd();
                    }
                }

                loadedData = JsonUtility.FromJson<Data>(dataToLoad);
            }
            catch
            {
                Debug.LogError("Can't save data.");
            }
            return loadedData;
        }
    }


    public void Save(Data data)
    {
        string fullPathName = Path.Combine(_dataDirectoryPath, _dataFileName);

        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fullPathName));

            string dataToStore = JsonUtility.ToJson(data, true);

            using(FileStream stream = new FileStream(fullPathName, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataToStore);
                }
            }
        }
        catch
        {
            Debug.LogError("Can't save data.");
        }
    }
}
