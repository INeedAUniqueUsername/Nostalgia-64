﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Control {
    public KeyCode key;
    public GameObject action;
}
public class PlayerController : MonoBehaviour {
    /*
     * https://answers.unity.com/questions/762073/c-list-of-string-name-for-inputgetkeystring-name.html
    private var keys : String[] = [
        "backspace",
        "delete",
        "tab",
        "clear",
        "return",
        "pause",
        "escape",
        "space",
        "up",
        "down",
        "right",
        "left",
        "insert",
        "home",
        "end",
        "page up",
        "page down",
        "f1",
        "f2",
        "f3",
        "f4",
        "f5",
        "f6",
        "f7",
        "f8",
        "f9",
        "f10",
        "f11",
        "f12",
        "f13",
        "f14",
        "f15",
        "0",
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "!",
        "\"",
        "#",
        "$",
        "&",
        "'",
        "(",
        ")",
        "*",
        "+",
        ",",
        "-",
        ".",
        "/",
        ":",
        ";",
        "<",
        "=",
        ">",
        "?",
        "@",
        "[",
        "\\",
        "]",
        "^",
        "_",
        "`",
        "a",
        "b",
        "c",
        "d",
        "e",
        "f",
        "g",
        "h",
        "i",
        "j",
        "k",
        "l",
        "m",
        "n",
        "o",
        "p",
        "q",
        "r",
        "s",
        "t",
        "u",
        "v",
        "w",
        "x",
        "y",
        "z",
        "numlock",
        "caps lock",
        "scroll lock",
        "right shift",
        "left shift",
        "right ctrl",
        "left ctrl",
        "right alt",
        "left alt"
        ];
    */
    public Control[] controls;
    void Start() {
        
    }
    void Update() {
        for(int i = 0; i < controls.Length; i++) {
            if(Input.GetKey(controls[i].key)) {
                print(controls[i].key + " key activated");
                controls[i].action.GetComponent<IDevice>().Activate();
            }
        }
    }
}