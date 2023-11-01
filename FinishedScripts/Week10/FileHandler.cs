using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class FileHandler 
{
    //keep it monobehavioour first
    #region Basic Write to file
    /*void Start()
    {
        CreateText();
    }

    void CreateText() 
    {
        string path = Application.dataPath + "/Log.txt";//file path

        //create file if it doesn't exist
        if (!File.Exists(path)) //check if "path" exists
        {
            File.WriteAllText(path, "Hello \n \n"); //write all text overrides file
        }

        //content of file
        string content = System.DateTime.Now + "\n";
        //add some text to it
        File.AppendAllText(path, content); //append adds it at end

    }*/
    #endregion

    private string dataDirectoryPath = ""; //where will it save the data on the computer
    private string dataFileName = ""; //name of file we want to save to

    //lets make a public constructor to assign both of these
    //because this isnt a monobeahviour, we need a way to initialize this class in our scene, and give it initial values
    public FileHandler(string dataDirectoryPath, string dataFileName)
    {
        this.dataDirectoryPath = dataDirectoryPath;
        this.dataFileName = dataFileName;
    }
   
    public Data Load() //needs to return what it is loading in
    {
        string fullPathName = Path.Combine(dataDirectoryPath, dataFileName);
        Data loadedData = null; //placeholder

        //make sure file we want to load from exists
        if(File.Exists(fullPathName))
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

                //need to turn json back to game data - or "deserialize" it
                loadedData = JsonUtility.FromJson<Data>(dataToLoad);

            }
            catch
            {
                Debug.LogError("Can't load data");
            }
        }
        return loadedData;
    }

    public void Save(Data data) //needs to take in what it is saving - WE DO THIS BEFORE LOAD
    {
        string fullPathName = Path.Combine(dataDirectoryPath, dataFileName); //use path.cmbine cos different os may have different path
                                                                             //seperators other than the standard "/"
        try
        {
            //create the directory the file will be written to if it doesn't already exist
            Directory.CreateDirectory(Path.GetDirectoryName(fullPathName));

            //change our game data into a string for our json file
            string dataToStore = JsonUtility.ToJson(data, true); //true makes it more formatted and nice

            //write to file now that it has been converted, or "serialized"
            using (FileStream stream = new FileStream(fullPathName, FileMode.Create)) //you don't have to use using, but it closes the
                                                                                      //door for us after we are done,
                                                                                      //otherwise we have to manually do it
            {
                using(StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataToStore);
                }
            }
        }
        catch
        {
            Debug.LogError("Can't save data");
        }

    }
}
