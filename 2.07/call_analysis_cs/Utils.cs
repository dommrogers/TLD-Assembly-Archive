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

			[CallsUnknownMethods(Count = 2)]
			[CallerCount(Count = 0)]
			public void Dispose()
			{
			}

			[CallAnalysisFailed]
			[CallerCount(Count = 1)]
			[CalledBy(Type = typeof(FastSpline), Member = "Allocate")]
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
				return default(bool);
			}
		}

		public int Step
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(int);
			}
		}

		public int ControlNodeCount
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(int);
			}
		}

		public double InvertedAccuracy
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(double);
			}
		}

		private bool IsBezier
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
		}

		public bool HasNodes
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return default(bool);
			}
		}

		public int SegmentCount
		{
			[CallerCount(Count = 0)]
			get
			{
				return default(int);
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
			return default(int);
		}

		[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private double GetSegmentLengthInternal(int idxFirstPoint, double startValue, double endValue, double step)
		{
			return default(double);
		}

		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(SplineManager), Member = "UnRegisterStaticSplineAudioClip")]
		[CalledBy(Type = typeof(SplineAudioClip), Member = "Terminate")]
		[CalledBy(Type = typeof(SplineAudioClip), Member = "OnDestroy")]
		[CallerCount(Count = 3)]
		public void Dispose()
		{
		}

		[CallerCount(Count = 4)]
		[Calls(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		[Calls(Type = typeof(FastSpline), Member = "RecalcVectors")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetSegmentLengthInternal")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetSegmentLengthInternal")]
		[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
		[CalledBy(Type = typeof(Utils), Member = "GetPositionOnSpline")]
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
			System.Runtime.CompilerServices.Unsafe.As<FastSplineNode, @null>(ref node0) = null;
			System.Runtime.CompilerServices.Unsafe.As<FastSplineNode, @null>(ref node1) = null;
			System.Runtime.CompilerServices.Unsafe.As<FastSplineNode, @null>(ref node2) = null;
			System.Runtime.CompilerServices.Unsafe.As<FastSplineNode, @null>(ref node3) = null;
		}

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "Normalize")]
		[Calls(Type = typeof(Vector3), Member = "Normalize")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		private void RecalcVectors(FastSplineNode node0, FastSplineNode node1, ref Vector3 P2, ref Vector3 P3)
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(Utils), Member = "CreateFastSpline")]
		[CalledBy(Type = typeof(SplineAudioClip), Member = "Initialize")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
		[Calls(Type = typeof(Utils), Member = "GetValidNodesCount")]
		[Calls(Type = typeof(SplineNode), Member = "get_Rotation")]
		[Calls(Type = typeof(LengthData), Member = "Calculate")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
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

	private sealed class _003CWebRequest_003Ed__337 : IDisposable, IEnumerator<object>, IEnumerator
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
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWebRequest_003Ed__337(int _003C_003E1__state)
		{
		}

		[CallsUnknownMethods(Count = 5)]
		[DebuggerHidden]
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(_003CWebRequest_003Ed__337), Member = "MoveNext")]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(UnityWebRequest), Member = "Get")]
		[Calls(Type = typeof(Utils), Member = "PreValidatRequest")]
		[Calls(Type = typeof(_003CWebRequest_003Ed__337), Member = "System.IDisposable.Dispose")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[CallsUnknownMethods(Count = 15)]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private void _003C_003Em__Finally1()
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CWebRequest_003Ed__338 : IEnumerator<object>, IEnumerator, IDisposable
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
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWebRequest_003Ed__338(int _003C_003E1__state)
		{
		}

		[CallsUnknownMethods(Count = 5)]
		[CalledBy(Type = typeof(_003CWebRequest_003Ed__338), Member = "MoveNext")]
		[DebuggerHidden]
		[CallerCount(Count = 1)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(UnityWebRequest), Member = ".ctor")]
		[CallsUnknownMethods(Count = 16)]
		[Calls(Type = typeof(_003CWebRequest_003Ed__338), Member = "System.IDisposable.Dispose")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetupPost")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(Utils), Member = "PreValidatRequest")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		private void _003C_003Em__Finally1()
		{
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CWebRequestPut_003Ed__339 : IEnumerator<object>, IEnumerator, IDisposable
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
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 28)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWebRequestPut_003Ed__339(int _003C_003E1__state)
		{
		}

		[CalledBy(Type = typeof(_003CWebRequestPut_003Ed__339), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 5)]
		[DebuggerHidden]
		[CallerCount(Count = 1)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(_003CWebRequestPut_003Ed__339), Member = "System.IDisposable.Dispose")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 6)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone")]
		[Calls(Type = typeof(Utils), Member = "PreValidatRequest")]
		[Calls(Type = typeof(UploadHandlerRaw), Member = ".ctor")]
		[Calls(Type = typeof(UnityWebRequest), Member = ".ctor")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[CallsUnknownMethods(Count = 17)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnAfterDeserialization")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	public static void EnableAnalytics(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	public static bool AreAnalyticsEnabled()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 5)]
	public static void SendDailyAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CalledBy(Type = typeof(ConditionRestBuff), Member = "Apply")]
	[CalledBy(Type = typeof(FatigueBuff), Member = "Apply")]
	[CalledBy(Type = typeof(FreezingBuff), Member = "Apply")]
	[CalledBy(Type = typeof(WellFed), Member = "WellFedStart")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[CalledBy(Type = typeof(ConditionOverTimeBuff), Member = "Apply")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkMissionComplete")]
	[CalledBy(Type = typeof(Log), Member = "AddAffliction")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveComplete")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateAndMaybeSendAnalytics")]
	[CallerCount(Count = 17)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	public static void SendGameplayAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	public static void SendGameStartAnalyticsEvent(RegionSpecification region)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "AddCustomEventData")]
	[Calls(Type = typeof(ExperienceModeManager), Member = "GetCurrentExperienceModeType")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	public static void SendGameOverAnalyticsEvent(GameOverResult gameOverResult)
	{
	}

	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(Utils), Member = "SendDailyAnalyticsEvent")]
	[CalledBy(Type = typeof(FeatEnabledTracker), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(FeatEnabledTracker), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "UpdateAnalytics")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	public static void SendCustomAnalyticsEventWithSeed(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetQualitySettings")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	public static void SendQualitySettingsAnalyticsEvent()
	{
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "SendBadgeInfoAnalyticsEvent")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "SendBadgeInfoAnalyticsEvent")]
	public static void SendCustomAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	public static bool IsAnimationStatePlaying(Animator animator, AnimationStateRef animStateRef, int layerIndex = 0)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAnimationStatePlaying(Animator animator, string stateName, int layerIndex = 0)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallerCount(Count = 8)]
	public static Texture2D GetInventoryGridIconTexture(string name)
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[CallerCount(Count = 24)]
	public static Texture2D GetInventoryGridIconTextureNonNull(string name)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextureCache), Member = "GetAddressableTexture")]
	[CalledBy(Type = typeof(UILargeTexture), Member = "OnEnable")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
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

	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "GetGearCoverflowBlendTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetGearCoverflowDamageTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetGearCoverflowTexture")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[Calls(Type = typeof(TextureCache), Member = "CacheTexture")]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsChildOfDynamicObj")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsRenderObjectInstanceChild")]
	public static bool CheckIfAkGameObjIsStatic(AkGameObj akGameObj)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Utils), Member = "IsChildOfDynamicObj")]
	[CallsUnknownMethods(Count = 2)]
	private static bool IsDynamicObj(GameObject obj)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Utils), Member = "CheckIfAkGameObjIsStatic")]
	[Calls(Type = typeof(Utils), Member = "IsDynamicObj")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	private static bool IsChildOfDynamicObj(AkGameObj obj)
	{
		return default(bool);
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

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Initialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "PlayIntroMovie")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "ShouldReplacePathEntry")]
	[Calls(Type = typeof(Utils), Member = "SanitizeCommandLineArgName")]
	[Calls(Type = typeof(Utils), Member = "EnsureCommandLineArgsAreLoaded")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	public static bool IsCommandLineArgumentPresent(string arg)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(Utils), Member = "GetSharedArguments")]
	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[Calls(Type = typeof(Utils), Member = "SanitizeCommandLineArgName")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnStory")]
	[Calls(Type = typeof(Utils), Member = "EnsureCommandLineArgsAreLoaded")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	public static bool GetCommandLineValue(string arg, out string value)
	{
		value = null;
		return default(bool);
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	public static bool GetCommandLineValue(string arg, out int value)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref value) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	public static bool GetCommandLineValue<TEnum>(string arg, out TEnum value) where TEnum : struct
	{
		System.Runtime.CompilerServices.Unsafe.As<TEnum, @null>(ref value) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(Utils), Member = "GenerateCommandLineArgs")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetSharedArguments()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ExternalProcess), Member = "RunCommand")]
	[Calls(Type = typeof(Process), Member = "get_StartInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = "GetCurrentProcess")]
	public static void QuitAndRunApplication(string applicationPath, string commandArguments)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void QuitOrStopPlayMode()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Process), Member = ".ctor")]
	[Calls(Type = typeof(ProcessStartInfo), Member = "set_WindowStyle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static Process GetProcessForExecuteCmd(string commandArguments, string workingPath, ExecuteCmdOptions options)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "ParseCommandLineArgs")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallerCount(Count = 0)]
	public static void OverrideCommandLineWithTestArgs(string testCommandLine)
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Environment), Member = "GetCommandLineArgs")]
	[Calls(Type = typeof(Utils), Member = "ParseCommandLineArgs")]
	[CalledBy(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	private static void EnsureCommandLineArgsAreLoaded()
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CalledBy(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CalledBy(Type = typeof(Utils), Member = "ParseCommandLineArgs")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Substring")]
	private static string SanitizeCommandLineArgName(string keyName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Utils), Member = "EnsureCommandLineArgsAreLoaded")]
	[CalledBy(Type = typeof(Utils), Member = "OverrideCommandLineWithTestArgs")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(Utils), Member = "SanitizeCommandLineArgName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Contains")]
	private static Dictionary<string, string> ParseCommandLineArgs(string[] args)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnStory")]
	[CalledBy(Type = typeof(Utils), Member = "GetSharedArguments")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GenerateCommandLineArgs(Dictionary<string, string> args)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static void Init()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	public static string GetGuid()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static T GetRandomEnum<T>()
	{
		return (T)null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static string GetTimeSurvivedString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetSurvivalRecordSummaryText")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "UpdateProfileAfterChallengeComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "SetTimeSurvivedLabel")]
	public static string GetTimeSurvivedString(float time)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshEstimatedDurationLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshLabels")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "SetDailyTimerLabel")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(FireplaceInteraction), Member = "GetHoverText")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[CalledBy(Type = typeof(JumpData), Member = "ToString")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetDurationString(int durationMinutes)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 85)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static string GetExpandedDurationString(int durationMinutes)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public static string GetDurationStringRounded(int durationMinutes)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_time")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayableBehaviourChangeTOD), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeTOD), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(StartSettings), Member = "SetLockedTime")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lighting_preview")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_sleep_length")]
	public static bool TryParseTOD(string todString, out float normalizedTOD)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref normalizedTOD) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	public static string GetHardcodedRegionForLocation(string location)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	public static string GetTitleString(string locID)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[Calls(Type = typeof(LoadScene), Member = "GetSceneToLoad")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	public static string InferOutdoorSceneName(bool considerForceNextSceneLoadTrigger = false)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 6)]
	public static string GetFullObjectName(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 51)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static GameObject GetChildGameObject(GameObject fromGameObject, string withName, bool includeInactive = false)
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectWithNameContaining")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Utils), Member = "GetChildGameObjectWithNameContaining")]
	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "FindTransform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	public static GameObject GetChildGameObjectWithNameContaining(GameObject fromGameObject, string withName, bool includeInactive = false)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	public static GameObject GetChildGameObjectByTag(GameObject fromGameObject, string tag, bool includeInactive = false)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	public static GameObject GetChildGameObject(GameObject fromGameObject, string withName1, string withName2, bool includeInactive = false)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "PlayerSparkParticlesOnSpecific")]
	public static GameObject ForceGetChildGameObject(GameObject fromGameObject, string withName)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(GearItem), Member = "InitializeInteraction")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CallsUnknownMethods(Count = 4)]
	public static bool IsChildOfParent(GameObject child, GameObject parent)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public static GameObject FindTopParentWithCollider(GameObject child)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CallsUnknownMethods(Count = 6)]
	public static GameObject GetTopParentWithLayer(GameObject child, int childLayer)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public static T GetComponentOnSelfOrParent<T>(GameObject obj) where T : Component
	{
		return null;
	}

	[Calls(Type = typeof(Scene), Member = "GetRootGameObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static List<T> FindObjectsOfTypeInScene<T>(Scene scene, bool includeInactive = false) where T : Component
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CallsUnknownMethods(Count = 5)]
	public static bool AreCollidersActiveAndEnabled(List<Collider> cs)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "LeanToNotOnGroundSnow")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceIsOnBrokenIce")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SnowShelterNotOnGroundSnow")]
	[CalledBy(Type = typeof(PlayerManager), Member = "BedrollOnIce")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	public static Collider GetColliderUnderPosition(Vector3 pos)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "PositionAndRotateScatteredItem")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(BaseAi), Member = "UpdateAnim")]
	public static string GetMaterialTagUnderPosition(Vector3 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "PlaceFootstep")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "LeaveScorchMark")]
	public static string GetMaterialTagForObjectAtPosition(GameObject obj, Vector3 pos)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(FlareItem), Member = "DisableRendering")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "DisableRendering")]
	[CalledBy(Type = typeof(TorchItem), Member = "DisableRendering")]
	[CallsUnknownMethods(Count = 3)]
	public static void DisableRendering(GameObject go)
	{
	}

	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	public static void EnableRendering(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_save_view")]
	[Calls(Type = typeof(System.IO.Win32Marshal), Member = "GetExceptionForWin32Error")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(System.IO.FileSystem), Member = "SetAttributes")]
	[Calls(Type = typeof(FileInfo), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.IO.FileSystem), Member = "FillAttributeInfo")]
	public static void SaveView(string name)
	{
	}

	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_restore_view")]
	[Calls(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[CallsDeduplicatedMethods(Count = 10)]
	public static void RestoreView(string name)
	{
	}

	[CallerCount(Count = 0)]
	public static float CelsiusToFahrenheit(float celsius)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float FahrenheitToCelsius(float fahrenheit)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float KilogramsToPounds(float kg)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float LitersToGallons(float liters)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static int GallonsToOunces(float gallons)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public static float KmToMile(float km)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float MeterToFeet(float meter)
	{
		return default(float);
	}

	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	public static float DistanceToMainCamera(Vector3 pos)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowLiquidFractionalStack")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowLiquidFractionalStack")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowLiquid")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	public static string GetLiquidQuantityStringWithUnits(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CalledBy(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[CalledBy(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	public static string ToStringOneDigitFloor(float value)
	{
		return null;
	}

	[CalledBy(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[CalledBy(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 7)]
	public static string ToStringTwoDigitFloor(float value)
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 53)]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	public static string GetLiquidQuantityStringWithUnitsNoOunces(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetLiquidQuantityString(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateWaterRemedyUI")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	public static string GetLiquidQuantityStringNoOunces(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	public static string GetLiquidQualityString(LiquidQuality quality)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public static string GetFormattedDistance(MeasurementUnits units, float meters)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateDebugCompass")]
	[CallsUnknownMethods(Count = 3)]
	public static string GetCompassBearingAndDistance(Vector3 start, Vector3 end, out float angle, out float distance)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref angle) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref distance) = null;
		return null;
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetTemperatureString(float temperatureCelsius, bool deltaTemperature, bool roundToNearestDegree, bool showPlusSign)
	{
		return null;
	}

	[CallerCount(Count = 68)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public static bool RollChance(float percent)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ToStringOneDigitFloor")]
	[Calls(Type = typeof(Utils), Member = "ToStringOneDigitFloor")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetWeightOneDecimalPlaceWithUnitsString(MeasurementUnits units, float weightKG)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWeightDisplay")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowPowder")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowPowder")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	public static string GetWeightTwoDecimalPlacesWithUnitsString(MeasurementUnits units, float weightKG)
	{
		return null;
	}

	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SpawnObjectOnPlayer), Member = "MaybeSpawnProp")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeAddSpawnedPropToInventory")]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeSpawnProp")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void SetObjectAndChildrenLayer(GameObject go, int layer, int preserveLayer)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(BreakDown), Member = "ProcessRaycastResults")]
	[CallsUnknownMethods(Count = 3)]
	public static bool IsChild(GameObject parent, GameObject child)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(GearItem), Member = "Drop")]
	[CalledBy(Type = typeof(PumpkinPieSpecialItem), Member = "Hide")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ExitMeshPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PrepareGhostedObject")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CalledBy(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CalledBy(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateCopyOfThrownObject")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "set_tag")]
	[Calls(Type = typeof(GameObject), Member = "set_tag")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	public static void ChangeLayersForGearItem(GameObject gameObject, int newLayer)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	public static bool PositionIsOnscreen(Vector3 pos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "PositionIsOnscreen")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetSpeedFromMecanimBone")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	public static bool PositionIsOnscreen(Vector3 pos, float adjustViewport)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static float GetPlayerEyeHeight()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "PositionIsInLOSOfPlayer")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(HuntedPart2WaypointController), Member = "ShouldDoWanderPause")]
	public static Vector3 GetPlayerEyePosition()
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(OpenClose), Member = "PlayAnimInReverse")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "GetPlayerEyePosition")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	public static bool PositionIsInLOSOfPlayer(Vector3 pos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(Encumber), Member = "GetCapacityString")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Encumber), Member = "GetCapacityString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CalledBy(Type = typeof(Encumber), Member = "GetCapacityString")]
	[CallerCount(Count = 12)]
	public static string GetStringFromColor(Color col)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	public static Color GetColorWithAlpha(Color source, float alpha)
	{
		return default(Color);
	}

	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetGearItem")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetAddressableTexture")]
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

	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetConditionTable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 39)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static Texture2D GetInventoryIconTexture(GearItem gi)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_BodyHarvest_MenuItem), Member = "MaybeRefreshTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	public static Texture2D GetInventoryIconTexture(GearItem gi, float conditionPercent)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshCheckmarks")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CalledBy(Type = typeof(GearSelectCoverflow), Member = "SetGearItemIcon")]
	[CalledBy(Type = typeof(GearSelectCoverflow), Member = "SetGearItem")]
	[CalledBy(Type = typeof(GearMessage), Member = "ShowNextMessageInQueue")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	public static Texture2D GetInventoryIconTextureFromPrefabName(string prefabName, bool opened = false)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "CameraPan")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[CalledBy(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[CalledBy(Type = typeof(Utils), Member = "GetInspectModePivot")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "FindTransform")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[CalledBy(Type = typeof(Utils), Member = "FindChildRecursive")]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "CameraPan")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
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

	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "CreateAnimatedCamera")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Scene), Member = "GetRootGameObjects")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "GetCamera")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	public static GameObject CreateOrFindGameObjectFromPath(string path, Transform root)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "GetLowestConditionGearThatMatchesName")]
	[CalledBy(Type = typeof(Inventory), Member = "GearInInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "GearInInventoryAtCondition")]
	[CalledBy(Type = typeof(GearItemObject), Member = ".ctor")]
	[CalledBy(Type = typeof(Inventory), Member = "GearInInventory")]
	[CalledBy(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetBestGearItemWithName")]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[CalledBy(Type = typeof(Inventory), Member = "AddGear")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemInPlayerInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateItemAtLocation")]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(GearItemObjectExtensions), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(SnowShelterManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	public static string SanitizePrefabName(string prefabName)
	{
		return null;
	}

	[CalledBy(Type = typeof(BreakDown), Member = "SpawnYieldObjectsAndStickToGround")]
	[CalledBy(Type = typeof(BreakDown), Member = "SpawnYieldObjectsAndStickToGround")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 12)]
	public static float StickItemToGroundAtLocation(GameObject go, Vector3 location, float randomRadius = 1f)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FileInfo), Member = ".ctor")]
	[Calls(Type = typeof(System.IO.FileSystem), Member = "FillAttributeInfo")]
	[Calls(Type = typeof(System.IO.FileSystem), Member = "SetAttributes")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(System.IO.Win32Marshal), Member = "GetExceptionForWin32Error")]
	[CallsUnknownMethods(Count = 3)]
	public static StreamWriter GetFileStream(string path)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SnapZoom")]
	public static void SetCameraFOVSafe(Camera cam, float fov)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ShouldIgnoreNavigationInput")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "MaybeFlagMovmentPressedOnEnable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Navigate")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "ShouldIgnoreNavigationInput")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MaybeFlagMovmentPressedOnEnable")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	public static bool GetMovementPressed(MonoBehaviour context, bool useSecondary)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 29)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static float GetMenuMovementHorizontal(MonoBehaviour context, bool useSecondary = true, bool useTimer = true)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	public static float GetMenuMovementVertical(MonoBehaviour context, bool useSecondary = true, bool useTimer = true)
	{
		return default(float);
	}

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_List<, >), Member = "HandleInput")]
	[Calls(Type = typeof(Utils), Member = "AdjustVerticalMoveWithTimer")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCollectibleNote")]
	public static float GetMenuMovementVerticalRightStick(MonoBehaviour context, bool useTimer = true, bool useTimerForCameraMouse = false)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static float AdjustVerticalMoveWithTimer(float movement)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	public static float GetMenuMovementHorizontalRightStick(MonoBehaviour context, bool useTimer = true)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[CallsUnknownMethods(Count = 2)]
	public static bool GetMenuMovementFilterLeft(MonoBehaviour context)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool GetMenuMovementFilterRight(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool GetMenuMovementAllowed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateMenuMovementDelay()
	{
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(BootUpdate), Member = "Start")]
	public static string GetPressAnyKeyString()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static bool ShouldDestroyWornOutGear(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 206)]
	public static bool IsGamepadActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 69)]
	public static bool IsMouseActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputManager), Member = "GetSprintDown")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButtonHeldDown")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "MaybeUpdateRotationAction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RotateCurrentPlaceable")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RotatePlaceMesh")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	public static float InputControlRotate(MonoBehaviour context, float rotationDegreesPerSecond, float mouseWheelRotationDegrees)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsUnknownMethods(Count = 11)]
	public static void LightPositionFixUp(Transform lightT, float lightLift)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 383)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public static void SetActive(GameObject go, bool active)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CallsUnknownMethods(Count = 6)]
	public static Collider GetLargestCollider(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SetObjectToSpawnBoundingRadius")]
	[CalledBy(Type = typeof(BearEncounter), Member = "Awake")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "Start")]
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

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "EnterInspectGearMode")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "InspectPrevGearItem")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "UpdateTransformFromInspectAndCamera")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeEnableInspectModeMesh")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	public static void ShowInspectForGearItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Update")]
	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDisableInspectModeMesh")]
	[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	public static void ExitInspectForGearItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateGearTransformForInspection")]
	[CalledBy(Type = typeof(InspectGearController), Member = "Update")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool GetInspectModePivot(Inspect inspect, out Vector3 pivot)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref pivot) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static string GetRegionSpriteNameFromSaveSlotInfo(string saveSlotLocation)
	{
		return null;
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static bool SceneIsTransition(string sceneName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "GenerateLocationList")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public static string GetCurrentRegion()
	{
		return null;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "Awake")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	public static bool IsSceneTransition()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[CalledBy(Type = typeof(Action_GiveBackPlayerItems), Member = "OnExecute")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Container), Member = "GetWaterSupply")]
	public static GearItem[] GetGearItemsStoredInSceneByPlayer(bool includeContainers = true)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static float GetNumCaloriesInGearItems(GearItem[] gearItems)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	private static byte ToByte(float f)
	{
		return default(byte);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetSurvivalRecordSummaryText")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
	public static string ColorToHex(Color color)
	{
		return null;
	}

	[CalledBy(Type = typeof(WeatherSetData), Member = "ReportHoursOfBlizzardForDay")]
	[CalledBy(Type = typeof(WeatherSetData), Member = "ReportHoursOfBlizzardForDay")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportHoursOfBlizzardForDay")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportHoursOfBlizzardForDay")]
	public static float GetFirstDayLengthInHours()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 0)]
	public static bool DisableGUIPanCamera()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[Calls(Type = typeof(Transform), Member = "Translate")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetGearTransformForInspection")]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CallsUnknownMethods(Count = 9)]
	public static void UpdateTransformFromInspectAndCamera(Transform transform, vp_FPSCamera camera, Inspect inspect, Vector3 originalScale)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	public static bool StringAllNullTerminators(string s)
	{
		return default(bool);
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

	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[Calls(Type = typeof(Rigidbody), Member = "set_collisionDetectionMode")]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Rigidbody), Member = "set_collisionDetectionMode")]
	public static void SetIsKinematic(Rigidbody rb, bool enable)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallsUnknownMethods(Count = 2)]
	public static void UseHigherPrecisionTimestep(bool enable)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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
		return default(bool);
	}

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern int GetSystemMetrics(SystemMetrics smIndex);

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static bool IsDevelopmentBuild()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static GearItem GetGearItemFromObject(GameObject go)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Format")]
	[CalledBy(Type = typeof(FPSLogger.LogData), Member = "FormatForWrite")]
	[CalledBy(Type = typeof(FPSLogger.LogData), Member = "FormatForWrite")]
	[CalledBy(Type = typeof(FPSLogger.LogData), Member = "FormatForWrite")]
	[CalledBy(Type = typeof(FPSLogger.LogData), Member = "FormatForWrite")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetFormattedBytes(double bytes)
	{
		return null;
	}

	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "InitSlider")]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(ContainerUI), Member = "Initialize")]
	[CalledBy(Type = typeof(ContainerUI), Member = "Initialize")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	public static UISlider GetSliderForScrollbar(GameObject scrollbar)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(CraftingRequirementTime), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(int), Member = "ToString")]
	public static string FormatDisplayTimeMinutes(int minutes, bool includeUnits)
	{
		return null;
	}

	[CalledBy(Type = typeof(BootUpdate), Member = "UpdateOptionalContentErrorState")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(BootUpdate), Member = "OnContactSupport")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnViewPrivacyPolicy")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "OnItemButtonClicked")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(NewsCarousel), Member = "UpdateActiveCarousel")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnClickCommunicationButton")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Application), Member = "OpenURL")]
	[Calls(Type = typeof(SteamFriends), Member = "ActivateGameOverlayToWebPage")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(Panel_MainMenu._003C_003Ec__DisplayClass93_0), Member = "<Initialize>b__0")]
	public static void OpenURL(string url)
	{
	}

	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(DynamicDecalsManager), Member = "RenderDynamicDecal")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	public static void SetSHCoefficients(Vector3 position, CommandBuffer commandBuffer)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static int Modulo(int x, int m)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public static float Ramp(float t)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float XZDistance(Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float XZMagnitude(Vector3 vec)
	{
		return default(float);
	}

	[CallerCount(Count = 128)]
	public static bool Approximately(float a, float b, float epsilon = 0.0001f)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsZero(float a, float epsilon = 0.0001f)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool Approximately(double a, double b, double epsilon = 0.0001)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool IsZero(double a, double epsilon = 0.0001)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public static Vector3 GetDirectionVector(Vector3 from, Vector3 to)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Action_FaceTarget), Member = "GetTurnSpeed")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetAnimationParameters")]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTurnSpeedAnimationParameter")]
	[CalledBy(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[CallerCount(Count = 5)]
	public static float GetAngleDegrees(Vector3 v1, Vector3 v2)
	{
		return default(float);
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
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "SetPlayerInclineRTPC")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[Calls(Type = typeof(Physics), Member = "SphereCast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeOnSlope")]
	public static float CalculateSlopeUnderPosition(Vector3 pos, int ignoreMask)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Inventory), Member = "PositionAndRotateScatteredItem")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdatePlayerTransformForHunted2Dragging")]
	[CalledBy(Type = typeof(BodyCarry), Member = "StickBodyToGroundAtPlayersFeet")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(CarcassSite), Member = "StickToGroundAndOrientOnSlope")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	public static Quaternion GetOrientationOnSlope(Transform t, Vector3 groundNormal)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor")]
	[CalledBy(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[CallsUnknownMethods(Count = 13)]
	public static bool TestOBBOBB(OBB a, OBB b)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsSnowShelter")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsLeanTo")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Utils), Member = "TestOBBOBB")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "Overlaps")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithInteractiveProp")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 28)]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	public static bool OrientedBoundingBoxesOverlap(GameObject a, GameObject b)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CallsUnknownMethods(Count = 1)]
	public static Vector3 NearestPointInfinite(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(SnowDepthCapsuleRecord), Member = "GetDepthFracAtPosition")]
	[CallsUnknownMethods(Count = 2)]
	public static Vector3 NearestPoint(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(DebugUtils), Member = "ShowFrustum")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowFrustum")]
	public static Vector3 Plane3Intersect(Plane p1, Plane p2, Plane p3)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Condition_VisibilityTest), Member = "OnCheck")]
	[CallsUnknownMethods(Count = 4)]
	public static bool SphereIntersectsCone(Vector3 sphereCentre, float sphereRadius, Vector3 conePoint, Vector3 coneUnitAxis, float coneAngle)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static float Berp(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Bounce(float x, int num = 8)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static float Sway(float x, int num = 8)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float AlmostIdentity(float val, float threshold, float thresholdVal)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Impulse(float t, float span)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float CubicPulse(float t, float centre, float falloffDist)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static float ExpStep(float t, float exp, float pow)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static float Parabola(float t, float pow)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static float PowCurve(float t, float scale, float powA, float powB)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static float SmoothMinExp(float a, float b, float k)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float SmoothMinPoly(float a, float b, float k)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static float SmoothMinPow(float a, float b, float k)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float EaseInCubic(float t, float duration)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float EaseOutCubic(float t, float duration)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float EaseInOutCubic(float t, float duration)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float EaseOutBounce(float t, float duration)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CallerCount(Count = 1)]
	public static float ExpFilterWeight(float deltaTime, float timeConstant)
	{
		return default(float);
	}

	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Condition), Member = "ApplyLowHealthStagger")]
	[CalledBy(Type = typeof(Condition), Member = "ApplyLowHealthStagger")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetAdjustedViewAngles")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateLowHealthStagger")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateLowHealthStagger")]
	public static float ExpStep(float prevFilt, float next, float deltaTime, float timeConstant)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float ExpStep(float prevFilt, float next, float deltaTime, float timeConstant, float maxVel)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	public static float ExpStepAngle(float prevFilt, float next, float deltaTime, float timeConstant)
	{
		return default(float);
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

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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
		return default(float);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	public static float CalcHermite(float p0, float m0, float p1, float m1, float t)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	[CallerCount(Count = 9)]
	public static float CalcHermiteTangent(float p0, float m0, float p1, float m1, float t)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "ComputeSqrDistanceToNearest")]
	[CallsUnknownMethods(Count = 1)]
	public static Vector2 GeneratePoissonSample(List<Vector2> samples, int maxCandidates)
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "GeneratePoissonSample")]
	public static float ComputeSqrDistanceToNearest(List<Vector2> samples, Vector2 candidate)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float DistanceSqr(Vector2 a, Vector2 b)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float DistanceSqr(Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static float Sqr(float a)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public static float FastSqrDist2DJob(float4 a, float4 b)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[Calls(Type = typeof(Utils), Member = "TestAabbAxis")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "TestAabbAxis")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "TestAabbAxis")]
	public static bool AabbOverlap(Bounds a, Bounds b, out Vector3 axis, out float distance)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref axis) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref distance) = null;
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Utils), Member = "AabbOverlap")]
	[CalledBy(Type = typeof(Utils), Member = "AabbOverlap")]
	[CalledBy(Type = typeof(Utils), Member = "AabbOverlap")]
	public static bool TestAabbAxis(Vector3 axis, Bounds a, Bounds b, ref Vector3 minimumTranslationAxis, ref float minimumTranslationDistanceSqr)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateTarget")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	public static float MoveToValue(float currentValue, float desiredValue, float speed)
	{
		return default(float);
	}

	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "MaybePopulateMissionIds")]
	[CalledBy(Type = typeof(Action_MissionAddNew), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateName), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateDesc), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateTexture), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateTimer), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionMarkComplete), Member = "get_info")]
	[CallsUnknownMethods(Count = 2)]
	public static bool MissionIDExists(string missionID)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_ObjectiveCompleteMain), Member = "get_info")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveUpdateTimer), Member = "get_info")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "get_info")]
	[CalledBy(Type = typeof(Condition_ObjectiveCompleted), Member = "get_info")]
	[Calls(Type = typeof(Utils), Member = "MaybePopulateMissionIds")]
	[CalledBy(Type = typeof(Action_ObjectiveUpdateDesc), Member = "get_info")]
	public static bool ObjectiveIDExists(string objectiveID)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_RemoveMissionMarkerFromMap), Member = "get_info")]
	[CalledBy(Type = typeof(Action_RevealMapLocation), Member = "get_info")]
	[Calls(Type = typeof(Utils), Member = "MaybePopulateMissionMapMarkerList")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "get_info")]
	public static bool MissionMapMarkerIDExists(string markerID)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(Utils), Member = "MissionMapMarkerIDExists")]
	[CallsUnknownMethods(Count = 16)]
	private static void MaybePopulateMissionMapMarkerList()
	{
	}

	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(Utils), Member = "ObjectiveIDExists")]
	[Calls(Type = typeof(MissionInfo), Member = "ReleaseAllMissionInfos")]
	[CalledBy(Type = typeof(Utils), Member = "MissionIDExists")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionInfo), Member = "GetAllMissionInfos")]
	private static void MaybePopulateMissionIds()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Elevator), Member = "GetInteractedDoor")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	public static bool RaycastNearest(Vector3 origin, Vector3 direction, out RaycastHit hit, float maxDistance, int layerMask)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hit) = null;
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixelBilinear")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsUnknownMethods(Count = 2)]
	public static Texture2D GetBilinearScaledTexture(Texture2D source, int targetWidth, int targetHeight)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventHide")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadTransientProp")]
	[CallerCount(Count = 3)]
	public static void DisableRenderers(GameObject parent)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventShow")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	public static void EnableRenderers(GameObject parent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetAmbientLightScaled")]
	public static void SetAmbientLight(Color ambientColor)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Color), Member = "get_linear")]
	[CalledBy(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[CalledBy(Type = typeof(Utils), Member = "SetAmbientLight")]
	[CallsUnknownMethods(Count = 6)]
	public static void SetAmbientLightScaled(Color ambientColor, float probeScalar)
	{
	}

	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GL), Member = "TexCoord3")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Shader), Member = "Find")]
	public static void ClearWithFullScreenQuad(RenderTexture target, Color clearColor)
	{
	}

	[Calls(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "AddPatch")]
	[CalledBy(Type = typeof(SnowPatch), Member = "GeneratePatchCoefficients")]
	[CalledBy(Type = typeof(SnowPatch), Member = "Initialize")]
	[CalledBy(Type = typeof(SnowImprintCustom), Member = "Reposition")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Utils), Member = "RaycastForTag")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "RaycastForTag")]
	public static void GeneratePatchCoefficients(Transform transform, Vector3 minPos, Vector3 maxPos, string tag, ref Vector3[] hermiteCoefficients, out Vector3 heightInfo)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref heightInfo) = null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SnowPatch), Member = "GetPatchHeightAtPosition")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	public static float GetPatchHeightAtPosition(Vector3 p, Vector3[] hermiteCoefficients)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SnowPatch), Member = "AddImprint")]
	[CalledBy(Type = typeof(SnowPatch), Member = "GetPatchHeightTangentAtPosition")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	public static float GetPatchHeightTangentAtPosition(Vector3 p, Vector3[] hermiteCoefficients)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Utils), Member = "GenerateGridMeshQuadrantSet")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "Start")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel")]
	[Calls(Type = typeof(Mesh), Member = "SetSizedArrayForChannel")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static Mesh BuildGridMeshXZ(Vector2 dims, int vertsX, int vertsY, float uvMin = 0f, float uvMax = 1f)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "BuildGridMeshXZ")]
	[Calls(Type = typeof(Utils), Member = "BuildMeshForGridQuadrantSubset")]
	[CallsUnknownMethods(Count = 12)]
	public static Mesh[] GenerateGridMeshQuadrantSet(Vector3 dims, int edgeVerts, int textureRes, float boundsYSize)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyShadows")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyShadows")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_shadows")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_shadows")]
	public static void EnableShadows(bool enabled)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(Mesh), Member = "get_triangles")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(Utils), Member = "GenerateGridMeshQuadrantSet")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(Mesh), Member = "get_triangles")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[CallerCount(Count = 1)]
	private static Mesh BuildMeshForGridQuadrantSubset(int mask, Mesh refMesh, float minUV)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[CalledBy(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	private static bool RaycastForTag(string tag, Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hitInfo) = null;
		return default(bool);
	}

	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[CalledBy(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[CallerCount(Count = 1)]
	private static void ClampPatchCoefficients(float centerY, float maxDelta)
	{
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CallsUnknownMethods(Count = 3)]
	private static float CheckHeightAgainstCoords(float py, float maxDelta, int x, int z)
	{
		return default(float);
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 50)]
	public static string SerializeObject(object obj)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 410)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static T DeserializeObject<T>(string text) where T : new()
	{
		return (T)null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastSpline), Member = "Allocate")]
	public static FastSpline CreateFastSpline(Spline spline, NativeArray<double> matrix)
	{
		return default(FastSpline);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
	[Calls(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
	[CallsUnknownMethods(Count = 1)]
	public static float GetClosestPointParamOnSpline(Vector3 position, ref FastSpline spline)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSpline")]
	[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSpline")]
	[CalledBy(Type = typeof(SplineManager.FastSplineJob), Member = "Execute")]
	[CalledBy(Type = typeof(SplineManager.FastSplineJob), Member = "Execute")]
	[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
	[Calls(Type = typeof(Utils), Member = "RecalculateParameter")]
	[CallerCount(Count = 4)]
	private static float GetClosestPointParamOnSegmentIntern(Vector3 point, float start, float end, float step, ref FastSpline spline)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "RecalculateParameter")]
	[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
	[CalledBy(Type = typeof(SplineManager.FastSplineJob), Member = "Execute")]
	public static Vector3 GetPositionOnSpline(ref FastSpline spline, float param)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Awake")]
	[CalledBy(Type = typeof(FastSpline), Member = "Allocate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static int GetValidNodesCount(Spline spline)
	{
		return default(int);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
	[CalledBy(Type = typeof(Utils), Member = "GetPositionOnSpline")]
	private static SegmentParameter RecalculateParameter(double param, ref FastSpline spline)
	{
		return default(SegmentParameter);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	public static uint ParseSubtitles(string filename, ref Subtitle[] subtitles)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	public static uint ParseSubtitles(string filename, ref Subtitle[] subtitles, ref long frameRate)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventDisplaySubtitles")]
	public static uint ParseSubtitles(TextAsset asset, ref Subtitle[] subtitles)
	{
		return default(uint);
	}

	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(StringReader), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString")]
	[CallsUnknownMethods(Count = 5)]
	public static uint ParseSubtitles(TextAsset asset, ref Subtitle[] subtitles, ref long frameRate)
	{
		return default(uint);
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	private static uint ParseSubtitles(TextReader reader, ref Subtitle[] subtitles, ref long frameRate, string errorName)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public static uint GetNextEndOrStartFrame(uint frame, Subtitle[] subtitles, uint numSubtitles)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	public static void UpdateSubtitles(uint frame, Subtitle[] subtitles, uint numSubtitles)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static uint GetSubtitleFrame(float currentTimeSeconds, long frameRate = 24L)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	public static float GetNextSkipTime(float currentTimeSeconds, Subtitle[] subtitles, uint numSubtitles, long frameRate = 24L)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	public static string GetTimeSinceText(TimeSpan timeSince)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Action_ForceCustomLoadScreen), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ForceCustomLoadScreen), Member = "get_info")]
	[CalledBy(Type = typeof(Action_QueueLoadScreenHint), Member = "get_info")]
	[CalledBy(Type = typeof(Action_QueueLoadScreenHint), Member = "get_info")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Action_QueueLoadScreenHint), Member = "get_info")]
	public static string LocKeyPreview(string myKey, bool stripLineBreaks, int clampLength)
	{
		return null;
	}

	[CalledBy(Type = typeof(TLD_AudioTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_SetControllerStateTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_SayTrack), Member = "DoDynamicBinding")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "DoDynamicBinding")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetGameObjectOverride")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(TLD_ActivationTrack), Member = "DoDynamicBinding")]
	public static GameObject FindTimelineDynamicBinding(string trackName, PlayableDirector director, string missionObjectId, string childObjectName = "")
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsAllowedToAccessNetwork()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(_003CWebRequest_003Ed__337))]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.EnumerateFilesOperation), Member = "WebRequestEnumerateFiles")]
	[CalledBy(Type = typeof(WebUtils), Member = "DownloadData")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "RetrieveNewsFromServer")]
	[CalledBy(Type = typeof(NewsCarousel), Member = "DownloadTexture")]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerator WebRequest(string url, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.UploadOperation), Member = "WebRequestBeginUploadData")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.UploadOperation), Member = "WebRequestCommitUpload")]
	[CallerCount(Count = 3)]
	[IteratorStateMachine(typeof(_003CWebRequest_003Ed__338))]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.DeleteOperation), Member = "WebRequestDeleteData")]
	public static IEnumerator WebRequest(string url, WWWForm form, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWebRequestPut_003Ed__339))]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.UploadOperation), Member = "WebRequestUploadData")]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerator WebRequestPut(string url, byte[] data, Dictionary<string, string> httpHeaders, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(_003CWebRequestPut_003Ed__339), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CWebRequest_003Ed__338), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(_003CWebRequest_003Ed__337), Member = "MoveNext")]
	private static bool PreValidatRequest(ref string url)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Utils()
	{
	}
}
