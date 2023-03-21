using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIButtonActivate : MonoBehaviour
{
	public GameObject target;

	public bool state;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIButtonActivate()
	{
	}
}
