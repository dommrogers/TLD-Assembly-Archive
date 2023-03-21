using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Inspect : MonoBehaviour
{
	private class InspectSaveData
	{
		public bool m_SkipInspectVO;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public InspectSaveData()
		{
		}
	}

	public GameObject m_InspectModeMesh;

	public GameObject m_NormalMesh;

	public bool m_IgnoreMouse;

	public float m_DistanceFromCamera;

	public bool m_OverrideDepthOfFieldFocalDistance;

	public float m_DepthOfFieldFocalDistance;

	public Vector3 m_Offset;

	public Vector3 m_Angles;

	public Vector3 m_Scale;

	public Vector3 m_RndAngles;

	public string m_OverrideInspectVO;

	public bool m_SkipInspectVO;

	private uint m_Urgency;

	private bool m_DidSetUrgency;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 40)]
	[CalledBy(Type = typeof(PlayerManager), Member = "MaybePlayInspectModeVoiceOver")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(Inspect), Member = "SetUrgencyIfHigher")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inspect), Member = "SetUrgencyIfHigher")]
	[Calls(Type = typeof(Inspect), Member = "SetUrgencyIfHigher")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inspect), Member = "SetUrgencyIfHigher")]
	[Calls(Type = typeof(Inspect), Member = "SetUrgencyIfHigher")]
	[Calls(Type = typeof(Inspect), Member = "SetUrgencyIfHigher")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inspect), Member = "SetUrgencyIfHigher")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Inspect), Member = "SetUrgencyIfHigher")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public uint GetUrgency()
	{
		return default(uint);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	public void Deserialize(string serialized)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 8)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Inspect), Member = "GetUrgency")]
	private void SetUrgencyIfHigher(uint newUrgency)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Inspect()
	{
	}
}
