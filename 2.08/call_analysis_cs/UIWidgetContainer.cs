using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIWidgetContainer : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIWidgetContainer()
	{
	}
}
