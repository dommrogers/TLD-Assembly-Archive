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
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(PostProcessManager), Member = ".ctor")]
		[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
		[CalledBy(Type = typeof(ColorGrading), Member = "ApplyTempLut")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "OnEnable")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "OnDisable")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 51)]
	public static void MarkSettingsChanged()
	{
	}

	[CallerCount(Count = 0)]
	public static void PostLateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(PostProcessManager), Member = "get_instance")]
	private PostProcessManager()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	private void CleanBaseTypes()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PostProcessManager), Member = "CleanBaseTypes")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetAllAssemblyTypes")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "SetAllOverridesTo")]
	[CallsUnknownMethods(Count = 24)]
	private void ReloadBaseTypes()
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(ColorGrading), Member = "ApplyTempLut")]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profile")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
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
	[CallsUnknownMethods(Count = 3)]
	internal void SetLayerDirty(int layer)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessManager), Member = "SetLayerDirty")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "Register")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "OnEnable")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void Register(PostProcessVolume volume, int layer)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal void Register(PostProcessVolume volume)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "Unregister")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "OnDisable")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	private void Unregister(PostProcessVolume volume, int layer)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal void Unregister(PostProcessVolume volume)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 17)]
	private void ReplaceData(PostProcessLayer postProcessLayer)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void EnableAO(bool enabled)
	{
	}

	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateGlobalVolumeInfoList")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HaveGlobalVolumesChanged")]
	[Calls(Type = typeof(PostProcessLayer), Member = "AreAllVolumesGlobal")]
	[Calls(Type = typeof(PostProcessManager), Member = "GrabVolumes")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessManager), Member = "ReplaceData")]
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "GetActiveVolumes")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private List<PostProcessVolume> GrabVolumes(LayerMask mask)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
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
