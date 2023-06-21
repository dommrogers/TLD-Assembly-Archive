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

	[CalledBy(Type = typeof(ObjectAnim), Member = "Start")]
	[CalledBy(Type = typeof(OpenClose), Member = "Start")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Initialize()
	{
	}

	[CalledBy(Type = typeof(Container), Member = "UpdateContainer")]
	[CalledBy(Type = typeof(Container), Member = "IsPlayingAnimation")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CalledBy(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[CalledBy(Type = typeof(OpenCloseManager), Member = "UpdateAll")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsAnimating()
	{
		return false;
	}

	[CalledBy(Type = typeof(Container), Member = "PlayAnimation")]
	[CalledBy(Type = typeof(OpenClose), Member = "PlayAnimations")]
	[CalledBy(Type = typeof(WoodStove), Member = "Open")]
	[CalledBy(Type = typeof(WoodStove), Member = "Close")]
	[CalledBy(Type = typeof(WoodStove), Member = "PerformFireplaceInteraction")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[Calls(Type = typeof(iTweenEvent), Member = "Play")]
	[CallsUnknownMethods(Count = 2)]
	public bool Play(string name)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "GetComponents")]
	[CallsDeduplicatedMethods(Count = 1)]
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
