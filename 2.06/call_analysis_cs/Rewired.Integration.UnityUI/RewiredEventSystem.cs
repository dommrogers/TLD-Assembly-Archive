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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = "get_current")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventSystem), Member = "set_current")]
	[Calls(Type = typeof(EventSystem), Member = "Update")]
	[Calls(Type = typeof(EventSystem), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventSystem), Member = "set_current")]
	protected override void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventSystem), Member = ".ctor")]
	public RewiredEventSystem()
	{
	}
}
