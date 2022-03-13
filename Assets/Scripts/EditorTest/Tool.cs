using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Tool
{
    //指定路径菜单栏增加选项
    //可用快捷键
    //% Ctrl
    //# Shift
    //& Alt
    //LEFT/RIGHT/UP/DOWN 上下左右
    //F1...F12
    //HOME END PGUP PGDN
    [MenuItem("Tool/Clear PlayerPrefs %#C")]
    static void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    //


    //指定组件增加右键选项
    [MenuItem("CONTEXT/Player/AddExp2000")]
    static void PlayerAddExp(MenuCommand menuCommand)
    {
        Player player = menuCommand.context as Player;
        player.AddExp(2000);
    }
    
    //选项有效性验证函数
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
