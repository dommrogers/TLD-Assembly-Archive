using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderTextureCameraManager : MonoBehaviour
{
	public class RenderTextureManagedCamera
	{
		public readonly GameObject m_DisplayInterface;

		public readonly Camera m_Camera;

		private bool m_IsDirty;

		private bool m_WasInterfaceActive;

		private int m_Index;

		private const int LAYER_UI = 32;

		private event Action m_OnRenderCompleted
		{
			[CallsUnknownMethods(Count = 1)]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Delegate), Member = "Combine")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			add
			{
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Delegate), Member = "Remove")]
			[CallsUnknownMethods(Count = 1)]
			remove
			{
			}
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public RenderTextureManagedCamera(Camera camera, GameObject displayInterface)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void SetDirty(bool isDirty)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool IsDirty()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void OnEnable()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(RenderTextureManagedCamera), Member = "MaybeUpdateUICamera")]
		[CallsUnknownMethods(Count = 4)]
		public void Update(int index, float displayOffset)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void OnRenderCompleted()
		{
		}

		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void RegisterOnRenderCompletedAction(Action action)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		public void UnRegisterOnRenderCompletedAction(Action action)
		{
		}

		[CallsUnknownMethods(Count = 6)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 5)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CalledBy(Type = typeof(RenderTextureManagedCamera), Member = "Update")]
		[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "LateUpdate")]
		private void MaybeUpdateUICamera(int index, float displayOffset)
		{
		}
	}

	private List<RenderTextureManagedCamera> m_RegisteredRenderTextureManagedCamera;

	private float m_DisplayOffsetForRender;

	private bool m_HasShownRenderWarning;

	private Panel_HUD m_HUD;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private float GetSystemFadeOverlayAlpha()
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void Deactivate(RenderTextureManagedCamera renderTextureManagedCamera)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "Render")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void Render(RenderTextureManagedCamera renderTextureManagedCamera)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(RenderTextureManagedCamera), Member = "MaybeUpdateUICamera")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "Render")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Render()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "InitializeDisplayInterface")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	[CallsUnknownMethods(Count = 9)]
	public void RegisterCamera(Camera camera, GameObject displayInterface)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterOnRenderCompletedAction(Camera camera, GameObject displayInterface, Action onRenderCompletedAction)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	public void UnRegisterOnRenderCompletedAction(Camera camera, GameObject displayInterface, Action onRenderCompletedAction)
	{
	}

	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "RegisterOnRenderCompletedAction")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "OnDestroy")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "SetDirty")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "UnregisterCamera")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "SetDirty")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "UnRegisterOnRenderCompletedAction")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Update")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnTextScrolled")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "InitializeDisplayInterface")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	private RenderTextureManagedCamera GetRenderTextureManagedCamera(Camera camera, GameObject displayInterface)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	public void SetDirty(Camera camera, GameObject displayInterface)
	{
	}

	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnDestroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallerCount(Count = 2)]
	public void UnregisterCamera(Camera camera, GameObject displayInterface)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public RenderTextureCameraManager()
	{
	}
}
