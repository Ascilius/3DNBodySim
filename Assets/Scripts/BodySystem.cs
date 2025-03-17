using System.Collections.Generic;
using UnityEngine;

public class BodySystem : MonoBehaviour
{

   private List<GameObject> bodies = new List<GameObject>();

   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {
      RandomSystem(50);
   }
   
   // Update is called once per frame
   void Update()
   {
      
   }

   // Generates a random system of n bodies
   private void RandomSystem(int n)
   {
      for (int i = 0; i < n; i++)
      {
         Vector3 loc = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f));
         Debug.Log(loc);
         GameObject body = new GameObject("Body");
         MeshFilter mf = body.AddComponent(typeof(MeshFilter)) as MeshFilter;
         mf.mesh = Resources.GetBuiltinResource<Mesh>("Sphere.fbx");
         body.AddComponent<MeshRenderer>();
         body.AddComponent<Body>();
         body.transform.position = loc;
         body.transform.parent = this.transform;
         bodies.Add(body);
      }
   }
}
