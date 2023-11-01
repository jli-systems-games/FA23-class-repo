using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FileHandler 
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        //CreateText();
    }

    void CreateText()
    {
        string path = Application.dataPath + "/Log.txt";

        if (!File.Exists(path))
        {
            File.WriteAllText(path, "Hello world." + "\n");
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

    //public Data Load(){}

    public void Save(Data data)
    {

    }
}
