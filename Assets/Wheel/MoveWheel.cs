using UnityEngine;
using System.Collections;

public class MoveWheel : MonoBehaviour {

	// Use this for initialization
	Transform wheelTransform;
    Rigidbody wheelrigidBody;
    ImageLoaderScript imagescript;
    GameObject[] crateObjects = new GameObject[30];
	void Start () {
		wheelTransform = this.gameObject.GetComponent<Transform>() as Transform;
        wheelrigidBody = this.gameObject.GetComponent<Rigidbody>() as Rigidbody;
        imagescript = this.gameObject.GetComponent<ImageLoaderScript>() as ImageLoaderScript;
        crateObjects = GameObject.FindGameObjectsWithTag("Player");
        InvokeRepeating("AddTorqueImpluse", 1,3);
    }
	
	// Update is called once per frame
	void Update () {
        // this.gameObject.transform.RotateAround(Vector3.forward, 10 * Time.deltaTime);
        
	
	}

    void AddTorqueImpluse()
    {
        float val = Random.Range(-1, 1);
        wheelrigidBody.AddForceAtPosition( Vector3.right * 1000,  Vector3.down  , ForceMode.Impulse);
        Debug.Log("Invoke Called");
        foreach(GameObject value in crateObjects)
        {
            imagescript = value.GetComponent<ImageLoaderScript>() as ImageLoaderScript;
            imagescript.TriggerLoadImage();
        }
        
    }

    void FixedUpdate()
    {
     //   wheelrigidBody.AddTorque(Vector3.forward * Time.fixedDeltaTime);
    }
}
