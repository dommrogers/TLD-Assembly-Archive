using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIWidgetContainer : MonoBehaviour
{
	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UIWidgetContainer()
	{
	}
}
