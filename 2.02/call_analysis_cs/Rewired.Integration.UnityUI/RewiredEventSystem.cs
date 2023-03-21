using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
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
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(EventSystem), Member = "Update")]
	[Calls(Type = typeof(EventSystem), Member = "set_current")]
	[Calls(Type = typeof(EventSystem), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventSystem), Member = "get_current")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "set_current")]
	protected override void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(EventSystem), Member = ".ctor")]
	public RewiredEventSystem()
	{
	}
}
