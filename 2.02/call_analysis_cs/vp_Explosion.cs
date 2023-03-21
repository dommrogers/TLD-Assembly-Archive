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

	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "DoBomb")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(vp_FPSController), Member = "AddForce")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Rigidbody), Member = "AddExplosionForce")]
	[Calls(Type = typeof(Physics), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(AudioSource), Member = "Play")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(AudioSource), Member = "set_playOnAwake")]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(AudioSource), Member = "set_dopplerLevel")]
	[Calls(Type = typeof(AudioSource), Member = "set_clip")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[CallsDeduplicatedMethods(Count = 36)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Physics), Member = "OverlapSphere")]
	private void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public vp_Explosion()
	{
	}
}
