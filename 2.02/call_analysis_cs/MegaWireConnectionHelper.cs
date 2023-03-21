using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MegaWireConnectionHelper : MonoBehaviour
{
	public List<MegaWireConnectionDef> connections;

	public bool showgizmo;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public MegaWireConnectionHelper()
	{
	}
}
