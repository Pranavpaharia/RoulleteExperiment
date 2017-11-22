using UnityEngine;
using System.Collections;

public class ImageLoaderScript : MonoBehaviour {

    // Use this for initialization
    SpriteRenderer wheelImgRender;
    public string url;
	void Start () {
  //      wheelImgRender = this.GetComponent<SpriteRenderer>() as SpriteRenderer;

        
	
	}


    IEnumerator LoadImage()
    {
        WWW www = new WWW(url);
        yield return www;

  //      wheelImgRender.sprite = Sprite.Create(www.texture, new Rect(new Vector2(0, 0), new Vector2(www.texture.width / 2, www.texture.height)), 
  //                                              new Vector2(this.transform.localPosition.x / 2, this.transform.localPosition.y / 2)
   //                                             );
    }

    public void TriggerLoadImage()
    {
        StartCoroutine("LoadImage");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
