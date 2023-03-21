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
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UILargeTexture()
	{
	}
}
