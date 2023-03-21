using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectAnim : MonoBehaviour
{
	public GameObject m_Target;

	private iTweenEvent[] m_Events;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ObjectAnim), Member = "Initialize")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(ObjectAnim), Member = "Start")]
	public void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[CalledBy(Type = typeof(Container), Member = "IsPlayingAnimation")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CalledBy(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	public bool IsAnimating()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(WoodStove), Member = "Close")]
	[CalledBy(Type = typeof(WoodStove), Member = "Open")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Container), Member = "PlayAnimation")]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[Calls(Type = typeof(iTweenEvent), Member = "Play")]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ObjectAnim()
	{
	}
}
