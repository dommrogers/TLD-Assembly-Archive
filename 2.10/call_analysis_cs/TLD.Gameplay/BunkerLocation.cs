using Cpp2ILInjected.CallAnalysis;
using TLD.Scenes.ObjectReferences;
using UnityEngine;

namespace TLD.Gameplay;

public class BunkerLocation : MonoBehaviour
{
	private BunkerLocationReference m_SceneObject;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneObjectReference), Member = "SetOwner")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SceneObjectReference), Member = "SetOwner")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BunkerLocation()
	{
	}
}
