using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectAnim : MonoBehaviour
{
	public GameObject m_Target;

	private iTweenEvent[] m_Events;

	[Calls(Type = typeof(ObjectAnim), Member = "Initialize")]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ObjectAnim), Member = "Start")]
	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[CallsUnknownMethods(Count = 1)]
	public void Initialize()
	{
	}

	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[CalledBy(Type = typeof(Container), Member = "IsPlayingAnimation")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CalledBy(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[CallsUnknownMethods(Count = 2)]
	public bool IsAnimating()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(WoodStove), Member = "Close")]
	[CalledBy(Type = typeof(WoodStove), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CalledBy(Type = typeof(Container), Member = "PlayAnimation")]
	[Calls(Type = typeof(iTweenEvent), Member = "Play")]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CallerCount(Count = 6)]
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

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public ObjectAnim()
	{
	}
}
