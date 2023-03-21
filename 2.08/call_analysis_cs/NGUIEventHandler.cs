using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NGUIEventHandler : MonoBehaviour
{
	private GameObject LastSelectedByKeys;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnSelectDelegate(GameObject go, bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CallsUnknownMethods(Count = 1)]
	private void OnKeyDelegate(GameObject go, KeyCode keyCode)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public NGUIEventHandler()
	{
	}
}
