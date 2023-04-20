using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;

namespace TLD.Interactions;

[Serializable]
public class InteractionEvent : UnityEvent<BaseInteraction>
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventBase), Member = ".ctor")]
	public InteractionEvent()
	{
		((UnityEvent<T0>)(object)this)._002Ector();
	}
}
