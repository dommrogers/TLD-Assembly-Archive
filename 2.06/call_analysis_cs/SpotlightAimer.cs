using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class SpotlightAimer : MonoBehaviour
{
	private bool m_AimOnStart;

	private Transform m_AimTarget;

	private Transform m_PitchPivotControl;

	private Transform m_YawPivotControl;

	private Transform m_OverheadLight;

	private float m_OverheadLightDistance;

	[CalledBy(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[CalledBy(Type = typeof(SpotLightController), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public Vector3 GetLightSourceOrigin()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(SpotlightAimer), Member = "Start")]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateSpotLight")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SpotlightAimer), Member = "GetLightSourceOrigin")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	public void AimAtPosition(Vector3 aimPosition)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDrawGizmos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public SpotlightAimer()
	{
	}
}
