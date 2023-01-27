using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlController : MonoBehaviour
{
    [SerializeField] InputField GroundJump;
    [SerializeField] InputField Boost;
    [SerializeField] InputField Block;
    [SerializeField] InputField Lock;
    [SerializeField] InputField Freeze;

    public void SaveGroundJump()
    {
        InputManager.UpdateDictionary("GroundJump", GroundJump.text);
        PlayerPrefs.SetString("GroundJump", GroundJump.text);
    }


    public void SaveBoost()
    {
        InputManager.UpdateDictionary("Boost", Boost.text);
        PlayerPrefs.SetString("Boost", Boost.text);
    }

    public void SaveBlock()
    {
        InputManager.UpdateDictionary("Block", Block.text);
        PlayerPrefs.SetString("Block", Block.text);
    }

    public void SaveLock()
    {
        InputManager.UpdateDictionary("Lock", Lock.text);
        PlayerPrefs.SetString("Lock", Lock.text);
    }

    public void SaveFreeze()
    {
        InputManager.UpdateDictionary("Freeze", Freeze.text);
        PlayerPrefs.SetString("Freeze", Freeze.text);
    }
}
