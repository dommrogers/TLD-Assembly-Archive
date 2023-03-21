using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraDeAlpha : MonoBehaviour
{
	private Material mat;

	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 27)]
	[CallerCount(Count = 0)]
	private void OnPostRender()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CameraDeAlpha()
	{
	}
}
