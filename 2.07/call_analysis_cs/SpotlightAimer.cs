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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[CalledBy(Type = typeof(SpotLightController), Member = "Start")]
	[CallsUnknownMethods(Count = 4)]
	public Vector3 GetLightSourceOrigin()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateSpotLight")]
	[CalledBy(Type = typeof(SpotlightAimer), Member = "Start")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(SpotlightAimer), Member = "GetLightSourceOrigin")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	public void AimAtPosition(Vector3 aimPosition)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDrawGizmos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SpotlightAimer()
	{
	}
}
