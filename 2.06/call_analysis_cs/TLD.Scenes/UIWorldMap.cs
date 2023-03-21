using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Scenes;

public class UIWorldMap : MonoBehaviour
{
	private AssetReferenceTexture2D m_MapTexture;

	private UITexture m_target;

	private AsyncOperationHandle<Texture2D> m_asyncOp;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWorldMap), Member = "LoadMap")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SelectWorldMap), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(UIWorldMap), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 7)]
	public void LoadMap()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UIWorldMap()
	{
	}
}
