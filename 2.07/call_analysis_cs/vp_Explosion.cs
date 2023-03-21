using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class vp_Explosion : MonoBehaviour
{
	public float Radius;

	public float Force;

	public float UpForce;

	public float Damage;

	public float CameraShake;

	public string DamageMethodName;

	public AudioClip Sound;

	public float SoundMinPitch;

	public float SoundMaxPitch;

	public List<GameObject> FXPrefabs;

	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoBomb")]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[Calls(Type = typeof(Rigidbody), Member = "AddExplosionForce")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 47)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public vp_Explosion()
	{
	}
}
