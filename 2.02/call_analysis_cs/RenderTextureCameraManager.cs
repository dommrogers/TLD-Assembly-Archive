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
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(Delegate), Member = "Combine")]
			[CallsUnknownMethods(Count = 1)]
			add
			{
			}
			[CallsUnknownMethods(Count = 1)]
			[Calls(Type = typeof(Delegate), Member = "Remove")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
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

		[Calls(Type = typeof(RenderTextureManagedCamera), Member = "MaybeUpdateUICamera")]
		[CallsUnknownMethods(Count = 4)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		public void Update(int index, float displayOffset)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void OnRenderCompleted()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		public void RegisterOnRenderCompletedAction(Action action)
		{
		}

		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public void UnRegisterOnRenderCompletedAction(Action action)
		{
		}

		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "LateUpdate")]
		[CalledBy(Type = typeof(RenderTextureManagedCamera), Member = "Update")]
		[CallsUnknownMethods(Count = 10)]
		private void MaybeUpdateUICamera(int index, float displayOffset)
		{
		}
	}

	private List<RenderTextureManagedCamera> m_RegisteredRenderTextureManagedCamera;

	private float m_DisplayOffsetForRender;

	private bool m_HasShownRenderWarning;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	private void Deactivate(RenderTextureManagedCamera renderTextureManagedCamera)
	{
	}

	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "Render")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Render(RenderTextureManagedCamera renderTextureManagedCamera)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(RenderTextureManagedCamera), Member = "MaybeUpdateUICamera")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	public void LateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "Render")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallsUnknownMethods(Count = 6)]
	public void Render()
	{
	}

	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "InitializeDisplayInterface")]
	[CallsUnknownMethods(Count = 12)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void RegisterCamera(Camera camera, GameObject displayInterface)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterOnRenderCompletedAction(Camera camera, GameObject displayInterface, Action onRenderCompletedAction)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void UnRegisterOnRenderCompletedAction(Camera camera, GameObject displayInterface, Action onRenderCompletedAction)
	{
	}

	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "UnRegisterOnRenderCompletedAction")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "OnDestroy")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "SetDirty")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "UnregisterCamera")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "SetDirty")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "RegisterOnRenderCompletedAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnTextScrolled")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "InitializeDisplayInterface")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Update")]
	private RenderTextureManagedCamera GetRenderTextureManagedCamera(Camera camera, GameObject displayInterface)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	public void SetDirty(Camera camera, GameObject displayInterface)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "OnDestroy")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnDestroy")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void UnregisterCamera(Camera camera, GameObject displayInterface)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public RenderTextureCameraManager()
	{
	}
}
