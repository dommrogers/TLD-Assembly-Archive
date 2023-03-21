using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectAnim : MonoBehaviour
{
	public GameObject m_Target;

	private iTweenEvent[] m_Events;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(OpenClose), Member = "Update_Internal")]
	[CalledBy(Type = typeof(OpenClose), Member = "UpdateOpenClose")]
	[CalledBy(Type = typeof(OpenClose), Member = "MaybeUpdateNavmeshObstacleState")]
	[CallsUnknownMethods(Count = 8)]
	public bool IsAnimating()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(WoodStove), Member = "Close")]
	[CalledBy(Type = typeof(WoodStove), Member = "Open")]
	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CalledBy(Type = typeof(Container), Member = "Close")]
	[CalledBy(Type = typeof(Container), Member = "Open")]
	[Calls(Type = typeof(iTweenEvent), Member = "GetEvent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(iTweenEvent), Member = "Play")]
	public bool Play(string name)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(OpenClose), Member = "Close")]
	[CalledBy(Type = typeof(OpenClose), Member = "Open")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void GoToEndImmediate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public ObjectAnim()
	{
	}
}
