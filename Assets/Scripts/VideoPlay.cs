using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour {

	public Material playBtnMat;
	public Material pauseBtnMat;
	public Renderer screenRenderer;

	private VideoPlayer videoPlayer;

	void Awake(){
		videoPlayer = GetComponent<VideoPlayer>();
	}

	// Use this for initialization
	void Start () {
	
	}
	
    public void PlayPause(){
    	if (videoPlayer.isPlaying){
    		videoPlayer.Pause();
    		screenRenderer.material = playBtnMat;
    	} else {
    		videoPlayer.Play();
    		screenRenderer.material = pauseBtnMat;
    	}
    }
}