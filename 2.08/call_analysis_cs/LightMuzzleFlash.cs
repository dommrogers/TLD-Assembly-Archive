using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightMuzzleFlash : MonoBehaviour
{
	public float duration;

	public float intensity;

	public float radius;

	private float durTimer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Light), Member = "set_range")]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Shoot()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LightMuzzleFlash()
	{
	}
}
