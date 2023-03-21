using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIButtonActivate : MonoBehaviour
{
	public GameObject target;

	public bool state;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIButtonActivate()
	{
	}
}
