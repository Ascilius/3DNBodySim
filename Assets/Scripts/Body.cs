using UnityEngine;

public class Body : MonoBehaviour
{

   static private double G = 0.0000000000667430; // Gravitational constant

   [SerializeField] private double mass = 1.0; 
   [SerializeField] private Vector3 velocity = new Vector3(0.0f, 0.0f, 0.0f);
   [SerializeField] private Vector3 acceleration = new Vector3(0.0f, 0.0f, 0.0f);

   // Start is called once before the first execution of Update after the MonoBehaviour is created
   void Start()
   {
      
   }

   // Update is called once per frame
   void Update()
   {
      
   }

   // Calculates interaction between this and another body
   public void Interact(GameObject other, double dt)
   {
      Body otherBody = other.GetComponent<Body>();
      double otherMass = otherBody.GetMass();

      Vector3 r = this.transform.position - other.transform.position;

      Vector3 F = G * mass * otherMass / Math.Pow(r, 2); // TOFIX
      
      Accelerate(F, dt);
      other.Accelerate(F, dt);
   }

   public void Accelerate(Vector3 F, double dt)

   public double GetMass() { return mass; }
}
