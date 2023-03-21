using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

internal class UILargeTexture : MonoBehaviour
{
	public string m_AssetName;

	private UITexture m_UITexture;

	private Texture2D m_LoadedTexture;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void OnValidate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	public void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UILargeTexture()
	{
	}
}
