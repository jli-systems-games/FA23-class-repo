using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }

    private Data _gameData;
    private List<IDataPersistence> _dataPersistences;

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("There can't be more than one data manager!");
        }

        Instance = this;
    }

    private void Start()
    {
        this._dataPersistences = FindAllPersistenceObjects();

        NewGame();

    }
    public void NewGame()
    {
        this._gameData = new Data();
    }

    public void LoadGame()
    {
        //load save data

        //if no data to load, throw a message
        if(this._gameData == null)
        {
            Debug.Log("No data to load!");
        }

        foreach (IDataPersistence dataPs in _dataPersistences)
        {
            dataPs.LoadData(_gameData);
        }

        Debug.Log("Load health " + _gameData.health.ToString());
        //put data in all the scripts that need it
    }

    public void SaveGame()
    {
        //put data in scripts thats need to be updated
        foreach (IDataPersistence dataPs in _dataPersistences)
        {
            dataPs.SaveData(ref _gameData);
        }

        Debug.Log("Save health " + _gameData.health.ToString());
        //save data to file using our file handler
    }

    public void OnApplicationQuit()
    {
        SaveGame();
    }
    private List<IDataPersistence> FindAllPersistenceObjects()
    {
        IEnumerable<IDataPersistence> dataPersistences =
            FindObjectsOfType<MonoBehaviour>()
            .OfType<IDataPersistence>();

        return new List<IDataPersistence>(dataPersistences);
    }
}

