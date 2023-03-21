using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI;

public class RewiredEventSystem : EventSystem
{
	private bool _alwaysUpdate;

	public bool alwaysUpdate
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
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
	[Calls(Type = typeof(EventSystem), Member = "Update")]
	[Calls(Type = typeof(EventSystem), Member = "set_current")]
	[CallsUnknownMethods(Count = 6)]
	protected override void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public RewiredEventSystem()
	{
	}
}
