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

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 12)]
	public void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
