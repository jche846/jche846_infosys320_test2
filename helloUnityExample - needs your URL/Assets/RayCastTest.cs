using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RayCastTest : MonoBehaviour{
	GameObject panel;
	public GameObject myPrefab;


	void Start(){

		panel=(GameObject) Instantiate(myPrefab, new Vector3(0,0,0), Quaternion.identity);
	}


	void Update(){
		if (Input.GetMouseButtonDown (0)) 
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit, 100)) 
			{
				hit.collider.gameObject.GetComponentInChildren<TextMesh> ().color = new Color ( Random.value, Random.value, Random.value, 1.0f );	
				panel.GetComponentInChildren<Text> ().text = "X:" +hit.collider.gameObject.transform.position.x +","+
					"Y:"+hit.collider.gameObject.transform.position.y+"," +
					"Z:"+hit.collider.gameObject.transform.position.z + "";
			
			}

		}

	}

}
