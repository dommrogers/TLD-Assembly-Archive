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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public PackAnimal()
	{
	}
}
