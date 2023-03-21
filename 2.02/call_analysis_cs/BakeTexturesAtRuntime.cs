using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BakeTexturesAtRuntime : MonoBehaviour
{
	public GameObject target;

	private float elapsedTime;

	private MB3_TextureBaker.CreateAtlasesCoroutineResult result;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(MB3_TextureBaker), Member = "CreateAtlasesCoroutine")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 25)]
	[Calls(Type = typeof(MB3_TextureBaker), Member = "CreateAtlases")]
	private void OnGUI()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public BakeTexturesAtRuntime()
	{
	}
}
