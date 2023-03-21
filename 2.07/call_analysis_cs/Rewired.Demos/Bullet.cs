using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Rewired.Demos;

public class Bullet : MonoBehaviour
{
	public float lifeTime;

	private bool die;

	private float deathTime;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public Bullet()
	{
	}
}
