using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletParticleSystem : MonoBehaviour
{
    public static BulletParticleSystem Instance;

    private ParticleSystem particles;

    private void Awake()
    {
        Instance = this;
    }

    public void Emit(Vector3 position, float angle, float speed)
    {
        ParticleSystem.EmitParams emitParams = new ParticleSystem.EmitParams();
        emitParams.position = position;
        //emitParams.velocity = velocity;
        //emitParams.applyShapeToPosition = true;
        //emitParams.rotation = 45.0f;
        //emitParams.angularVelocity = angle;
        //emitParams.angularVelocity3D = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0);
        emitParams.velocity = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * speed;
        particles.Emit(emitParams, 1);
    }

}
