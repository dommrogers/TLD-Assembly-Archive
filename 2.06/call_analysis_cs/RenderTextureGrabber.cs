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

	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "Start")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_mainTexture")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "RegisterCamera")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
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
	[CallerCount(Count = 65)]
	public void SetDisplayInterface(GameObject displayInterface)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "UnregisterCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	public RenderTextureGrabber()
	{
	}
}
