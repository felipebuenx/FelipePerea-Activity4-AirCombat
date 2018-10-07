using System.Collections; using System.Collections.Generic; using UnityEngine;  public class MissileMotion : MonoBehaviour {      public float translationpeed;    // Use this for initialization  void Start () {             }       // Update is called once per frame  void Update () {         this.transform.Translate(Vector3.forward);

        this.transform.Translate(0, 0, translationpeed);

    }      void OnCollisionEnter(Collision collision){         Debug.Log("Colision entre dos colliders");          //Destruir misil         GameObject.Destroy(this.gameObject);          //Destruir enemigo         GameObject.Destroy(collision.collider.gameObject);     } } 