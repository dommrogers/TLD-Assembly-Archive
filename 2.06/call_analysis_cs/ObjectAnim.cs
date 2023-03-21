using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectAnim : MonoBehaviour
{
	public GameObject m_Target;

	private iTweenEvent[] m_Events;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[CalledBy(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Container), Member = "IsPlayingAnimation")]
	public bool IsAnimating()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CalledBy(Type = typeof(WoodStove), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(Container), Member = "PlayAnimation")]
	[CalledBy(Type = typeof(WoodStove), Member = "Close")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(iTweenEvent), Member = "Play")]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	public bool Play(string name)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CallsUnknownMethods(Count = 3)]
	public void GoToEndImmediate()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ObjectAnim()
	{
	}
}
