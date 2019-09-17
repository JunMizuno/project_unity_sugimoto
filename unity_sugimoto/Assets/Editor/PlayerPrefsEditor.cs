using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerPrefsEditor
{
    [MenuItem("Tools/PlayerPrefs/DeleteAllData")]
    static void DeleteAllData()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Delete All Data Of PlayerPrefs");
    }
}
