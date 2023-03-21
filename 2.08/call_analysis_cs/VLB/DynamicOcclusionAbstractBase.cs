using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
{
	protected enum ProcessOcclusionSource
	{
		RenderLoop,
		OnEnable,
		EditorUpdate,
		User
	}

	public DynamicOcclusionUpdateRate updateRate;

	public int waitXFrames;

	public static bool _INTERNAL_ApplyRandomFrameOffset;

	private TransformUtils.Packed m_TransformPacked;

	private int m_LastFrameRendered;

	protected VolumetricLightBeam m_Master;

	public int _INTERNAL_LastFrameRendered
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	public event Action onOcclusionProcessed
	{
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	public void ProcessOcclusionManually()
	{
	}

	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusionManually")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "<OnEnable>b__22_0")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnWillCameraRender")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	protected void ProcessOcclusion(ProcessOcclusionSource source)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	protected abstract string GetShaderKeyword();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

	[DeduplicatedMethod]
	[CallerCount(Count = 101262)]
	protected abstract void OnEnablePostValidate();

	[CallerCount(Count = 0)]
	protected virtual void OnValidateProperties()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "CallOnBeamGeometryInitializedCallback")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	protected virtual void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnDisable")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnDisable")]
	protected virtual void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TransformUtils), Member = "IsSame")]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	[CallsUnknownMethods(Count = 2)]
	private void OnWillCameraRender(Camera cam)
	{
	}

	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void DisableOcclusion()
	{
	}

	[CallerCount(Count = 0)]
	protected DynamicOcclusionAbstractBase()
	{
	}
}
