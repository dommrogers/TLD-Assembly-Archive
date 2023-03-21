using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class Inspect : MonoBehaviour
{
	private class InspectSaveData
	{
		public bool m_SkipInspectVO;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	[CalledBy(Type = typeof(PlayerManager), Member = "MaybePlayInspectModeVoiceOver")]
	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	public uint GetUrgency()
	{
		return default(uint);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Deserialize(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private void SetUrgencyIfHigher(uint newUrgency)
	{
	}

	[CallerCount(Count = 0)]
	public Inspect()
	{
	}
}
