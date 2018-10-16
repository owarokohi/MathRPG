﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MathRPG {
    public class Journal : MonoBehaviour
    {   
        //can assign field in inspector even if private
        [SerializeField] Text logText;
        public static Journal Instance { get; set; }
        // Use this for initialization
        void Awake()
        {
            if (Instance != null&&Instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                Instance = this;
            }
        }

        public void Log(string text)
        {
            logText.text += "\n" + text;
        }
    }
}

