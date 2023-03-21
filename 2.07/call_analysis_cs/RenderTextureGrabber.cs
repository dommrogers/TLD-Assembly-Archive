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

	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "Update")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "Start")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "RegisterCamera")]
	private void CreateRenderTexture()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	private void Start()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 60)]
	public void SetDisplayInterface(GameObject displayInterface)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	public void SetDirty()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void HandleOnRenderCompleted()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "UnregisterCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public RenderTextureGrabber()
	{
	}
}
