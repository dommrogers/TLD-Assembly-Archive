using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class BakeTexturesAtRuntime : MonoBehaviour
{
	public GameObject target;

	private float elapsedTime;

	private MB3_TextureBaker.CreateAtlasesCoroutineResult result;

	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(MB3_TextureBaker), Member = "CreateAtlasesCoroutine")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB3_TextureBaker), Member = "CreateAtlases")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	[CallsDeduplicatedMethods(Count = 22)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "Button")]
	private void OnGUI()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public BakeTexturesAtRuntime()
	{
	}
}
