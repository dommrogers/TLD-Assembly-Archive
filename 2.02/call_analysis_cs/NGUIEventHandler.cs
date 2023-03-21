using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class NGUIEventHandler : MonoBehaviour
{
	private GameObject LastSelectedByKeys;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnSelectDelegate(GameObject go, bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnKeyDelegate(GameObject go, KeyCode keyCode)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public NGUIEventHandler()
	{
	}
}
