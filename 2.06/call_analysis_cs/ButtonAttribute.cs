using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ButtonAttribute : PropertyAttribute
{
	public string buttonLabel;

	public string methodName;

	public bool isActiveAtRuntime;

	public bool isActiveInEditor;

	[CallerCount(Count = 0)]
	public ButtonAttribute(string buttonLabel, string methodName, int order = 1)
	{
	}
}
