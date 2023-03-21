using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderTextureGrabber : MonoBehaviour
{
	public Action OnRenderCompleted;

	public RenderTexture m_RenderTexture;

	public Camera m_Camera;

	public Renderer m_LocalDisplay;

	private int m_RenderTextureWidth;

	private int m_RenderTextureHeight;

	private GameObject m_DisplayInterface;

	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "Update")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "Start")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "RegisterCamera")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void CreateRenderTexture()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 41)]
	public void SetDisplayInterface(GameObject displayInterface)
	{
	}

	[Calls(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallsUnknownMethods(Count = 2)]
	public void SetDirty()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void HandleOnRenderCompleted()
	{
	}

	[Calls(Type = typeof(RenderTextureCameraManager), Member = "UnregisterCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 14)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public RenderTextureGrabber()
	{
	}
}
