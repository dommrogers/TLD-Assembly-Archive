using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DummyInteractiveObject : MonoBehaviour
{
	public string m_InteractiveObjectLocID;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallsUnknownMethods(Count = 1)]
	public string GetInteractionText()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DummyInteractiveObject()
	{
	}
}
