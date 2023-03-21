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

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "Update")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "Start")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
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

	[CallerCount(Count = 60)]
	[DeduplicatedMethod]
	public void SetDisplayInterface(GameObject displayInterface)
	{
	}

	[Calls(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallsUnknownMethods(Count = 1)]
	public void SetDirty()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void HandleOnRenderCompleted()
	{
	}

	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "UnregisterCamera")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public RenderTextureGrabber()
	{
	}
}
