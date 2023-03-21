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

	[CalledBy(Type = typeof(SpotLightController), Member = "Start")]
	[CalledBy(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public Vector3 GetLightSourceOrigin()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateSpotLight")]
	[CalledBy(Type = typeof(SpotlightAimer), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SpotlightAimer), Member = "GetLightSourceOrigin")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 13)]
	public void AimAtPosition(Vector3 aimPosition)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDrawGizmos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public SpotlightAimer()
	{
	}
}
