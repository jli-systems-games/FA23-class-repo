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

    public void Save(Data data)
    {

    }
}
