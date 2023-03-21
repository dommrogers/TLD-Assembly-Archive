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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[CalledBy(Type = typeof(SpotLightController), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	public Vector3 GetLightSourceOrigin()
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(SpotlightAimer), Member = "Start")]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateSpotLight")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(SpotlightAimer), Member = "GetLightSourceOrigin")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_localEulerAngles")]
	public void AimAtPosition(Vector3 aimPosition)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(SpotlightAimer), Member = "AimAtPosition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
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
