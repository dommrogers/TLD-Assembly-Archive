using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PKInstance
{
	public BoxCollider m_Collider;

	public bool m_KillsFallingSnow;

	public bool m_KillsBlowingSnow;

	public Bounds BoundingBox
	{
		[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Bounds);
		}
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "InitializeForScene")]
	[CallerCount(Count = 1)]
	public PKInstance(BoxCollider bc)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "InitializeForScene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public PKInstance(ParticleKiller pk)
	{
	}

	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "ClosestPointOnBounds")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool ShouldUpdate(Vector3 camPos)
	{
		return false;
	}
}
