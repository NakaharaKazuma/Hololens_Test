using System.Collections;
using System.Collections.Generic;

using System.Collections.Generic;
using CI.WSANative.Advertising;
using CI.WSANative.Device;
using CI.WSANative.Dialogs;
using CI.WSANative.Facebook;
using CI.WSANative.FileStorage;
using CI.WSANative.IAPStore;
using CI.WSANative.Mapping;
using CI.WSANative.Notification;
using CI.WSANative.Pickers;
using CI.WSANative.Security;
using CI.WSANative.Serialisers;
using CI.WSANative.Twitter;
using UnityEngine;
using System.IO;


public class Game : MonoBehaviour {

    public UnityEngine.UI.Text scoreLabel;

    byte[] fileBytes;

    string fileString = "aa";

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            string path = "/data/text.txt";
            StreamWriter writer = new System.IO.StreamWriter(path, false);
            writer.Write("Hello world\n");
        }        
    }
}
