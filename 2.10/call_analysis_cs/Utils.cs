using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using Steamworks;
using SuperSplines;
using TLD.AddressableAssets;
using TLD.Gameplay;
using TLD.Gear;
using TLD.Logging;
using TLD.Missions;
using TLD.News;
using TLD.SaveState;
using TLD.Scenes;
using TLD.Serialization;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Analytics;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class Utils : MonoBehaviour
{
	public enum GameOverResult
	{
		Failed,
		Success
	}

	public enum ExecuteCmdOptions
	{
		None,
		ReturnStandardOutput,
		LogErrorOutput
	}

	public delegate void ExecuteCmdCallback(string stdout);

	public enum SystemMetrics
	{
		MouseButtonsSwapped = 23
	}

	public struct OBB
	{
		public Vector3 c;

		public Vector3[] u;

		public Vector3 e;
	}

	private struct Coords
	{
		public int x;

		public int z;
	}

	private enum PatchHeightCheckState
	{
		NotChecked,
		Queued,
		Set
	}

	private struct FastSplineNode
	{
		public Vector3 m_Position;

		public Quaternion m_Rotation;

		public double m_PosInSpline;

		public double m_Length;

		[CallerCount(Count = 0)]
		public FastSplineNode(Vector3 pos, Quaternion rot)
		{
		}

		[CallerCount(Count = 0)]
		public void Reset()
		{
		}
	}

	public struct FastSpline
	{
		public struct LengthData
		{
			public NativeArray<double> m_SubSegmentLength;

			public NativeArray<double> m_SubSegmentPosition;

			public double m_Length;

			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 2)]
			public void Dispose()
			{
			}

			[CallAnalysisFailed]
			[CalledBy(Type = typeof(FastSpline), Member = "Allocate")]
			[CallerCount(Count = 1)]
			public void Calculate(ref FastSpline spline)
			{
			}

			[CallerCount(Count = 0)]
			private void SetupSplinePositions(ref FastSpline spline)
			{
			}
		}

		public enum TangentMode
		{
			UseNormalizedTangents,
			UseTangents,
			UseNodeForwardVector
		}

		public enum InterpolationMode
		{
			Hermite,
			Bezier,
			BSpline,
			Linear
		}

		public static readonly double[] HermiteMatrix;

		public static readonly double[] BezierMatrix;

		public static readonly double[] BSplineMatrix;

		public static readonly double[] LinearMatrix;

		public InterpolationMode m_InterpolationMode;

		public TangentMode m_TangentMode;

		public float m_Tension;

		public bool m_AutoClose;

		public int m_InterpolationAccuracy;

		private NativeArray<FastSplineNode> m_SplineNodesInternal;

		private NativeArray<double> m_SplineMatrix;

		public LengthData m_LengthData;

		public bool AutoClose
		{
			[CallerCount(Count = 0)]
			get
			{
				return false;
			}
		}

		public int Step
		{
			[CallerCount(Count = 0)]
			get
			{
				return 0;
			}
		}

		public int ControlNodeCount
		{
			[CallerCount(Count = 0)]
			get
			{
				return 0;
			}
		}

		public double InvertedAccuracy
		{
			[CallerCount(Count = 0)]
			get
			{
				return 0.0;
			}
		}

		private bool IsBezier
		{
			[CallerCount(Count = 0)]
			get
			{
				return false;
			}
		}

		public bool HasNodes
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return false;
			}
		}

		public int SegmentCount
		{
			[CallerCount(Count = 0)]
			get
			{
				return 0;
			}
		}

		[CallerCount(Count = 0)]
		private FastSplineNode GetNode(int idxNode, int idxOffset)
		{
			return default(FastSplineNode);
		}

		[CallerCount(Count = 0)]
		public int MaxNodeIndex()
		{
			return 0;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		[CallsUnknownMethods(Count = 1)]
		private double GetSegmentLengthInternal(int idxFirstPoint, double startValue, double endValue, double step)
		{
			return 0.0;
		}

		[CalledBy(Type = typeof(SplineAudioClip), Member = "OnDestroy")]
		[CalledBy(Type = typeof(SplineAudioClip), Member = "Terminate")]
		[CalledBy(Type = typeof(SplineManager), Member = "UnRegisterStaticSplineAudioClip")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 3)]
		public void Dispose()
		{
		}

		[CalledBy(Type = typeof(FastSpline), Member = "GetSegmentLengthInternal")]
		[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
		[CalledBy(Type = typeof(Utils), Member = "GetPositionOnSpline")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		[Calls(Type = typeof(FastSpline), Member = "RecalcVectors")]
		public Vector3 GetPositionInternal(SegmentParameter sParam)
		{
			return default(Vector3);
		}

		[CallerCount(Count = 0)]
		private Vector3 InterpolatePosition(double t, Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
		{
			return default(Vector3);
		}

		[CalledBy(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		[CallerCount(Count = 1)]
		private void GetAdjacentNodes(SegmentParameter sParam, out FastSplineNode node0, out FastSplineNode node1, out FastSplineNode node2, out FastSplineNode node3)
		{
			node0 = default(FastSplineNode);
			node1 = default(FastSplineNode);
			node2 = default(FastSplineNode);
			node3 = default(FastSplineNode);
		}

		[CalledBy(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "Normalize")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		private void RecalcVectors(FastSplineNode node0, FastSplineNode node1, ref Vector3 P2, ref Vector3 P3)
		{
		}

		[CalledBy(Type = typeof(SplineAudioClip), Member = "Initialize")]
		[CalledBy(Type = typeof(Utils), Member = "CreateFastSpline")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Utils), Member = "GetValidNodesCount")]
		[Calls(Type = typeof(SplineNode), Member = "get_Rotation")]
		[Calls(Type = typeof(LengthData), Member = "Calculate")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		public void Allocate(Spline spline, NativeArray<double> matrix)
		{
		}
	}

	public struct SegmentParameter
	{
		public double m_NormalizedParam;

		public int m_NormalizedIndex;

		[CallerCount(Count = 0)]
		public SegmentParameter(int index, double param)
		{
		}
	}

	public struct Subtitle
	{
		public string m_LocId;

		public bool m_IsUnkownSpeaker;

		public uint m_StartFrame;

		public uint m_EndFrame;
	}

	private sealed class _003CWebRequest_003Ed__339 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<UnityWebRequest> onFailure;

		public Action<UnityWebRequest> onSuccess;

		private UnityWebRequest _003Cresponse_003E5__2;

		private float _003CtimeoutTime_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWebRequest_003Ed__339(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[CalledBy(Type = typeof(_003CWebRequest_003Ed__339), Member = "MoveNext")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone")]
		[Calls(Type = typeof(Utils), Member = "PreValidatRequest")]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[Calls(Type = typeof(_003CWebRequest_003Ed__339), Member = "System.IDisposable.Dispose")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 15)]
		private bool MoveNext()
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CWebRequest_003Ed__340 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<UnityWebRequest> onFailure;

		public WWWForm form;

		public Action<UnityWebRequest> onSuccess;

		private UnityWebRequest _003Cresponse_003E5__2;

		private float _003CtimeoutTime_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWebRequest_003Ed__340(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[CalledBy(Type = typeof(_003CWebRequest_003Ed__340), Member = "MoveNext")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone")]
		[Calls(Type = typeof(Utils), Member = "PreValidatRequest")]
		[Calls(Type = typeof(UnityWebRequest), Member = ".ctor")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetupPost")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[Calls(Type = typeof(_003CWebRequest_003Ed__340), Member = "System.IDisposable.Dispose")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 16)]
		private bool MoveNext()
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CWebRequestPut_003Ed__341 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<UnityWebRequest> onFailure;

		public byte[] data;

		public Dictionary<string, string> httpHeaders;

		public Action<UnityWebRequest> onSuccess;

		private UnityWebRequest _003Cresponse_003E5__2;

		private float _003CtimeoutTime_003E5__3;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWebRequestPut_003Ed__341(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[CalledBy(Type = typeof(_003CWebRequestPut_003Ed__341), Member = "MoveNext")]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone")]
		[Calls(Type = typeof(Utils), Member = "PreValidatRequest")]
		[Calls(Type = typeof(UploadHandlerRaw), Member = ".ctor")]
		[Calls(Type = typeof(UnityWebRequest), Member = ".ctor")]
		[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[Calls(Type = typeof(_003CWebRequestPut_003Ed__341), Member = "System.IDisposable.Dispose")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 16)]
		private bool MoveNext()
		{
			return false;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public static bool s_AnalyticsInitialized;

	private static readonly LogFilter s_LoadingFilter;

	public static bool s_UseAudioStaticCheck;

	private static readonly string[] s_WhitelistedSharedArguments;

	private static Dictionary<string, string> s_CommandLineArgs;

	public const float MENU_MOVEMENT_AFTER_FIFTEEN = 0.02f;

	public const float MENU_MOVEMENT_AFTER_FIVE = 0.1f;

	public const float MENU_MOVEMENT_DELAY = 0.2f;

	public const float MENU_MOVEMENT_FIRSTDELAY = 0.5f;

	public const float DOUBLECLICK_MaxTime = 0.5f;

	public static int m_PhysicalCollisionLayerMask;

	public static int m_WeaponProjectileCollisionLayerMask;

	public static bool m_InspectModeActive;

	public static Vector3[] EMPTY_VECTOR3_ARRAY;

	private static Vector3 m_InspectRestorePos;

	private static Quaternion m_InspectRestoreRot;

	private static Vector3 m_InspectOriginalLocalScale;

	private static Transform m_InspectCachedParent;

	private static ShadowCastingMode m_InspectRestoreCastsShadows;

	private static int m_MenuMoveHorizontalRepeatCount;

	private static int m_MenuMoveVerticalRepeatCount;

	private static int m_MenuMoveVerticalRightStickRepeatCount;

	private static int m_MenuMoveHorizontalRightStickRepeatCount;

	private static float m_MenuMoveHorizontalTimeAllowed;

	private static float m_MenuMoveVerticalTimeAllowed;

	private static float m_MenuMoveVerticalRightStickTimeAllowed;

	private static float m_MenuMoveHorizontalRightStickTimeAllowed;

	private static float m_MenuAxisDeadzone;

	private const float HIGHER_PRECISION_FIXED_PHYS_TIMESTEP = 0.03f;

	private const float NORNAL_PRECISION_FIXED_PHYS_TIMESTEP = 0.04f;

	private static float m_MenuMoveHorizontalRightStickAccumulated;

	private static float m_MenuMoveHorizontalRightStickThreshold;

	public static float m_SteamControllerMenuScrollSensitivity;

	public static bool s_DebugVerbose;

	private static string[] s_ByteFormatSuffixes;

	private static int[] s_SHAIds;

	private static int[] s_SHBIds;

	private static int s_SHCId;

	public const float PI2 = (float)Math.PI * 2f;

	public const float HALFPI = (float)Math.PI / 2f;

	public const string s_MissionMapMarkerLabel = "MissionMapMarker";

	private static HashSet<string> s_MissionMapMarkerIDs;

	private static HashSet<string> s_MissionIds;

	private static HashSet<string> s_MissionObjectiveIds;

	private const int MAX_RAYCAST_HITS = 32;

	private static RaycastHit[] s_RaycastHits;

	public static bool s_ShadowsEnabled;

	public static bool s_SpecularEnabled;

	private static ShadowQuality s_ShadowMode;

	private static bool s_ForceFlatLighting;

	private static RaycastHit[] m_PatchCoefficientRaycastResults;

	private const int NUM_PATCH_HEIGHT_X_COORDS = 5;

	private const int NUM_PATCH_HEIGHT_Z_COORDS = 5;

	private static float[,] s_PatchHeights;

	private static PatchHeightCheckState[,] s_PatchHeightCheckStates;

	private static Queue<Coords> s_CoordsQueue;

	private static Material s_ClearBlitMaterial;

	public const int SUBTITLE_FRAMESPERSECOND = 24;

	public const int WEB_REQUEST_TIMEOUT = 30;

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmPrivacySettings")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	public static void EnableAnalytics(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	public static bool AreAnalyticsEnabled()
	{
		return false;
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public static void SendDailyAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateAndMaybeSendAnalytics")]
	[CalledBy(Type = typeof(Log), Member = "AddAffliction")]
	[CalledBy(Type = typeof(ConditionOverTimeBuff), Member = "Apply")]
	[CalledBy(Type = typeof(ConditionRestBuff), Member = "Apply")]
	[CalledBy(Type = typeof(FatigueBuff), Member = "Apply")]
	[CalledBy(Type = typeof(FreezingBuff), Member = "Apply")]
	[CalledBy(Type = typeof(WellFed), Member = "WellFedStart")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "AddMission")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "MarkMissionComplete")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "AddObjective")]
	[CalledBy(Type = typeof(ActiveMissionManager), Member = "MarkObjectiveComplete")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	public static void SendGameplayAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "AddCustomEventData")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public static void SendGameStartAnalyticsEvent(RegionSpecification region)
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Clear")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "AddCustomEventData")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 4)]
	public static void SendGameOverAnalyticsEvent(GameOverResult gameOverResult)
	{
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "UpdateAnalytics")]
	[CalledBy(Type = typeof(FeatEnabledTracker), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(Utils), Member = "SendDailyAnalyticsEvent")]
	[CalledBy(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void SendCustomAnalyticsEventWithSeed(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 3)]
	public static void SendQualitySettingsAnalyticsEvent()
	{
	}

	[CalledBy(Type = typeof(BadgeUIInfo), Member = "SendBadgeInfoAnalyticsEvent")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void SendCustomAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "IsAnyAnimationInProgress")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAnimationStatePlaying(Animator animator, AnimationStateRef animStateRef, int layerIndex = 0)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAnimationStatePlaying(Animator animator, string stateName, int layerIndex = 0)
	{
		return false;
	}

	[CalledBy(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	public static Texture2D GetInventoryGridIconTexture(string name)
	{
		return null;
	}

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	public static Texture2D GetInventoryGridIconTextureNonNull(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(UILargeTexture), Member = "OnEnable")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	public static Texture2D GetLargeTexture(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	public static Texture2D GetLoadingBackgroundTexture(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[CalledBy(Type = typeof(Utils), Member = "GetGearCoverflowTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetGearCoverflowDamageTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetGearCoverflowBlendTexture")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAsset")]
	[Calls(Type = typeof(TextureCache), Member = "CacheTexture")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private static Texture2D GetAddressableTexture(AssetReferenceTexture2D assetReference)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	private static Texture2D GetAddressableTexture(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsRenderObjectInstanceChild")]
	[Calls(Type = typeof(Utils), Member = "IsChildOfDynamicObj")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool CheckIfAkGameObjIsStatic(AkGameObj akGameObj)
	{
		return false;
	}

	[CalledBy(Type = typeof(Utils), Member = "IsChildOfDynamicObj")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsDynamicObj(GameObject obj)
	{
		return false;
	}

	[CalledBy(Type = typeof(Utils), Member = "CheckIfAkGameObjIsStatic")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsDynamicObj")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private static bool IsChildOfDynamicObj(AkGameObj obj)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static string ExecuteCmd(string commandArguments, bool returnOutput)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static string ExecuteCmdFromDir(string commandArguments, ExecuteCmdOptions options, string workingDirectory)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static IEnumerator ExecuteCmd(string commandArguments, ExecuteCmdOptions options, ExecuteCmdCallback callback)
	{
		return null;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "ShouldReplacePathEntry")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "PlayIntroMovie")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Initialize")]
	[CalledBy(Type = typeof(CameraGlobalRT), Member = "Start")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Utils), Member = "EnsureCommandLineArgsAreLoaded")]
	[Calls(Type = typeof(Utils), Member = "SanitizeCommandLineArgName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsCommandLineArgumentPresent(string arg)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnStory")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CalledBy(Type = typeof(Utils), Member = "GetSharedArguments")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Utils), Member = "EnsureCommandLineArgsAreLoaded")]
	[Calls(Type = typeof(Utils), Member = "SanitizeCommandLineArgName")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetCommandLineValue(string arg, out string value)
	{
		value = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	public static bool GetCommandLineValue(string arg, out int value)
	{
		value = default(int);
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool GetCommandLineValue<TEnum>(string arg, out TEnum value) where TEnum : struct
	{
		value = default(TEnum);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(Utils), Member = "GenerateCommandLineArgs")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static string GetSharedArguments()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Process), Member = "GetCurrentProcess")]
	[Calls(Type = typeof(Process), Member = "get_StartInfo")]
	[Calls(Type = typeof(ExternalProcess), Member = "RunCommand")]
	[CallsUnknownMethods(Count = 2)]
	public static void QuitAndRunApplication(string applicationPath, string commandArguments)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void QuitOrStopPlayMode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = ".ctor")]
	[Calls(Type = typeof(ProcessStartInfo), Member = "set_WindowStyle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	private static Process GetProcessForExecuteCmd(string commandArguments, string workingPath, ExecuteCmdOptions options)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Utils), Member = "ParseCommandLineArgs")]
	[CallsUnknownMethods(Count = 1)]
	public static void OverrideCommandLineWithTestArgs(string testCommandLine)
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs")]
	[Calls(Type = typeof(Utils), Member = "ParseCommandLineArgs")]
	private static void EnsureCommandLineArgsAreLoaded()
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CalledBy(Type = typeof(Utils), Member = "ParseCommandLineArgs")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsUnknownMethods(Count = 1)]
	private static string SanitizeCommandLineArgName(string keyName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Utils), Member = "OverrideCommandLineWithTestArgs")]
	[CalledBy(Type = typeof(Utils), Member = "EnsureCommandLineArgsAreLoaded")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SanitizeCommandLineArgName")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static Dictionary<string, string> ParseCommandLineArgs(string[] args)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnStory")]
	[CalledBy(Type = typeof(Utils), Member = "GetSharedArguments")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 23)]
	public static string GenerateCommandLineArgs(Dictionary<string, string> args)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static void Init()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 8)]
	[Calls(TypeFullName = "Interop", Member = "GetRandomBytes")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	public static string GetGuid()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(ConsoleManager), Member = "SetWind")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public static T GetRandomEnum<T>()
	{
		return default(T);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static string GetTimeSurvivedString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "UpdateProfileAfterChallengeComplete")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetSurvivalRecordSummaryText")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetTimeSurvivedString(float time)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[CalledBy(Type = typeof(JumpData), Member = "ToString")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(FireplaceInteraction), Member = "GetHoverText")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshEstimatedDurationLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "SetDailyTimerLabel")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[CallerCount(Count = 19)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetDurationString(int durationMinutes)
	{
		return null;
	}

	[CallerCount(Count = 24)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 85)]
	public static string GetExpandedDurationString(int durationMinutes)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetDurationStringRounded(int durationMinutes)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_sleep_length")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lighting_preview")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_time")]
	[CalledBy(Type = typeof(StartSettings), Member = "SetLockedTime")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeTOD), Member = "OnBehaviourPlay")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	[CallsUnknownMethods(Count = 3)]
	public static bool TryParseTOD(string todString, out float normalizedTOD)
	{
		normalizedTOD = default(float);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	public static string GetHardcodedRegionForLocation(string location)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	public static string GetTitleString(string locID)
	{
		return null;
	}

	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(LoadScene), Member = "GetSceneToLoad")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static string InferOutdoorSceneName(bool considerForceNextSceneLoadTrigger = false)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public static string GetFullObjectName(GameObject go)
	{
		return null;
	}

	[CallerCount(Count = 51)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public static GameObject GetChildGameObject(GameObject fromGameObject, string withName, bool includeInactive = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "FindTransform")]
	[CalledBy(Type = typeof(Utils), Member = "GetChildGameObjectWithNameContaining")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectWithNameContaining")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public static GameObject GetChildGameObjectWithNameContaining(GameObject fromGameObject, string withName, bool includeInactive = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CalledBy(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public static GameObject GetChildGameObjectByTag(GameObject fromGameObject, string tag, bool includeInactive = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 8)]
	public static GameObject GetChildGameObject(GameObject fromGameObject, string withName1, string withName2, bool includeInactive = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(KeroseneLampItem), Member = "PlayerSparkParticlesOnSpecific")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	public static GameObject ForceGetChildGameObject(GameObject fromGameObject, string withName)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	public static bool IsChildOfParent(GameObject child, GameObject parent)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	public static GameObject FindTopParentWithCollider(GameObject child)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 6)]
	public static GameObject GetTopParentWithLayer(GameObject child, int childLayer)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "Awake")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Awake")]
	[CalledBy(Type = typeof(AuroraElectrolizerController), Member = "Awake")]
	[CalledBy(Type = typeof(Phone), Member = "Awake")]
	[CalledBy(Type = typeof(MissionUtils), Member = "PostObjectEvent")]
	[CalledBy(Type = typeof(MissionUtils), Member = "PostAfflictionEvent")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	public static T GetComponentOnSelfOrParent<T>(GameObject obj) where T : Component
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Scene), Member = "GetRootGameObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static List<T> FindObjectsOfTypeInScene<T>(Scene scene, bool includeInactive = false) where T : Component
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static bool AreCollidersActiveAndEnabled(List<Collider> cs)
	{
		return false;
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SnowShelterNotOnGroundSnow")]
	[CalledBy(Type = typeof(PlayerManager), Member = "LeanToNotOnGroundSnow")]
	[CalledBy(Type = typeof(PlayerManager), Member = "BedrollOnIce")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceIsOnBrokenIce")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	public static Collider GetColliderUnderPosition(Vector3 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAnim")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[CalledBy(Type = typeof(Inventory), Member = "PositionAndRotateScatteredItem")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static string GetMaterialTagUnderPosition(Vector3 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "LeaveScorchMark")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	public static string GetMaterialTagForObjectAtPosition(GameObject obj, Vector3 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(FlareItem), Member = "DisableRendering")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "DisableRendering")]
	[CalledBy(Type = typeof(TorchItem), Member = "DisableRendering")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void DisableRendering(GameObject go)
	{
	}

	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void EnableRendering(GameObject go)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_save_view")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(FileInfo), Member = ".ctor")]
	[Calls(TypeFullName = "System.IO.FileSystem", Member = "FillAttributeInfo")]
	[Calls(TypeFullName = "System.IO.FileSystem", Member = "SetAttributes")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(TypeFullName = "System.IO.Win32Marshal", Member = "GetExceptionForWin32Error")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 10)]
	public static void SaveView(string name)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_restore_view")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(FlyMode), Member = "Warp")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 21)]
	public static void RestoreView(string name)
	{
	}

	[CallerCount(Count = 0)]
	public static float CelsiusToFahrenheit(float celsius)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float FahrenheitToCelsius(float fahrenheit)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float KilogramsToPounds(float kg)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float LitersToGallons(float liters)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int GallonsToOunces(float gallons)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public static float KmToMile(float km)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float MeterToFeet(float meter)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeSpawnCarcassSiteIfFarEnough")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(Carrion), Member = "StaggeredUpdateCarrion")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnRegionCloseEnoughForSpawning")]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(SnareItem), Member = "SkipCheckDueToPlayerProximity")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "UpdateBodyHarvest")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "DestroyIfFarAway")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "IsVisibleToPlayer")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "GetDistanceFromOuterRadiusToCamera")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_breakdown_all")]
	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "UpdateBigItems")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static float DistanceToMainCamera(Vector3 pos)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowLiquid")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowLiquidFractionalStack")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetLiquidQuantityStringWithUnits(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CalledBy(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CallsUnknownMethods(Count = 2)]
	public static string ToStringOneDigitFloor(float value)
	{
		return null;
	}

	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CalledBy(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CallsUnknownMethods(Count = 2)]
	public static string ToStringTwoDigitFloor(float value)
	{
		return null;
	}

	[CallerCount(Count = 52)]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetLiquidQuantityStringWithUnitsNoOunces(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetLiquidQuantityString(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateWaterRemedyUI")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	public static string GetLiquidQuantityStringNoOunces(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static string GetLiquidQualityString(LiquidQuality quality)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetFormattedDistance(MeasurementUnits units, float meters)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateDebugCompass")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static string GetCompassBearingAndDistance(Vector3 start, Vector3 end, out float angle, out float distance)
	{
		angle = default(float);
		distance = default(float);
		return null;
	}

	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWindproofDisplay")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWarmthDisplay")]
	[CalledBy(Type = typeof(Feat_ColdFusion), Member = "GetDescription")]
	[CalledBy(Type = typeof(Feat_ColdFusion), Member = "GetBonusDescription")]
	[CalledBy(Type = typeof(Forge), Member = "DisplayNotHotEnoughMessage")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "UpdateAirTemperature")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "UpdateWindchill")]
	[CalledBy(Type = typeof(Panel_Actions), Member = "UpdateFeelsLike")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateGlobalStatBars")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "UpdateTemperatureLabels")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateFeelsLikeLabel")]
	[CalledBy(Type = typeof(Panel_Rest), Member = "UpdateWarmthBonusLabel")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetTemperatureString(float temperatureCelsius, bool deltaTemperature, bool roundToNearestDegree, bool showPlusSign)
	{
		return null;
	}

	[CallerCount(Count = 69)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public static bool RollChance(float percent)
	{
		return false;
	}

	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "ToStringOneDigitFloor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetWeightOneDecimalPlaceWithUnitsString(MeasurementUnits units, float weightKG)
	{
		return null;
	}

	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowPowder")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWeightDisplay")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetWeightTwoDecimalPlacesWithUnitsString(MeasurementUnits units, float weightKG)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeSpawnProp")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeAddSpawnedPropToInventory")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CalledBy(Type = typeof(Action_SpawnObjectOnPlayer), Member = "MaybeSpawnProp")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static void SetObjectAndChildrenLayer(GameObject go, int layer, int preserveLayer)
	{
	}

	[CalledBy(Type = typeof(BreakDown), Member = "ProcessRaycastResults")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsChild(GameObject parent, GameObject child)
	{
		return false;
	}

	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(PumpkinPieSpecialItem), Member = "Hide")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateCopyOfThrownObject")]
	[CalledBy(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CalledBy(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "set_tag")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void ChangeLayersForGearItem(GameObject gameObject, int newLayer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	public static bool PositionIsOnscreen(Vector3 pos)
	{
		return false;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "GetSpeedFromMecanimBone")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "IsVisibleToPlayer")]
	[CalledBy(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static bool PositionIsOnscreen(Vector3 pos, float adjustViewport)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static float GetPlayerEyeHeight()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ShouldDoWanderPause")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector3 GetPlayerEyePosition()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(OpenClose), Member = "PlayAnimInReverse")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "GetPlayerEyePosition")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[CallsUnknownMethods(Count = 1)]
	public static bool PositionIsInLOSOfPlayer(Vector3 pos)
	{
		return false;
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetCapacityString")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "AddMenuItem")]
	[CallerCount(Count = 12)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetStringFromColor(Color col)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Color GetColorWithAlpha(Color source, float alpha)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetGearItem")]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetAddressableTexture")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsUnknownMethods(Count = 1)]
	public static Texture2D GetGearCoverflowTexture(GearItem gi)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetAddressableTexture")]
	[CallsUnknownMethods(Count = 1)]
	public static Texture2D GetGearCoverflowDamageTexture(GearItem gi)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetAddressableTexture")]
	[CallsUnknownMethods(Count = 1)]
	public static Texture2D GetGearCoverflowBlendTexture(GearItem gi)
	{
		return null;
	}

	[CallerCount(Count = 39)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameManager), Member = "GetConditionTable")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Texture2D GetInventoryIconTexture(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "MaybeRefreshTexture")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsUnknownMethods(Count = 1)]
	public static Texture2D GetInventoryIconTexture(GearItem gi, float conditionPercent)
	{
		return null;
	}

	[CalledBy(Type = typeof(GearSelectCoverflow), Member = "SetGearItem")]
	[CalledBy(Type = typeof(GearSelectCoverflow), Member = "SetGearItemIcon")]
	[CalledBy(Type = typeof(GearMessage), Member = "ShowNextMessageInQueue")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshCheckmarks")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	public static Texture2D GetInventoryIconTextureFromPrefabName(string prefabName, bool opened = false)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static Texture2D GetInventoryBGTexture(GearItem gi)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 62)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public static TType GetComponentInChildren<TType>(GameObject objRoot) where TType : Component
	{
		return null;
	}

	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "CameraPan")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "CameraPan")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "FindTransform")]
	[CalledBy(Type = typeof(Utils), Member = "FindChildRecursive")]
	[CalledBy(Type = typeof(Utils), Member = "GetInspectModePivot")]
	[CalledBy(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 19)]
	public static Transform FindChildRecursive(Transform trans, string childName)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static GameObject CreateOrFindGameObjectFromPath(string path)
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "GetCamera")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "CreateAnimatedCamera")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Scene), Member = "GetRootGameObjects")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 24)]
	public static GameObject CreateOrFindGameObjectFromPath(string path, Transform root)
	{
		return null;
	}

	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[CalledBy(Type = typeof(Inventory), Member = "GetLowestConditionGearThatMatchesName")]
	[CalledBy(Type = typeof(Inventory), Member = "GearInInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "GearInInventoryAtCondition")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[CalledBy(Type = typeof(Inventory), Member = "GearInInventory")]
	[CalledBy(Type = typeof(GearItemObject), Member = ".ctor")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetBestGearItemWithName")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(CustomSpawnedItemManager), Member = "SpawnBigItem")]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	public static string SanitizePrefabName(string prefabName)
	{
		return null;
	}

	[CalledBy(Type = typeof(BreakDown), Member = "SpawnYieldObjectsAndStickToGround")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 14)]
	public static float StickItemToGroundAtLocation(GameObject go, Vector3 location, float randomRadius = 1f)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileInfo), Member = ".ctor")]
	[Calls(TypeFullName = "System.IO.FileSystem", Member = "FillAttributeInfo")]
	[Calls(TypeFullName = "System.IO.FileSystem", Member = "SetAttributes")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(TypeFullName = "System.IO.Win32Marshal", Member = "GetExceptionForWin32Error")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static StreamWriter GetFileStream(string path)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SnapZoom")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[CallsUnknownMethods(Count = 1)]
	public static void SetCameraFOVSafe(Camera cam, float fov)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MaybeFlagMovmentPressedOnEnable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "ShouldIgnoreNavigationInput")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Navigate")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "MaybeFlagMovmentPressedOnEnable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ShouldIgnoreNavigationInput")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	public static bool GetMovementPressed(MonoBehaviour context, bool useSecondary)
	{
		return false;
	}

	[CallerCount(Count = 29)]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static float GetMenuMovementHorizontal(MonoBehaviour context, bool useSecondary = true, bool useTimer = true)
	{
		return 0f;
	}

	[CallerCount(Count = 42)]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static float GetMenuMovementVertical(MonoBehaviour context, bool useSecondary = true, bool useTimer = true)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_List<, >), Member = "HandleInput")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCollectibleNote")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Update")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(Utils), Member = "AdjustVerticalMoveWithTimer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetMenuMovementVerticalRightStick(MonoBehaviour context, bool useTimer = true, bool useTimerForCameraMouse = false)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static float AdjustVerticalMoveWithTimer(float movement)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static float GetMenuMovementHorizontalRightStick(MonoBehaviour context, bool useTimer = true)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool GetMenuMovementFilterLeft(MonoBehaviour context)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static bool GetMenuMovementFilterRight(MonoBehaviour context)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool GetMenuMovementAllowed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateMenuMovementDelay()
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(BootUpdate), Member = "Start")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static string GetPressAnyKeyString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public static bool ShouldDestroyWornOutGear(GearItem gi)
	{
		return false;
	}

	[CallerCount(Count = 208)]
	public static bool IsGamepadActive()
	{
		return false;
	}

	[CallerCount(Count = 67)]
	public static bool IsMouseActive()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RotatePlaceMesh")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "MaybeUpdateRotationAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RotateCurrentPlaceable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputManager), Member = "GetSprintDown")]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButtonHeldDown")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static float InputControlRotate(MonoBehaviour context, float rotationDegreesPerSecond, float mouseWheelRotationDegrees)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 11)]
	public static void LightPositionFixUp(Transform lightT, float lightLift)
	{
	}

	[CallerCount(Count = 380)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void SetActive(GameObject go, bool active)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public static Collider GetLargestCollider(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(BearEncounter), Member = "Awake")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "ForceRefreshSpawnedItems")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SetObjectToSpawnBoundingRadius")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static Renderer GetLargestBoundsRenderer(GameObject go)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Vector2 GetVector2WithDeadzone(Vector2 input, float deadzone)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	public static Vector2 GetVector2WithZerodSmallAxis(Vector2 input)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "InspectPrevGearItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "UpdateTransformFromInspectAndCamera")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeEnableInspectModeMesh")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 21)]
	public static void ShowInspectForGearItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDisableInspectModeMesh")]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 22)]
	public static void ExitInspectForGearItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(InspectGearController), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateGearTransformForInspection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static bool GetInspectModePivot(Inspect inspect, out Vector3 pivot)
	{
		pivot = default(Vector3);
		return false;
	}

	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	public static string GetRegionSpriteNameFromSaveSlotInfo(string saveSlotLocation)
	{
		return null;
	}

	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	public static bool SceneIsTransition(string sceneName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "GenerateLocationList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static string GetCurrentRegion()
	{
		return null;
	}

	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "Awake")]
	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	public static bool IsSceneTransition()
	{
		return false;
	}

	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_GiveBackPlayerItems), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(Container), Member = "GetWaterSupply")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public static GearItem[] GetGearItemsStoredInSceneByPlayer(bool includeContainers = true)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static float GetNumCaloriesInGearItems(GearItem[] gearItems)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	private static byte ToByte(float f)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "GetSurvivalRecordSummaryText")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	public static string ColorToHex(Color color)
	{
		return null;
	}

	[CalledBy(Type = typeof(WeatherSet), Member = "ReportHoursOfBlizzardForDay")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "ReportHoursOfBlizzardForDay")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetFirstDayLengthInHours()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 1)]
	public static bool DisableGUIPanCamera()
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "SetGearTransformForInspection")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	public static void UpdateTransformFromInspectAndCamera(Transform transform, vp_FPSCamera camera, Inspect inspect, Vector3 originalScale)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	public static bool StringAllNullTerminators(string s)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private static void CreateStreamWriter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private static void CloseStreamWriter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void Log(string line)
	{
	}

	[CallerCount(Count = 29)]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[Calls(Type = typeof(Rigidbody), Member = "set_collisionDetectionMode")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void SetIsKinematic(Rigidbody rb, bool enable)
	{
	}

	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void UseHigherPrecisionTimestep(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void DebugBulletHit(Vector3 p1, Vector3 p2)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void EnableDebugProjectiles(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsVector3NaN(Vector3 v)
	{
		return false;
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int GetSystemMetrics(SystemMetrics smIndex);

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public static bool IsDevelopmentBuild()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static GearItem GetGearItemFromObject(GameObject go)
	{
		return null;
	}

	[CalledBy(TypeFullName = "FPSLogger.LogData", Member = "FormatForWrite")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetFormattedBytes(double bytes)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleSlider), Member = "Start")]
	[CalledBy(Type = typeof(ContainerUI), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitSlider")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static UISlider GetSliderForScrollbar(GameObject scrollbar)
	{
		return null;
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[CalledBy(Type = typeof(CraftingRequirementTime), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	public static string FormatDisplayTimeMinutes(int minutes, bool includeUnits)
	{
		return null;
	}

	[CalledBy(TypeFullName = "Panel_MainMenu.<>c__DisplayClass93_0", Member = "<Initialize>b__0")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnClickCommunicationButton")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnViewPrivacyPolicy")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(BootUpdate), Member = "UpdateOptionalContentErrorState")]
	[CalledBy(Type = typeof(BootUpdate), Member = "OnContactSupport")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "OnItemButtonClicked")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(SteamFriends), Member = "ActivateGameOverlayToWebPage")]
	[Calls(Type = typeof(Application), Member = "OpenURL")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void OpenURL(string url)
	{
	}

	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public static void SetSHCoefficients(Vector3 position, CommandBuffer commandBuffer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static int Modulo(int x, int m)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public static float Ramp(float t)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float XZDistance(Vector3 a, Vector3 b)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float XZMagnitude(Vector3 vec)
	{
		return 0f;
	}

	[CallerCount(Count = 126)]
	public static bool Approximately(float a, float b, float epsilon = 0.0001f)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool IsZero(float a, float epsilon = 0.0001f)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool Approximately(double a, double b, double epsilon = 0.0001)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public static bool IsZero(double a, double epsilon = 0.0001)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public static Vector3 GetDirectionVector(Vector3 from, Vector3 to)
	{
		return default(Vector3);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public static float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTurnSpeedAnimationParameter")]
	[CalledBy(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_FaceTarget), Member = "GetTurnSpeed")]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public static float GetAngleDegrees(Vector3 v1, Vector3 v2)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public static Vector3 GetFlatVector(Vector3 v1)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	public static float CalculateSlopeUnderPosition(Vector3 pos)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeOnSlope")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "SetPlayerInclineRTPC")]
	[CalledBy(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static float CalculateSlopeUnderPosition(Vector3 pos, int ignoreMask)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CarcassSite), Member = "StickToGroundAndOrientOnSlope")]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "SpawnHideAndGutsAfterQuarter")]
	[CalledBy(Type = typeof(BodyCarry), Member = "StickBodyToGroundAtPlayersFeet")]
	[CalledBy(Type = typeof(Inventory), Member = "PositionAndRotateScatteredItem")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdatePlayerTransformForHunted2Dragging")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static Quaternion GetOrientationOnSlope(Transform t, Vector3 groundNormal)
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 13)]
	public static bool TestOBBOBB(OBB a, OBB b)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsSnowShelter")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsLeanTo")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithInteractiveProp")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "Overlaps")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "TestOBBOBB")]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallsUnknownMethods(Count = 21)]
	public static bool OrientedBoundingBoxesOverlap(GameObject a, GameObject b)
	{
		return false;
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Vector3 NearestPointInfinite(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(SnowDepthCapsuleRecord), Member = "GetDepthFracAtPosition")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector3 NearestPoint(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(DebugUtils), Member = "ShowFrustum")]
	[CallerCount(Count = 2)]
	public static Vector3 Plane3Intersect(Plane p1, Plane p2, Plane p3)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(Condition_VisibilityTest), Member = "OnCheck")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static bool SphereIntersectsCone(Vector3 sphereCentre, float sphereRadius, Vector3 conePoint, Vector3 coneUnitAxis, float coneAngle)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static float Berp(float start, float end, float value)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Bounce(float x, int num = 8)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Sway(float x, int num = 8)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float AlmostIdentity(float val, float threshold, float thresholdVal)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Impulse(float t, float span)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float CubicPulse(float t, float centre, float falloffDist)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static float ExpStep(float t, float exp, float pow)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Parabola(float t, float pow)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static float PowCurve(float t, float scale, float powA, float powB)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static float SmoothMinExp(float a, float b, float k)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float SmoothMinPoly(float a, float b, float k)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static float SmoothMinPow(float a, float b, float k)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float EaseInCubic(float t, float duration)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float EaseOutCubic(float t, float duration)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float EaseInOutCubic(float t, float duration)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float EaseOutBounce(float t, float duration)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CallerCount(Count = 1)]
	public static float ExpFilterWeight(float deltaTime, float timeConstant)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Condition), Member = "ApplyLowHealthStagger")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetAdjustedViewAngles")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateLowHealthStagger")]
	[CallerCount(Count = 9)]
	public static float ExpStep(float prevFilt, float next, float deltaTime, float timeConstant)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float ExpStep(float prevFilt, float next, float deltaTime, float timeConstant, float maxVel)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	public static float ExpStepAngle(float prevFilt, float next, float deltaTime, float timeConstant)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static Vector2 ExpStep(Vector2 prevFilt, Vector2 next, float deltaTime, float timeConstant)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized")]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2 ExpStep(Vector2 prevFilt, Vector2 next, float deltaTime, float timeConstant, float maxVel)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	public static Vector3 ExpStep(Vector3 prevFilt, Vector3 next, float deltaTime, float timeConstant)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static Vector3 ExpStep(Vector3 prevFilt, Vector3 next, float deltaTime, float timeConstant, float maxVel)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Quaternion ExpStep(Quaternion prevFilt, Quaternion next, float deltaTime, float timeConstant)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Quaternion ExpStepSlerp(Quaternion prevFilt, Quaternion next, float deltaTime, float timeConstant)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static float ShortestAngle(float targetAngle, float sourceAngle)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CallerCount(Count = 14)]
	public static float CalcHermite(float p0, float m0, float p1, float m1, float t)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CallerCount(Count = 9)]
	public static float CalcHermiteTangent(float p0, float m0, float p1, float m1, float t)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "ComputeSqrDistanceToNearest")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2 GeneratePoissonSample(List<Vector2> samples, int maxCandidates)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(Utils), Member = "GeneratePoissonSample")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static float ComputeSqrDistanceToNearest(List<Vector2> samples, Vector2 candidate)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float DistanceSqr(Vector2 a, Vector2 b)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float DistanceSqr(Vector3 a, Vector3 b)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static float Sqr(float a)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public static float FastSqrDist2DJob(float4 a, float4 b)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "TestAabbAxis")]
	[CallsUnknownMethods(Count = 2)]
	public static bool AabbOverlap(Bounds a, Bounds b, out Vector3 axis, out float distance)
	{
		axis = default(Vector3);
		distance = default(float);
		return false;
	}

	[CalledBy(Type = typeof(Utils), Member = "AabbOverlap")]
	[CallerCount(Count = 3)]
	public static bool TestAabbAxis(Vector3 axis, Bounds a, Bounds b, ref Vector3 minimumTranslationAxis, ref float minimumTranslationDistanceSqr)
	{
		return false;
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateTarget")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static float MoveToValue(float currentValue, float desiredValue, float speed)
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(BeachcombingSpawner), Member = "DrawAndPlaceBigItems")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ShuffleList<T>(IList<T> list, Func<int, int, int> randomRange = null)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	public static void ShuffleList<T>(IList<T> list, int maxCount, Func<int, int, int> randomRange = null)
	{
	}

	[CalledBy(Type = typeof(Action_MissionAddNew), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateName), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateDesc), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateTexture), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateTimer), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionMarkComplete), Member = "get_info")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "MaybePopulateMissionIds")]
	[Calls(Type = typeof(HashSet<>), Member = "Contains")]
	[CallsUnknownMethods(Count = 1)]
	public static bool MissionIDExists(string missionID)
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition_ObjectiveCompleted), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveUpdateDesc), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveUpdateTimer), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveCompleteMain), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "get_info")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "MaybePopulateMissionIds")]
	[Calls(Type = typeof(HashSet<>), Member = "Contains")]
	[CallsUnknownMethods(Count = 1)]
	public static bool ObjectiveIDExists(string objectiveID)
	{
		return false;
	}

	[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "get_info")]
	[CalledBy(Type = typeof(Action_RemoveMissionMarkerFromMap), Member = "get_info")]
	[CalledBy(Type = typeof(Action_RevealMapLocation), Member = "get_info")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "MaybePopulateMissionMapMarkerList")]
	[Calls(Type = typeof(HashSet<>), Member = "Contains")]
	[CallsUnknownMethods(Count = 1)]
	public static bool MissionMapMarkerIDExists(string markerID)
	{
		return false;
	}

	[CalledBy(Type = typeof(Utils), Member = "MissionMapMarkerIDExists")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssetHelper), Member = "TryLoadAssets")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(Addressables), Member = "Release")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	private static void MaybePopulateMissionMapMarkerList()
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "MissionIDExists")]
	[CalledBy(Type = typeof(Utils), Member = "ObjectiveIDExists")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionInfo), Member = "GetAllMissionInfos")]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(HashSet<>), Member = "UnionWith")]
	[Calls(Type = typeof(MissionInfo), Member = "ReleaseAllMissionInfos")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 19)]
	private static void MaybePopulateMissionIds()
	{
	}

	[CalledBy(Type = typeof(Elevator), Member = "GetInteractedDoor")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static bool RaycastNearest(Vector3 origin, Vector3 direction, out RaycastHit hit, float maxDistance, int layerMask)
	{
		hit = default(RaycastHit);
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixelBilinear")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static Texture2D GetBilinearScaledTexture(Texture2D source, int targetWidth, int targetHeight)
	{
		return null;
	}

	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadTransientProp")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventHide")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void DisableRenderers(GameObject parent)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "EventShow")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren")]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	[CallsUnknownMethods(Count = 2)]
	public static void EnableRenderers(GameObject parent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetAmbientLightScaled")]
	public static void SetAmbientLight(Color ambientColor)
	{
	}

	[CalledBy(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[CalledBy(Type = typeof(Utils), Member = "SetAmbientLight")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Color), Member = "get_linear")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public static void SetAmbientLightScaled(Color ambientColor, float probeScalar)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget")]
	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	public static void ClearWithFullScreenQuad(RenderTexture target, Color clearColor)
	{
	}

	[CalledBy(Type = typeof(SnowImprintCustom), Member = "Reposition")]
	[CalledBy(Type = typeof(SnowPatch), Member = "Initialize")]
	[CalledBy(Type = typeof(SnowPatch), Member = "GeneratePatchCoefficients")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "AddPatch")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "RaycastForTag")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public static void GeneratePatchCoefficients(Transform transform, Vector3 minPos, Vector3 maxPos, string tag, ref Vector3[] hermiteCoefficients, out Vector3 heightInfo)
	{
		heightInfo = default(Vector3);
	}

	[CalledBy(Type = typeof(SnowPatch), Member = "GetPatchHeightAtPosition")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[CallsUnknownMethods(Count = 2)]
	public static float GetPatchHeightAtPosition(Vector3 p, Vector3[] hermiteCoefficients)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(SnowPatch), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(SnowPatch), Member = "AddImprint")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[CallsUnknownMethods(Count = 2)]
	public static float GetPatchHeightTangentAtPosition(Vector3 p, Vector3[] hermiteCoefficients)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "Start")]
	[CalledBy(Type = typeof(Utils), Member = "GenerateGridMeshQuadrantSet")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static Mesh BuildGridMeshXZ(Vector2 dims, int vertsX, int vertsY, float uvMin = 0f, float uvMax = 1f)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "BuildGridMeshXZ")]
	[Calls(Type = typeof(Utils), Member = "BuildMeshForGridQuadrantSubset")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public static Mesh[] GenerateGridMeshQuadrantSet(Vector3 dims, int edgeVerts, int textureRes, float boundsYSize)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyShadows")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_shadows")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static void EnableShadows(bool enabled)
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "GenerateGridMeshQuadrantSet")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "get_triangles")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 31)]
	private static Mesh BuildMeshForGridQuadrantSubset(int mask, Mesh refMesh, float minUV)
	{
		return null;
	}

	[CalledBy(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private static bool RaycastForTag(string tag, Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		hitInfo = default(RaycastHit);
		return false;
	}

	[CalledBy(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void ClampPatchCoefficients(float centerY, float maxDelta)
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private static float CheckHeightAgainstCoords(float py, float maxDelta, int x, int z)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CalledBy(Type = typeof(Panel_Map), Member = "Serialize")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "HandleOnSettingsLoaded")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public static string SerializeObject(object obj)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 412)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static T DeserializeObject<T>(string text) where T : new()
	{
		return default(T);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastSpline), Member = "Allocate")]
	public static FastSpline CreateFastSpline(Spline spline, NativeArray<double> matrix)
	{
		return default(FastSpline);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetClosestPointParamOnSpline(Vector3 position, ref FastSpline spline)
	{
		return 0f;
	}

	[CalledBy(TypeFullName = "SplineManager.FastSplineJob", Member = "Execute")]
	[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSpline")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "RecalculateParameter")]
	[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
	private static float GetClosestPointParamOnSegmentIntern(Vector3 point, float start, float end, float step, ref FastSpline spline)
	{
		return 0f;
	}

	[CalledBy(TypeFullName = "SplineManager.FastSplineJob", Member = "Execute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RecalculateParameter")]
	[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
	public static Vector3 GetPositionOnSpline(ref FastSpline spline, float param)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(SplineAudioClip), Member = "Awake")]
	[CalledBy(Type = typeof(FastSpline), Member = "Allocate")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static int GetValidNodesCount(Spline spline)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
	[CalledBy(Type = typeof(Utils), Member = "GetPositionOnSpline")]
	[CallerCount(Count = 2)]
	private static SegmentParameter RecalculateParameter(double param, ref FastSpline spline)
	{
		return default(SegmentParameter);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	public static uint ParseSubtitles(string filename, ref Subtitle[] subtitles)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static uint ParseSubtitles(string filename, ref Subtitle[] subtitles, ref long frameRate)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventDisplaySubtitles")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	public static uint ParseSubtitles(TextAsset asset, ref Subtitle[] subtitles)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString")]
	[Calls(Type = typeof(StringReader), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static uint ParseSubtitles(TextAsset asset, ref Subtitle[] subtitles, ref long frameRate)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(long), Member = "TryParse")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(uint), Member = "TryParse")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private static uint ParseSubtitles(TextReader reader, ref Subtitle[] subtitles, ref long frameRate, string errorName)
	{
		return 0u;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static uint GetNextEndOrStartFrame(uint frame, Subtitle[] subtitles, uint numSubtitles)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CallsUnknownMethods(Count = 2)]
	public static void UpdateSubtitles(uint frame, Subtitle[] subtitles, uint numSubtitles)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static uint GetSubtitleFrame(float currentTimeSeconds, long frameRate = 24L)
	{
		return 0u;
	}

	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static float GetNextSkipTime(float currentTimeSeconds, Subtitle[] subtitles, uint numSubtitles, long frameRate = 24L)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	public static string GetTimeSinceText(TimeSpan timeSince)
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_QueueLoadScreenHint), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ForceCustomLoadScreen), Member = "get_info")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public static string LocKeyPreview(string myKey, bool stripLineBreaks, int clampLength)
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_ActivationTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_AudioTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_SayTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_SetControllerStateTrack), Member = "DoDynamicBinding")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetGameObjectOverride")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static GameObject FindTimelineDynamicBinding(string trackName, PlayableDirector director, string missionObjectId, string childObjectName = "")
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsAllowedToAccessNetwork()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CWebRequest_003Ed__339))]
	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.EnumerateFilesOperation", Member = "WebRequestEnumerateFiles")]
	[CalledBy(Type = typeof(WebUtils), Member = "DownloadData")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "RetrieveNewsFromServer")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "DownloadTexture")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerator WebRequest(string url, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWebRequest_003Ed__340))]
	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.DeleteOperation", Member = "WebRequestDeleteData")]
	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation", Member = "WebRequestBeginUploadData")]
	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation", Member = "WebRequestCommitUpload")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerator WebRequest(string url, WWWForm form, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWebRequestPut_003Ed__341))]
	[CalledBy(TypeFullName = "WebUtils.SteamCloudManager.UploadOperation", Member = "WebRequestUploadData")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerator WebRequestPut(string url, byte[] data, Dictionary<string, string> httpHeaders, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CWebRequest_003Ed__339), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CWebRequest_003Ed__340), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CWebRequestPut_003Ed__341), Member = "MoveNext")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 2)]
	private static bool PreValidatRequest(ref string url)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Utils()
	{
	}
}
