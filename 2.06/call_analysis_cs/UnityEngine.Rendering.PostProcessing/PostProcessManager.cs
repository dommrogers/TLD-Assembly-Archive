using System;
using System.Collections.Generic;
using System.Linq;
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

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CReloadBaseTypes_003Eb__18_0(Type t)
		{
			return false;
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
		[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
		[CalledBy(Type = typeof(ColorGrading), Member = "ApplyTempLut")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "OnEnable")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "OnDisable")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(PostProcessManager), Member = ".ctor")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 107)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void MarkSettingsChanged()
	{
	}

	[CallerCount(Count = 0)]
	public static void PostLateUpdate()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(PostProcessManager), Member = "get_instance")]
	[CallerCount(Count = 1)]
	private PostProcessManager()
	{
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 4)]
	private void CleanBaseTypes()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "CleanBaseTypes")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetAllAssemblyTypes")]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "SetAllOverridesTo")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 30)]
	private void ReloadBaseTypes()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PostProcessManager), Member = "GrabVolumes")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
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
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask)
	{
		return null;
	}

	[CalledBy(Type = typeof(ColorGrading), Member = "ApplyTempLut")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profile")]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings)
	{
		return null;
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "Register")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal void SetLayerDirty(int layer)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer)
	{
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "Register")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "OnEnable")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PostProcessManager), Member = "SetLayerDirty")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	private void Register(PostProcessVolume volume, int layer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void Register(PostProcessVolume volume)
	{
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "Unregister")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "OnDisable")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 4)]
	private void Unregister(PostProcessVolume volume, int layer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal void Unregister(PostProcessVolume volume)
	{
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 21)]
	private void ReplaceData(PostProcessLayer postProcessLayer)
	{
	}

	[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PostProcessProfile), Member = "TryGetSettings")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CallsUnknownMethods(Count = 5)]
	public void EnableAO(bool enabled)
	{
	}

	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PostProcessManager), Member = "GrabVolumes")]
	[Calls(Type = typeof(PostProcessLayer), Member = "AreAllVolumesGlobal")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HaveGlobalVolumesChanged")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateGlobalVolumeInfoList")]
	[Calls(Type = typeof(PostProcessManager), Member = "ReplaceData")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponents")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 19)]
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera)
	{
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "GetActiveVolumes")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 33)]
	private List<PostProcessVolume> GrabVolumes(LayerMask mask)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private static void SortByPriority(List<PostProcessVolume> volumes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera)
	{
		return false;
	}
}
