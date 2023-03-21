using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BakeTexturesAtRuntime : MonoBehaviour
{
	public GameObject target;

	private float elapsedTime;

	private MB3_TextureBaker.CreateAtlasesCoroutineResult result;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(MB3_TextureBaker), Member = "CreateAtlases")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(MB3_TextureBaker), Member = "CreateAtlasesCoroutine")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 33)]
	private void OnGUI()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 8)]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public BakeTexturesAtRuntime()
	{
	}
}
