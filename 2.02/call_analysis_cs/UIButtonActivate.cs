using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIButtonActivate : MonoBehaviour
{
	public GameObject target;

	public bool state;

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UIButtonActivate()
	{
	}
}
