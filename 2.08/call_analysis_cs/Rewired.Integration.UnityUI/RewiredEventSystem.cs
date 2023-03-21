using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

public class RewiredEventSystem : EventSystem
{
	private bool _alwaysUpdate;

	public bool alwaysUpdate
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "get_current")]
	[Calls(Type = typeof(EventSystem), Member = "set_current")]
	[Calls(Type = typeof(EventSystem), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	protected override void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RewiredEventSystem()
	{
	}
}
