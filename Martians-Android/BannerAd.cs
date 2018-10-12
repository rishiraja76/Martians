using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class BannerAd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Create a 320x50 banner at the top of the screen.
		BannerView bannerView = new BannerView(
			"ca-app-pub-8704420972648104/7760692073", AdSize.Banner, AdPosition.Top);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
		bannerView.LoadAd(request);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
