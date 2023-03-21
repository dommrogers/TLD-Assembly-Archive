using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Type, bool> _003C_003E9__18_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CReloadBaseTypes_003Eb__18_0(Type t)
		{
			return default(bool);
		}
	}

	private static PostProcessManager s_Instance;

	public static bool s_GlobalVolumesOptimizationEnabled;

	private static int s_SettingsHasChangedFrameCount;

	private static bool s_SettingsHasChanged;

	private static int s_LastUpdatedFrameCount;

	private const int k_MaxLayerCount = 32;

	private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes;

	private readonly List<PostProcessVolume> m_Volumes;

	private readonly Dictionary<int, bool> m_SortNeeded;

	private readonly List<PostProcessEffectSettings> m_BaseSettings;

	private readonly List<Collider> m_TempColliders;

	public readonly Dictionary<Type, PostProcessAttribute> settingsTypes;

	public static PostProcessManager instance
	{
		[CalledBy(Type = typeof(PostProcessVolume), Member = "OnDisable")]
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "OnEnable")]
		[CalledBy(Type = typeof(ColorGrading), Member = "ApplyTempLut")]
		[CallerCount(Count = 8)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
		[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
		[Calls(Type = typeof(PostProcessManager), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 55)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void MarkSettingsChanged()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void PostLateUpdate()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "get_instance")]
	private PostProcessManager()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void CleanBaseTypes()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PostProcessManager), Member = "CleanBaseTypes")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetAllAssemblyTypes")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "SetAllOverridesTo")]
	[CallsUnknownMethods(Count = 25)]
	private void ReloadBaseTypes()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(PostProcessManager), Member = "GrabVolumes")]
	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = true, bool skipZeroWeight = true)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(ColorGrading), Member = "ApplyTempLut")]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profile")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "Register")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	internal void SetLayerDirty(int layer)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "OnEnable")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PostProcessManager), Member = "SetLayerDirty")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "Register")]
	private void Register(PostProcessVolume volume, int layer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[CallsUnknownMethods(Count = 3)]
	internal void Register(PostProcessVolume volume)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "OnDisable")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "Unregister")]
	private void Unregister(PostProcessVolume volume, int layer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	[CallsUnknownMethods(Count = 3)]
	internal void Unregister(PostProcessVolume volume)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(PostProcessLayer), Member = "GetBundle")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 13)]
	private void ReplaceData(PostProcessLayer postProcessLayer)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public void EnableAO(bool enabled)
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
	[Calls(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateGlobalVolumeInfoList")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HaveGlobalVolumesChanged")]
	[Calls(Type = typeof(PostProcessLayer), Member = "AreAllVolumesGlobal")]
	[Calls(Type = typeof(PostProcessManager), Member = "GrabVolumes")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(PostProcessManager), Member = "ReplaceData")]
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera)
	{
	}

	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "GetActiveVolumes")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(PostProcessManager), Member = "SortByPriority")]
	private List<PostProcessVolume> GrabVolumes(LayerMask mask)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "GrabVolumes")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 1)]
	private static void SortByPriority(List<PostProcessVolume> volumes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera)
	{
		return default(bool);
	}
}
