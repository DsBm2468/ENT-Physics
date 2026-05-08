using UnityEngine;

public class WildForce : MonoBehaviour, IForceGenerator
{
    [Header("Conexión")]
    // Aquí va lo que tu fuerza necesita: una partícula, un transform, etc.
    public float ImpactRange = 10f;
    public bool GlobalImpact = false;

    [Header("Parámetros")]
    // Aquí van los floats/vectores que controlan tu fuerza.
    public Vector3 windDirection = Vector3.right; // Inicialmente, a pesar de los ajustes posteriores, empezara la fuerza hacia la derecha
    public float strength = 5f;
    public float turbulenceIntensity = 2f;
    public float turbulenceFrequency = 1.5f;

    private void OnEnable() { ParticleWorld.Register((IForceGenerator)this); }
    
    private void OnDisable() { ParticleWorld.Unregister((IForceGenerator)this); }
    
    public void ApplyForces(float dt)
    {
        // Calcular la fuerza y aplicarla con particula.AddForce(...)
       

        foreach (Particle p in ParticleWorld.All)
        {
            // Fuerza del viento, con los valores que ya se tenian anteriormente hacen que funcione
            p.AddForce(windDirection * strength);
        }
    }

    private void OnDrawGizmos()
    {
        // Visualización para debug.
    }
}
