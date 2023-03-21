using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	public MeshRenderer targetRenderer;

	public Material[] materials;

	public MB3_MeshBaker meshBaker;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GUILayout), Member = "Label")]
	public void OnGUI()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 11)]
	public void Update()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
