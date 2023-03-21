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
			[Calls(Type = typeof(Delegate), Member = "Combine")]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			add
			{
			}
			[DeduplicatedMethod]
			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(Delegate), Member = "Remove")]
			[CompilerGenerated]
			[CallerCount(Count = 0)]
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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 1)]
		public void OnRenderCompleted()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "LateUpdate")]
		[CalledBy(Type = typeof(RenderTextureManagedCamera), Member = "Update")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		private void MaybeUpdateUICamera(int index, float displayOffset)
		{
		}
	}

	private List<RenderTextureManagedCamera> m_RegisteredRenderTextureManagedCamera;

	private float m_DisplayOffsetForRender;

	private bool m_HasShownRenderWarning;

	private Panel_HUD m_HUD;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float GetSystemFadeOverlayAlpha()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 2)]
	private void Deactivate(RenderTextureManagedCamera renderTextureManagedCamera)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "Render")]
	[CallsUnknownMethods(Count = 2)]
	private void Render(RenderTextureManagedCamera renderTextureManagedCamera)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(RenderTextureManagedCamera), Member = "MaybeUpdateUICamera")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "Render")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 4)]
	public void Render()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "InitializeDisplayInterface")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	public void UnRegisterOnRenderCompletedAction(Camera camera, GameObject displayInterface, Action onRenderCompletedAction)
	{
	}

	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "UnRegisterOnRenderCompletedAction")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "InitializeDisplayInterface")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnTextScrolled")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Update")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "RegisterOnRenderCompletedAction")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "SetDirty")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "UnregisterCamera")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "SetDirty")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 6)]
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
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public void UnregisterCamera(Camera camera, GameObject displayInterface)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RenderTextureCameraManager()
	{
	}
}
