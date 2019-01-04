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
        if (Input.GetMouseButtonDown(0))
        {
            WSANativeFilePicker.PickSingleFile("Select", WSAPickerViewMode.Thumbnail, WSAPickerLocationId.PicturesLibrary, new[] {".txt"}, result =>
            {
                fileString = "aaa";
                if (result != null)
                {
#pragma warning disable 0219
                    fileBytes = result.ReadBytes();
                    fileString = result.ReadText();
#pragma warning restore 0219
                }
            });
        }
        scoreLabel.text = fileString;
        if (Input.GetMouseButtonDown(1))
        {
            WSANativeFilePicker.PickSaveFile("Save", ".txt", "Test Text File", WSAPickerLocationId.DocumentsLibrary, new List<KeyValuePair<string, IList<string>>>() { new KeyValuePair<string, IList<string>>("Text Files", new List<string>() { ".txt" }) }, result =>
            {
                if (result != null)
                {
                    //result.WriteBytes(new byte[2]);
                    result.WriteText("Hello World");
                }
            });
        }
    }
}
