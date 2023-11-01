using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; 

public class DataPersistenceManager : MonoBehaviour
{

    #region Set up before interface
    /*
    public static DataPersistenceManager Instance { get; private set; } //we can access it publically,
                                                                        //but only this class can set it

    private Data _gameData;

    private void Awake()
    {
        if (Instance != null)//cos this is a monobehaviour, we have to manually check this ourselves
        {
            Debug.LogError("There can't be more than one Data Persistence Manager in a scene!");
        }

        Instance = this;
    }


    public void NewGame() //singletons are like static classes but more flexable, though more intensive. 
                          //to call it elsewhere, you call its instance you set up - DataPersistenceManager.Instance.NewGame();
    {
        this._gameData = new Data(); //initialize our data
    }

    public void LoadGame()
    {
        //load save data from a file

        //if no data to load, throw message
        if (this._gameData == null)
        {
            Debug.Log("No data found");
            //we could just initialize a new game here, or put whatever other catch we want here
        }

        //put data in all other scripts that need it
    }

    public void SaveGame()
    {
        //put data in scripts that need to be updated

        //save data to a file using the data handler
    }

    public void OnApplicationQuit()
    {
        SaveGame();
    }

    */
    #endregion

    #region Before FileHandler with json

    /*
    public static DataPersistenceManager Instance { get; private set; } 
                                                                        

    private Data _gameData;
    private List<IDataPersistence> _dataPersistences; //ADD LIST

    private void Awake() 
    {
        if (Instance != null)
        {
            Debug.LogError("There can't be more than one Data Persistence Manager in a scene!");
        }

        Instance = this; 
    }

    private void Start() //ADD START
    {
        this._dataPersistences = FindAllDataPersistenceObjects(); //type this, then add class

        NewGame();
        //if we want our intialization of 0 to override our 10, we would LoadGame here
        //LoadGame();
    }

    public void NewGame() 
                          
    {
        this._gameData = new Data(); 
    }

    public void LoadGame()
    {

        if(this._gameData == null)
        {
            Debug.Log("No data found");
        }

        foreach (IDataPersistence dataPs in _dataPersistences) //add me after adding findalldata function
        {
            dataPs.LoadData(_gameData);
        }

        Debug.Log("Load Health " + _gameData.health.ToString());

    }

    public void SaveGame()
    {
        //put data in scripts that need to be updated
        foreach (IDataPersistence dataPs in _dataPersistences) //add me after adding findalldata function
        {
            dataPs.SaveData(ref _gameData);
        }

        Debug.Log("Save Health " + _gameData.health.ToString());

        //save data to a file using the data handler
    }

    public void OnApplicationQuit()
    {
        SaveGame();
    }

    private List<IDataPersistence> FindAllDataPersistenceObjects()
    {
        //because we using including linq, we can use the following line to find all objects in scene using our interface!
        IEnumerable<IDataPersistence> dataPersistences = FindObjectsOfType<MonoBehaviour>()
            .OfType<IDataPersistence>();

        //return that list
        return new List<IDataPersistence>(dataPersistences);
    }
    */

    #endregion

    #region Work with filehandler
    
    
    public static DataPersistenceManager Instance { get; private set; }

    //ADD file storage config
    public string fileName;
    private FileHandler fileHandler;


    private Data _gameData;
    private List<IDataPersistence> _dataPersistences; 

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There can't be more than one Data Persistence Manager in a scene!");
        }

        Instance = this;
    }

    private void Start() 
    {
        this.fileHandler = new FileHandler(Application.persistentDataPath, fileName); //ADD HANDLER INITIALIZATION
        //applicaiton.persistentdatapath is wherever your os wants to save unity game data. unity takes care of this for you
        //you probably don't need to change this for standard saving, but might be worth playing with if you 
        //want people to find stuff...
        //check where it goes here docs.unity3d.com/ScriptReference/Application-persistentDataPath.html

        this._dataPersistences = FindAllDataPersistenceObjects(); 

        LoadGame();

    }

    public void NewGame()

    {
        this._gameData = new Data();
    }

    public void LoadGame()
    {
        this._gameData = fileHandler.Load(); //ADD THIS
        //it will return null if it found nothing, giving us our debug.log!

        if (this._gameData == null)
        {
            Debug.Log("No data found");
            //do something
        }

        foreach (IDataPersistence dataPs in _dataPersistences) 
        {
            dataPs.LoadData(_gameData);
        }

        Debug.Log("Load Health " + _gameData.health.ToString());

    }

    public void SaveGame()
    {
        
        foreach (IDataPersistence dataPs in _dataPersistences) 
        {
            dataPs.SaveData(ref _gameData);
        }

        Debug.Log("Save Health " + _gameData.health.ToString());

        //save data to a file using the data handler
        fileHandler.Save(_gameData); //ADD THIS
    }

    public void OnApplicationQuit()
    {
        SaveGame();
    }

    private List<IDataPersistence> FindAllDataPersistenceObjects()
    {
        
        IEnumerable<IDataPersistence> dataPersistences = FindObjectsOfType<MonoBehaviour>()
            .OfType<IDataPersistence>();

        //return that list
        return new List<IDataPersistence>(dataPersistences);
    }

    #endregion
}
