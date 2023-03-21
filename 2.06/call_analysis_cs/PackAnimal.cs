using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class PackAnimal : MonoBehaviour
{
	public bool m_CanBeLeader;

	public bool m_ShouldStayWithinRadiusOfStartLocation;

	public bool m_UsePackDetection;

	public string m_GroupId;

	public float m_StayWithinRadius;

	public float m_StayWithinMinRadius;

	public PackMode m_PackMode;

	public BaseAi m_BaseAi;

	public PackAnimal m_GroupLeader;

	public Vector3 m_StartLocation;

	public float m_HoldGroundTime;

	public float m_PackReformDelayTimer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallsUnknownMethods(Count = 1)]
	public void EnablePackBehavior(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public PackAnimal()
	{
	}
}
