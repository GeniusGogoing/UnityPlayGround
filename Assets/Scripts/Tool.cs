using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Tool
{
    [MenuItem("Tool/Clear PlayerPrefs %#C")]
    static void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }


    //Assets Assets/Create
    [MenuItem("CONTEXT/Player/AddExp2000")]
    static void PlayerAddExp(MenuCommand menuCommand)
    {
        Player player = menuCommand.context as Player;
        player.AddExp(2000);
    }

    [MenuItem("CONTEXT/Player/AddExp", true)]
    static bool PlayerAddExpValidation()
    {
        return Selection.activeObject.name == "Player";
    }

    [MenuItem("CONTEXT/Player/ReduceExp2000", false, 1)]
    static void PlayerReduceExp(MenuCommand menuCommand)
    {
        Player player = menuCommand.context as Player;
        player.AddExp(-2000);
    }
}
