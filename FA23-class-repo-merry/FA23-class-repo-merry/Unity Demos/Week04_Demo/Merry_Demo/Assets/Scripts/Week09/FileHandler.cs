using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FileHandler
{

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
    void Start()
    {
        //CreateText();
    }


    void CreateText()
    {
        string path = Application.dataPath + "/RUN.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE NIGHTMARE" + "\n");
        }

        string content = System.DateTime.Now + "\n";
        File.AppendAllText(path, content);
    }
}
