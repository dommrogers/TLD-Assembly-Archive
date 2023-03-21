using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PKInstance
{
	public BoxCollider m_Collider;

	public bool m_KillsFallingSnow;

	public bool m_KillsBlowingSnow;

	public Bounds BoundingBox
	{
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
		get
		{
			return default(Bounds);
		}
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "InitializeForScene")]
	public PKInstance(BoxCollider bc)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "InitializeForScene")]
	[CallsUnknownMethods(Count = 2)]
	public PKInstance(ParticleKiller pk)
	{
	}

	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Collider), Member = "ClosestPointOnBounds")]
	[CalledBy(Type = typeof(WeatherParticleManager), Member = "LateUpdate_part1")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public bool ShouldUpdate(Vector3 camPos)
	{
		return default(bool);
	}
}
