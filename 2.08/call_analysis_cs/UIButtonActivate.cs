using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIButtonActivate : MonoBehaviour
{
	public GameObject target;

	public bool state;

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 0)]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIButtonActivate()
	{
	}
}
