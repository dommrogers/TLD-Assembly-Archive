using Cpp2ILInjected.CallAnalysis;
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BaseAi), Member = "SetAiMode")]
	[CallerCount(Count = 0)]
	public void EnablePackBehavior(bool enable)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(BaseAi), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BaseAi), Member = "GetMoveAgent")]
	[CallsUnknownMethods(Count = 9)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PackManager), Member = "UnregisterPackAnimal")]
	[CallsUnknownMethods(Count = 2)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PackAnimal()
	{
	}
}
