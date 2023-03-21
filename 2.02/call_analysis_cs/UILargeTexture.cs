using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

internal class UILargeTexture : MonoBehaviour
{
	public string m_AssetName;

	private UITexture m_UITexture;

	private Texture2D m_LoadedTexture;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetLargeTexture")]
	[CallsUnknownMethods(Count = 1)]
	public void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDisable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UILargeTexture()
	{
	}
}
