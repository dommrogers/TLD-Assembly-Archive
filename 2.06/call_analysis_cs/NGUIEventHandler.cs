using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NGUIEventHandler : MonoBehaviour
{
	private GameObject LastSelectedByKeys;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	private void OnSelectDelegate(GameObject go, bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	private void OnKeyDelegate(GameObject go, KeyCode keyCode)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public NGUIEventHandler()
	{
	}
}
