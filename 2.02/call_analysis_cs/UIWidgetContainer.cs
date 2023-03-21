using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIWidgetContainer : MonoBehaviour
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public UIWidgetContainer()
	{
	}
}
