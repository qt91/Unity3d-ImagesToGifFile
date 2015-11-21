using UnityEngine;
using System.Collections;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using Gif.Components;


public class CreateGif : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public  void ClickGenerateGif()
    {
        /* create Gif */
        String[] imageFilePaths = new String[] { "1.jpg", "2.jpg", "3.jpg" };
        String outputFilePath = Application.streamingAssetsPath+"\\test.gif";
        AnimatedGifEncoder e = new AnimatedGifEncoder();
        e.Start(outputFilePath);
        e.SetDelay(500);
        //-1:no repeat,0:always repeat
        e.SetRepeat(0);
        for (int i = 0, count = imageFilePaths.Length; i < count; i++)
        {
            e.AddFrame(Image.FromFile(Application.streamingAssetsPath+"\\Resources\\"+imageFilePaths[i]));
        }
        e.Finish();

        /* extract Gif */
        //string outputPath = "c:\\";
        GifDecoder gifDecoder = new GifDecoder();
        gifDecoder.Read(outputFilePath);


        //for (int i = 0, count = gifDecoder.GetFrameCount(); i < count; i++)
        //{
        //    Image frame = gifDecoder.GetFrame(i);  // frame i
        //    frame.Save(outputPath + Guid.NewGuid().ToString() + ".png", ImageFormat.Png);
        //}
    }
}
