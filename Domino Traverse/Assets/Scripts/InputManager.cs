using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://forum.unity.com/threads/can-i-modify-the-input-manager-via-script.458800/
public static class InputManager
{
    static Dictionary<string, string> keyDictionary;

    static string[] keyMaps = new string[6]
    {
        "GroundJump",
        "Boost",
        "Block",
        "Lock",
        "Freeze",
        "Slow"
    };

    static string[] defaults = new string[6]
    {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6"
    };

    public static void InitializeDictionary()
    {
        keyDictionary= new Dictionary<string, string>();
        for (int i = 0; i < keyMaps.Length; ++i) 
        {
            keyDictionary.Add(keyMaps[i], defaults[i]);
        }
    }

    public static void UpdateDictionary(string action, string newKey)
    {
        keyDictionary[action] = newKey;
    }

    public static string GetActionKey(string action)
    {
        return keyDictionary[action];
    }
}
