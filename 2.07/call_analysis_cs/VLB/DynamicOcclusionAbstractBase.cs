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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public event Action onOcclusionProcessed
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	public void ProcessOcclusionManually()
	{
	}

	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnWillCameraRender")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusionManually")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "<OnEnable>b__22_0")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 10)]
	protected void ProcessOcclusion(ProcessOcclusionSource source)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	protected abstract string GetShaderKeyword();

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

	[CallerCount(Count = 101261)]
	[DeduplicatedMethod]
	protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
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

	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected virtual void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "CallOnBeamGeometryInitializedCallback")]
	[CallsUnknownMethods(Count = 4)]
	protected virtual void OnEnable()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnDisable")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	protected virtual void OnDisable()
	{
	}

	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	[Calls(Type = typeof(TransformUtils), Member = "IsSame")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void OnWillCameraRender(Camera cam)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
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
