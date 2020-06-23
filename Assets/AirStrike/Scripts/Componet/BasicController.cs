/// <summary>
/// Basic controller.
/// </summary>

using UnityEngine;
using System.Collections;

public class BasicController : MonoBehaviour {
	public Vector3 BattlePosition; // middle of battle area position
	public BattleCenter CenterOfBattle; //  middle of battle area object (optional)
	public float FlyDistance = 1000;// limited distance
	private Vector3 forward = new Vector3(0, 0, 1);
	private Vector3 backward = new Vector3(0, 0, -1);
	private Vector3 left = new Vector3(1, 0, 0);
	private Vector3 right = new Vector3(-1, 0, 0);
	private Vector3 forleft = new Vector3(0, 1, 0);
	private Vector3 forright = new Vector3(0, -1, 0);
	private Vector3 newPosition;
	void Start () {
		if (!CenterOfBattle)
		{
			if (!CenterOfBattle)
			{
				BattleCenter btcenter = (BattleCenter)GameObject.FindObjectOfType(typeof(BattleCenter));
				if (btcenter != null)
					CenterOfBattle = btcenter.gameObject.GetComponent<BattleCenter>();
			}
		}
	}
	// Update is called once per frame
	void Update () {
		if (CenterOfBattle)
			// CenterOfBattle is exist , BattlePosition = CenterOfBattle position 
			//in case of able you to changing the battle area
			BattlePosition = CenterOfBattle.gameObject.transform.position;

		if (Input.GetKey(KeyCode.W)){
				this.newPosition = this.transform.position + forward;
					//new Vector3(0,0,1);
		}
		if(Input.GetKey(KeyCode.A)){
				this.newPosition = this.transform.position + left;// new Vector3(1,0,0);
		}
		if(Input.GetKey(KeyCode.S)){
				this.newPosition = this.transform.position + backward;// new Vector3(0,0,-1);
		}
		if(Input.GetKey(KeyCode.D)){
				this.newPosition = this.transform.position + right;// new Vector3(-1,0,0);
		}
		if(Input.GetKey(KeyCode.Q)){
				this.newPosition = this.transform.position + forleft;// new Vector3(0,1,0);
		}
		if(Input.GetKey(KeyCode.E)){
				this.newPosition = this.transform.position + forright;// new Vector3(0,-1,0);
		}

		if (Vector3.Distance(this.transform.position,this.newPosition) != 0 && Vector3.Distance(BattlePosition, this.newPosition) < FlyDistance)
		{
			this.transform.position = newPosition;
		}
		else
		{
			this.newPosition = this.transform.position;
		}
	}
}
