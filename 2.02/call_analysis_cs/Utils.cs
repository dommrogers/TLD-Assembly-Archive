using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using SpecialEvents;
using Steamworks;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
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

	public enum ParseErrorLevel
	{
		Warning,
		Error
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

			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 3)]
			[CalledBy(Type = typeof(FastSpline), Member = "Dispose")]
			[CallsUnknownMethods(Count = 4)]
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

		[CalledBy(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 9)]
		[CalledBy(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		private FastSplineNode GetNode(int idxNode, int idxOffset)
		{
			return default(FastSplineNode);
		}

		[CallerCount(Count = 0)]
		public int MaxNodeIndex()
		{
			return default(int);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		[CallsUnknownMethods(Count = 1)]
		private double GetSegmentLengthInternal(int idxFirstPoint, double startValue, double endValue, double step)
		{
			return default(double);
		}

		[CalledBy(Type = typeof(SplineAudioClip), Member = "Terminate")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(SplineAudioClip), Member = "OnDestroy")]
		[CalledBy(Type = typeof(SplineManager), Member = "UnRegisterStaticSplineAudioClip")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(LengthData), Member = "Dispose")]
		public void Dispose()
		{
		}

		[CalledBy(Type = typeof(FastSpline), Member = "GetSegmentLengthInternal")]
		[CalledBy(Type = typeof(Utils), Member = "GetPositionOnSpline")]
		[Calls(Type = typeof(FastSpline), Member = "InterpolatePosition")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetSegmentLengthInternal")]
		[Calls(Type = typeof(FastSpline), Member = "GetAdjacentNodes")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(FastSpline), Member = "RecalcVectors")]
		public Vector3 GetPositionInternal(SegmentParameter sParam)
		{
			return default(Vector3);
		}

		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		private Vector3 InterpolatePosition(double t, Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
		{
			return default(Vector3);
		}

		[CalledBy(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		[Calls(Type = typeof(FastSpline), Member = "GetNode")]
		[Calls(Type = typeof(FastSpline), Member = "GetNode")]
		[Calls(Type = typeof(FastSpline), Member = "GetNode")]
		[Calls(Type = typeof(FastSpline), Member = "GetNode")]
		[Calls(Type = typeof(FastSpline), Member = "GetNode")]
		[Calls(Type = typeof(FastSpline), Member = "GetNode")]
		[Calls(Type = typeof(FastSpline), Member = "GetNode")]
		[Calls(Type = typeof(FastSpline), Member = "GetNode")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(FastSpline), Member = "GetNode")]
		private void GetAdjacentNodes(SegmentParameter sParam, out FastSplineNode node0, out FastSplineNode node1, out FastSplineNode node2, out FastSplineNode node3)
		{
			System.Runtime.CompilerServices.Unsafe.As<FastSplineNode, @null>(ref node0) = null;
			System.Runtime.CompilerServices.Unsafe.As<FastSplineNode, @null>(ref node1) = null;
			System.Runtime.CompilerServices.Unsafe.As<FastSplineNode, @null>(ref node2) = null;
			System.Runtime.CompilerServices.Unsafe.As<FastSplineNode, @null>(ref node3) = null;
		}

		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Vector3), Member = "Normalize")]
		[Calls(Type = typeof(Vector3), Member = "Normalize")]
		[Calls(Type = typeof(Vector3), Member = "get_forward")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Vector3), Member = "get_forward")]
		[CalledBy(Type = typeof(FastSpline), Member = "GetPositionInternal")]
		private void RecalcVectors(FastSplineNode node0, FastSplineNode node1, ref Vector3 P2, ref Vector3 P3)
		{
		}

		[CalledBy(Type = typeof(SplineAudioClip), Member = "Initialize")]
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CalledBy(Type = typeof(Utils), Member = "CreateFastSpline")]
		[CalledBy(Type = typeof(SplineManager), Member = "RegisterStaticSplineAudioClip")]
		[Calls(Type = typeof(LengthData), Member = "Calculate")]
		[Calls(Type = typeof(Utils), Member = "GetValidNodesCount")]
		[Calls(Type = typeof(SplineNode), Member = "get_Position")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SplineNode), Member = "get_Rotation")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
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

	public enum SystemMetrics
	{
		MouseButtonsSwapped = 23
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<GearItem> _003C_003E9__74_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
		[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
		[CallerCount(Count = 0)]
		internal int _003CRemoveBestQualityAmmoForWeapon_003Eb__74_0(GearItem lhs, GearItem rhs)
		{
			return default(int);
		}
	}

	private sealed class _003CWebRequest_003Ed__238 : IEnumerator<object>, IEnumerator, IDisposable
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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 29)]
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
		public _003CWebRequest_003Ed__238(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(_003CWebRequest_003Ed__238), Member = "<>m__Finally1")]
		[CalledBy(Type = typeof(_003CWebRequest_003Ed__238), Member = "MoveNext")]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 19)]
		[Calls(Type = typeof(_003CWebRequest_003Ed__238), Member = "System.IDisposable.Dispose")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[Calls(Type = typeof(Time), Member = "get_time")]
		[Calls(Type = typeof(UnityWebRequest), Member = "Get")]
		[Calls(Type = typeof(Utils), Member = "PreValidatRequest")]
		[Calls(Type = typeof(_003CWebRequest_003Ed__238), Member = "<>m__Finally1")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[Calls(Type = typeof(Time), Member = "get_time")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallerCount(Count = 0)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CalledBy(Type = typeof(_003CWebRequest_003Ed__238), Member = "MoveNext")]
		[CalledBy(Type = typeof(_003CWebRequest_003Ed__238), Member = "System.IDisposable.Dispose")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CWebRequest_003Ed__239 : IDisposable, IEnumerator<object>, IEnumerator
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
			[CallerCount(Count = 29)]
			[DeduplicatedMethod]
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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[DebuggerHidden]
		public _003CWebRequest_003Ed__239(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(_003CWebRequest_003Ed__239), Member = "<>m__Finally1")]
		[CalledBy(Type = typeof(_003CWebRequest_003Ed__239), Member = "MoveNext")]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallsUnknownMethods(Count = 26)]
		[Calls(Type = typeof(_003CWebRequest_003Ed__239), Member = "System.IDisposable.Dispose")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[Calls(Type = typeof(Time), Member = "get_time")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetupPost")]
		[Calls(Type = typeof(UnityWebRequest), Member = ".ctor")]
		[Calls(Type = typeof(Utils), Member = "PreValidatRequest")]
		[Calls(Type = typeof(_003CWebRequest_003Ed__239), Member = "<>m__Finally1")]
		[Calls(Type = typeof(Time), Member = "get_time")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone")]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(_003CWebRequest_003Ed__239), Member = "System.IDisposable.Dispose")]
		[CalledBy(Type = typeof(_003CWebRequest_003Ed__239), Member = "MoveNext")]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private sealed class _003CWebRequestPut_003Ed__240 : IEnumerator<object>, IEnumerator, IDisposable
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
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CWebRequestPut_003Ed__240(int _003C_003E1__state)
		{
		}

		[CalledBy(Type = typeof(_003CWebRequestPut_003Ed__240), Member = "MoveNext")]
		[Calls(Type = typeof(_003CWebRequestPut_003Ed__240), Member = "<>m__Finally1")]
		[DebuggerHidden]
		[CallerCount(Count = 1)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(_003CWebRequestPut_003Ed__240), Member = "System.IDisposable.Dispose")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 6)]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_error")]
		[Calls(Type = typeof(UnityWebRequest), Member = "get_isDone")]
		[Calls(Type = typeof(Time), Member = "get_time")]
		[Calls(Type = typeof(_003CWebRequestPut_003Ed__240), Member = "<>m__Finally1")]
		[Calls(Type = typeof(Utils), Member = "PreValidatRequest")]
		[Calls(Type = typeof(UnityWebRequest), Member = "Put")]
		[Calls(Type = typeof(Time), Member = "get_time")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SetRequestHeader")]
		[Calls(Type = typeof(UnityWebRequest), Member = "SendWebRequest")]
		[CallsUnknownMethods(Count = 19)]
		private bool MoveNext()
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(_003CWebRequestPut_003Ed__240), Member = "MoveNext")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(_003CWebRequestPut_003Ed__240), Member = "System.IDisposable.Dispose")]
		[CallerCount(Count = 2)]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public static bool s_AnalyticsInitialized;

	private static AssetBundleRef s_BadgeIconsBundle;

	private static AssetBundleRef s_ClothingUnfoldedTexturesBundle;

	private static AssetBundleRef s_InventoryGridIconsBundle;

	private static AssetBundleRef s_LargeTexturesBundle;

	private static AssetBundleRef s_LoadingBackgroundTexturesBundle;

	private static Dictionary<int, Texture2D> s_TextureCache;

	public static bool s_UseAudioStaticCheck;

	private static Dictionary<string, string> s_CommandLineArgs;

	private static int[] s_SHAIds;

	private static int[] s_SHBIds;

	private static int s_SHCId;

	public const float PI2 = (float)Math.PI * 2f;

	public const float HALFPI = (float)Math.PI / 2f;

	private const int MAX_RAYCAST_HITS = 32;

	private static RaycastHit[] s_RaycastHits;

	private static Stack<string> s_ProfilerSampleStack;

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

	private static JsonConverter[] m_GlobalConverters;

	public const int SUBTITLE_FRAMESPERSECOND = 24;

	public const int WEB_REQUEST_TIMEOUT = 30;

	public const float MENU_MOVEMENT_AFTER_FIFTEEN = 0.02f;

	public const float MENU_MOVEMENT_AFTER_FIVE = 0.1f;

	public const float MENU_MOVEMENT_DELAY = 0.2f;

	public const float MENU_MOVEMENT_FIRSTDELAY = 0.5f;

	public const float DOUBLECLICK_MaxTime = 0.5f;

	public static int m_PhysicalCollisionLayerMask;

	public static int m_WeaponProjectileCollisionLayerMask;

	public static bool m_InspectModeActive;

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

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "Deserialize")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "OnClickToggleAnalytics")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnConfirmPrivacySettings")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	public static void EnableAnalytics(bool enable)
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "SendGameOverAnalyticsEvent")]
	[CalledBy(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[CalledBy(Type = typeof(Utils), Member = "SendQualitySettingsAnalyticsEvent")]
	[CalledBy(Type = typeof(Utils), Member = "SendGameStartAnalyticsEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "SendDailyAnalyticsEvent")]
	[Calls(Type = typeof(Analytics), Member = "get_enabled")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	public static bool AreAnalyticsEnabled()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "DoEndOfDayAnalytics")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Utils), Member = "AreAnalyticsEnabled")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	public static void SendDailyAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CalledBy(Type = typeof(FreezingBuff), Member = "Apply")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkMissionComplete")]
	[CalledBy(Type = typeof(WellFed), Member = "WellFedStart")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddMission")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "AddObjective")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CalledBy(Type = typeof(AchievementManager), Member = "UnlockAchievement")]
	[CalledBy(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BreakStruggle")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(FatigueBuff), Member = "Apply")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "MarkObjectiveComplete")]
	[CalledBy(Type = typeof(ConditionRestBuff), Member = "Apply")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(Log), Member = "AddAffliction")]
	[CalledBy(Type = typeof(Weather), Member = "UpdateAndMaybeSendAnalytics")]
	[CalledBy(Type = typeof(EnergyBoost), Member = "ApplyEnergyBoost")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[CalledBy(Type = typeof(EmergencyStim), Member = "ApplyEmergencyStim")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "AreAnalyticsEnabled")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(ConditionOverTimeBuff), Member = "Apply")]
	public static void SendGameplayAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(GameManager), Member = "LaunchSandbox")]
	[CalledBy(Type = typeof(Panel_Story), Member = "OnNewEpisode")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "AddCustomEventData")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(Utils), Member = "AreAnalyticsEnabled")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	public static void SendGameStartAnalyticsEvent(GameRegion region)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "AddCustomEventData")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "AreAnalyticsEnabled")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public static void SendGameOverAnalyticsEvent(GameOverResult gameOverResult)
	{
	}

	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(Utils), Member = "SendGameplayAnalyticsEvent")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(Utils), Member = "SendDailyAnalyticsEvent")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(TimeOfDay), Member = "UpdateAnalytics")]
	[CalledBy(Type = typeof(FeatEnabledTracker), Member = "SendAnalytics")]
	[Calls(Type = typeof(Utils), Member = "SendCustomAnalyticsEvent")]
	[CalledBy(Type = typeof(FeatEnabledTracker), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(CustomExperienceMode), Member = "SendAnalytics")]
	public static void SendCustomAnalyticsEventWithSeed(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(QualitySettingsManager), Member = "GetCurrentQualitySettings")]
	[Calls(Type = typeof(Utils), Member = "AreAnalyticsEnabled")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 1)]
	public static void SendQualitySettingsAnalyticsEvent()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "SendBadgeInfoAnalyticsEvent")]
	[CalledBy(Type = typeof(BadgeUIInfo), Member = "SendBadgeInfoAnalyticsEvent")]
	[CalledBy(Type = typeof(Utils), Member = "SendCustomAnalyticsEventWithSeed")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(AnalyticsEvent), Member = "Custom")]
	[Calls(Type = typeof(Utils), Member = "AreAnalyticsEnabled")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 6)]
	public static void SendCustomAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "Init")]
	[CalledBy(Type = typeof(GameManager), Member = "Awake")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[Calls(Type = typeof(AssetBundleManager), Member = "LoadBundleAsync")]
	[CallerCount(Count = 2)]
	protected static void InitAssetBundles()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "MaybeClearUITextureCache")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public static void ClearUITextureCache()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "MaybeClearUITextureCache")]
	[CalledBy(Type = typeof(InterfaceManager), Member = "Update")]
	[CalledBy(Type = typeof(EmptyScene), Member = "LoadScene")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static bool HasUITextureCache()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "HasUITextureCache")]
	[Calls(Type = typeof(Utils), Member = "ClearUITextureCache")]
	[CallerCount(Count = 0)]
	public static void MaybeClearUITextureCache()
	{
	}

	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "ShowPanel")]
	[CalledBy(Type = typeof(Panel_PauseMenu), Member = "UpdateSelectedFeats")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateSelectedFeats")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "SetupFeatScrollList")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupFeatScrollList")]
	[CalledBy(Type = typeof(FeatNotify), Member = "ShowFeatUnlockedKicker")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_Badges), Member = "SetupChallengeScrollList")]
	public static Texture2D GetBadgeIcon(string name)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[CalledBy(Type = typeof(Utils), Member = "GetGearCoverflowDamageTexture")]
	[CalledBy(Type = typeof(Utils), Member = "GetGearCoverflowBlendTexture")]
	[CallsUnknownMethods(Count = 8)]
	public static Texture2D GetClothingUnfoldedTexture(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(Utils), Member = "CacheTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 31)]
	public static Texture2D GetInventoryGridIconTexture(string name)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectChallengeType), Member = "OnSelectionUpdate")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	public static Texture2D GetChallengeTexture(ExperienceModeType xpMode, bool ignoreLocked = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UILargeTexture), Member = "OnEnable")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetTOCTextureFromRegion")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateTOCSelection")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateMissionsPage")]
	public static Texture2D GetLargeTexture(string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Loading), Member = "SetBackgroundData")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static Texture2D GetLoadingBackgroundTexture(string name)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[CallsUnknownMethods(Count = 3)]
	private static void CacheTexture(string name, Texture2D texture)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static Texture2D GetCachedTexture(string name)
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "IsChildOfDynamicObj")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RenderObjectInstance), Member = "IsRenderObjectInstanceChild")]
	[CallsUnknownMethods(Count = 2)]
	public static bool CheckIfAkGameObjIsStatic(AkGameObj akGameObj)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Utils), Member = "IsChildOfDynamicObj")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	private static bool IsDynamicObj(GameObject obj)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsDynamicObj")]
	[CalledBy(Type = typeof(Utils), Member = "CheckIfAkGameObjIsStatic")]
	[CalledBy(Type = typeof(AkGameObj), Member = "Awake")]
	[CallsUnknownMethods(Count = 6)]
	private static bool IsChildOfDynamicObj(AkGameObj obj)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyCommandLineParameters")]
	[CalledBy(Type = typeof(InputSystemRewired), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "Update")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "ShouldReplacePathEntry")]
	[Calls(Type = typeof(Utils), Member = "SanitizeCommandLineArgName")]
	[Calls(Type = typeof(Utils), Member = "EnsureCommandLineArgsAreLoaded")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "PlayIntroMovie")]
	public static bool IsCommandLineArgumentPresent(string arg)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(Utils), Member = "SanitizeCommandLineArgName")]
	[Calls(Type = typeof(Utils), Member = "EnsureCommandLineArgsAreLoaded")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateLoadingSave")]
	public static bool GetCommandLineValue(string arg, out string value)
	{
		value = null;
		return default(bool);
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool GetCommandLineValue(string arg, out int value)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref value) = null;
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetCommandLineValue")]
	public static bool GetCommandLineValue<TEnum>(string arg, out TEnum value) where TEnum : struct
	{
		System.Runtime.CompilerServices.Unsafe.As<TEnum, @null>(ref value) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(GameManager), Member = "LoadMainMenu")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GameManager), Member = "RelaunchBuildToLoadSave")]
	[CalledBy(Type = typeof(GameManager), Member = "RelaunchBuildForMainMenu")]
	[Calls(Type = typeof(ExternalProcess), Member = "RunCommand")]
	[Calls(Type = typeof(ProcessStartInfo), Member = "get_WorkingDirectory")]
	[Calls(Type = typeof(Process), Member = "get_StartInfo")]
	[Calls(Type = typeof(Process), Member = "GetCurrentProcess")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static void QuitAndRunApplication(string applicationPath, string commandArguments)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(InvalidEnumArgumentException), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Process), Member = "set_StartInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Enum), Member = "IsDefined")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Process), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	private static Process GetProcessForExecuteCmd(string commandArguments, string workingPath, ExecuteCmdOptions options)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Utils), Member = "ParseCommandLineArgs")]
	[CallsUnknownMethods(Count = 4)]
	public static void OverrideCommandLineWithTestArgs(string testCommandLine)
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CalledBy(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "ParseCommandLineArgs")]
	private static void EnsureCommandLineArgsAreLoaded()
	{
	}

	[CalledBy(Type = typeof(Utils), Member = "ParseCommandLineArgs")]
	[CalledBy(Type = typeof(Utils), Member = "GetCommandLineValue")]
	[CalledBy(Type = typeof(Utils), Member = "IsCommandLineArgumentPresent")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static string SanitizeCommandLineArgName(string keyName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Utils), Member = "EnsureCommandLineArgsAreLoaded")]
	[CalledBy(Type = typeof(Utils), Member = "OverrideCommandLineWithTestArgs")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Utils), Member = "SanitizeCommandLineArgName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	private static Dictionary<string, string> ParseCommandLineArgs(string[] args)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Log), Member = "UncacheSandboxRecord")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public static GearItem InstantiateGearFromPrefabName(string name)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Container), Member = "GetTotalWeightKG")]
	[CalledBy(Type = typeof(Inventory), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	public static float GetTotalWeightKG(List<GearItemObject> items)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Container), Member = "ContainsFoodItems")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool ContainsFoodItems(List<GearItemObject> items)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static GearItem GetHighestConditionGearThatMatchesName(List<GearItemObject> items, string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "GetLowestConditionGearThatMatchesName")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	public static GearItem GetLowestConditionGearThatMatchesName(List<GearItemObject> items, string name)
	{
		return null;
	}

	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesCanOpeningType")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static GearItem GetHighestConditionGearThatMatchesCanOpeningType(List<GearItemObject> items, CanOpeningItem.CanOpeningType type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static WaterSupply GetWaterSupply(List<GearItemObject> items, LiquidQuality quality)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "GearInInventoryAtCondition")]
	[CalledBy(Type = typeof(Inventory), Member = "TryStackingItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static GearItem GearInInventoryAtCondition(List<GearItemObject> items, string gearName, int numUnits, int conditionInPercent)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "GearInInventory")]
	[CalledBy(Type = typeof(Panel_Milling), Member = "HasEnoughMaterials")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GearItem GearInInventory(List<GearItemObject> items, string gearName, int numUnits)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "HasNonRuinedItem")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Inventory), Member = "GetNonRuinedItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static GearItem GetNonRuinedItem(List<GearItemObject> items, string gearName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static GearItem[] GearInList(List<GearItemObject> items, string gearName)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "GetNumMatches")]
	[CalledBy(Type = typeof(EquipItemPopup), Member = "UpdateAmmoStatus")]
	[CalledBy(Type = typeof(Utils), Member = "NumGearInListForScripting")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static int GetNumMatches(List<GearItemObject> items)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Utils), Member = "NumGearInListForScripting")]
	[CalledBy(Type = typeof(Utils), Member = "NumGearInListForScripting")]
	[CalledBy(Type = typeof(Utils), Member = "NumGearInListForScripting")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNumFlares")]
	[CalledBy(Type = typeof(Utils), Member = "NumGearInListForScripting")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static int GetNumFlares(List<GearItemObject> items, FlareType type)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	public static int GetNumTorches(List<GearItemObject> items)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNumStones")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	public static int GetNumStones(List<GearItemObject> items)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	public static int GetNumNoiseMakers(List<GearItemObject> items)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetMeasurableTotalByTypeInList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static float GetWaterAmount(List<GearItemObject> items, bool includeNonPotable, bool includePotable)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Utils), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(Utils), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(Utils), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(Utils), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(Utils), Member = "GetMeasurableTotalByTypeInList")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static float GetMeatAmount(List<GearItemObject> items, bool includeFish, bool includeRawFish, bool includeMeat, bool includeRawMeat, bool includeMeatType, GearMeatTypeEnum meatType)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetMeasurableTotalByTypeInList")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Utils), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(Utils), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(Condition_CheckContainerLiquid), Member = "OnCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static float GetLiquidItemAmount(List<GearItemObject> items, GearLiquidTypeEnum type)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static float GetPowderItemAmount(List<GearItemObject> items, GearPowderType type)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Utils), Member = "NumGearInListForScripting")]
	[CalledBy(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[CalledBy(Type = typeof(Container), Member = "GetNumGearWithName")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static int NumGearInList(List<GearItemObject> items, string gearName)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Action_GetInvItemCount), Member = "OnExecute")]
	[CalledBy(Type = typeof(Inventory), Member = "GetNumGearWithName")]
	[Calls(Type = typeof(Utils), Member = "GetNumMatches")]
	[Calls(Type = typeof(Utils), Member = "GetNumFlares")]
	[Calls(Type = typeof(Utils), Member = "GetNumFlares")]
	[Calls(Type = typeof(Utils), Member = "GetNumFlares")]
	[Calls(Type = typeof(Utils), Member = "GetNumFlares")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Utils), Member = "NumGearInList")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	public static int NumGearInListForScripting(List<GearItemObject> items, string gearName)
	{
		return default(int);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetMeatAmount")]
	[Calls(Type = typeof(Utils), Member = "GetMeatAmount")]
	[Calls(Type = typeof(Utils), Member = "GetMeatAmount")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Utils), Member = "GetMeatAmount")]
	[Calls(Type = typeof(Utils), Member = "GetMeatAmount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetWaterAmount")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Container), Member = "GetMeasurableTotalByType")]
	[CalledBy(Type = typeof(Inventory), Member = "GetMeasurableTotalByType")]
	[CalledBy(Type = typeof(Action_GetContainerItemCount), Member = "DoContainerCheck")]
	[CalledBy(Type = typeof(Action_GetInvItemCount), Member = "OnExecute")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidItemAmount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidItemAmount")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidItemAmount")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	public static int GetMeasurableTotalByTypeInList(List<GearItemObject> items, string type)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Inventory), Member = "GetAmmoAvailableForGunType")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Container), Member = "GetAmmoCountForGunType")]
	[CalledBy(Type = typeof(Inventory), Member = "GetAmmoAvailableForWeapon")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	public static int GetAmmoAvailableForWeapon(List<GearItemObject> items, GunType gunType)
	{
		return default(int);
	}

	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveAmmoForWeaponSingle")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnBulletLoaded")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static int RemoveBestQualityAmmoForWeaponSingle(IEnumerable<GearItemObject> items, GunType gunType)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 49)]
	[CalledBy(Type = typeof(Inventory), Member = "RemoveAmmoForWeapon")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_FPSShooter), Member = "OnClipLoaded")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	public static List<int> RemoveBestQualityAmmoForWeapon(IEnumerable<GearItemObject> items, GunType gunType, int ammoNeeded)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestMatches")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public static GearItem GetBestMatches(List<GearItemObject> items)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestMatches")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public static GearItem GetBestMatches(List<GearItemObject> items, MatchesType matchesType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFlare")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static GearItem GetBestFlare(List<GearItemObject> items, FlareType type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFlashlight")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public static GearItem GetBestFlashlight(List<GearItemObject> items)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestTorch")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GearItem GetBestTorch(List<GearItemObject> items)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	public static GearItem GetBestBed(List<GearItemObject> items)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestLamp")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteLightSourceAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public static GearItem GetBestLamp(List<GearItemObject> items)
	{
		return null;
	}

	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestRevolver")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static GearItem GetBestRevolver(List<GearItemObject> items)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestRifle")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public static GearItem GetBestRifle(List<GearItemObject> items)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestBearSpear")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	public static GearItem GetBestBearSpear(List<GearItemObject> items)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "GetBestFlareGun")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static GearItem GetBestFlareGun(List<GearItemObject> items)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestStone")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public static GearItem GetBestStone(List<GearItemObject> items)
	{
		return null;
	}

	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestNoiseMakerItem")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static GearItem GetBestNoiseMaker(List<GearItemObject> items)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestBow")]
	[CalledBy(Type = typeof(InputManager), Member = "ExecuteFirearmAction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GearItem GetBestBow(List<GearItemObject> items)
	{
		return null;
	}

	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestDecoy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Scent), Member = "GetRange")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Scent), Member = "GetRange")]
	public static GearItem GetBestDecoy(List<GearItemObject> items)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFishingTackle")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "OnClick")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public static GearItem GetBestFishingTackle(List<GearItemObject> items)
	{
		return null;
	}

	[CalledBy(Type = typeof(Inventory), Member = "GetBestFishingHook")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GearItem GetBestFishingHook(List<GearItemObject> items)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestFishingLine")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GearItem GetBestFishingLine(List<GearItemObject> items)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestRopeItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public static GearItem GetBestRopeItem(List<GearItemObject> items)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "WeaponPickerBegin")]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestStuggleBonusItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GearItem GetBestStruggleBonusItem(List<GearItemObject> items)
	{
		return null;
	}

	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CalledBy(Type = typeof(Inventory), Member = "GetLowestConditionArrow")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GearItem GetLowestConditionArrow(List<GearItemObject> items)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "HasRawMeat")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static bool HasRawMeat(List<GearItemObject> items)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "GetBestGearItemWithName")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_use_best_gearitem")]
	[CalledBy(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SanitizePrefabName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static GearItem GetBestGearItemWithName(List<GearItemObject> items, string name)
	{
		return null;
	}

	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(LitItemExtinguisher), Member = "OnCollisionStay")]
	[CalledBy(Type = typeof(LitItemExtinguisher), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GearItem), Member = "IsLitNoiseMaker")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	public static void ExtinguishLitItem(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(EnableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(EnableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[CalledBy(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(DisableObjectForXPMode), Member = "ShouldDisableForCurrentMode")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool IsGunOrAmmoOrCasingOfType(GameObject go, GunType gunType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshBlueprints")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool IsBirchBarkTea(GearItem gi)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static List<BlueprintItem> FindBlueprintsForGear(GearItem gearItem)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Action_UnlockBlueprint), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_blueprint_unlock")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "MarkBlueprintUnlocked")]
	[Calls(Type = typeof(string), Member = "CompareOrdinalIgnoreCaseHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextInfo), Member = "CompareOrdinalIgnoreCase")]
	public static List<BlueprintItem> FindBlueprintsForGear(string gearName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
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
	[Calls(Type = typeof(SphericalHarmonicsL2), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 5)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 24)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float XZDistance(Vector3 a, Vector3 b)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float XZMagnitude(Vector3 vec)
	{
		return default(float);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 146)]
	public static bool Approximately(float a, float b, float epsilon = 0.0001f)
	{
		return default(bool);
	}

	[CallerCount(Count = 519)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsZero(float a, float epsilon = 0.0001f)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool Approximately(double a, double b, double epsilon = 0.0001)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool IsZero(double a, double epsilon = 0.0001)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public static Vector3 GetDirectionVector(Vector3 from, Vector3 to)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTargetHeadingParameter")]
	[CalledBy(Type = typeof(Utils), Member = "GetAngleDegrees")]
	[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
	public static float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Action_FaceTarget), Member = "GetTurnSpeed")]
	[CalledBy(Type = typeof(Wind), Member = "GetWindAngleRelativeToPlayer")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BaseAi), Member = "SetTurnSpeedAnimationParameter")]
	[CalledBy(Type = typeof(Action_FaceTarget), Member = "OnUpdate")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Utils), Member = "AngleDir")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeFleeOnSlope")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "SetPlayerInclineRTPC")]
	public static float CalculateSlopeUnderPosition(Vector3 pos)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Utils), Member = "CalculateSlopeUnderPosition")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	public static float CalculateSlopeUnderPosition(Vector3 pos, int ignoreMask)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "StickBodyToGroundAtPlayersFeet")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "UpdatePlayerTransformForHunted2Dragging")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CalledBy(Type = typeof(Inventory), Member = "PositionAndRotateScatteredItem")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(CarcassSite), Member = "StickToGroundAndOrientOnSlope")]
	public static Quaternion GetOrientationOnSlope(Transform t, Vector3 groundNormal)
	{
		return default(Quaternion);
	}

	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[CalledBy(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[CallsUnknownMethods(Count = 85)]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_Item")]
	public static bool TestOBBOBB(OBB a, OBB b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(BoxCollider), Member = "get_size")]
	[CallsUnknownMethods(Count = 94)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "Overlaps")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithInteractiveProp")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsLeanTo")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsSnowShelter")]
	[Calls(Type = typeof(Utils), Member = "TestOBBOBB")]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale")]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale")]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale")]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BoxCollider), Member = "get_center")]
	public static bool OrientedBoundingBoxesOverlap(GameObject a, GameObject b)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "BeginClimbing")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector3 NearestPointInfinite(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(SnowDepthCapsuleRecord), Member = "GetDepthFracAtPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Magnitude")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector3 NearestPoint(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowFrustum")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowFrustum")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector3 Plane3Intersect(Plane p1, Plane p2, Plane p3)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CalledBy(Type = typeof(Condition_VisibilityTest), Member = "OnCheck")]
	public static bool SphereIntersectsCone(Vector3 sphereCentre, float sphereRadius, Vector3 conePoint, Vector3 coneUnitAxis, float coneAngle)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float Berp(float start, float end, float value)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float Bounce(float x, int num = 8)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float Impulse(float t, float span)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float CubicPulse(float t, float centre, float falloffDist)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SnowPlaneParticles), Member = "LateUpdate")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "HandleSlipStage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static float ExpStep(float t, float exp, float pow)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static float Parabola(float t, float pow)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static float PowCurve(float t, float scale, float powA, float powB)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static float SmoothMinExp(float a, float b, float k)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float SmoothMinPoly(float a, float b, float k)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	public static float ExpFilterWeight(float deltaTime, float timeConstant)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateLowHealthStagger")]
	[CalledBy(Type = typeof(PlayerStunned), Member = "UpdateLowHealthStagger")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetPositionOnRope")]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "GetAdjustedViewAngles")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Wind), Member = "RefreshSettings")]
	[CalledBy(Type = typeof(Condition), Member = "ApplyLowHealthStagger")]
	[CalledBy(Type = typeof(Condition), Member = "ApplyLowHealthStagger")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	public static float ExpStep(float prevFilt, float next, float deltaTime, float timeConstant)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float ExpStep(float prevFilt, float next, float deltaTime, float timeConstant, float maxVel)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	public static float ExpStepAngle(float prevFilt, float next, float deltaTime, float timeConstant)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "Lerp")]
	[CallerCount(Count = 0)]
	public static Vector2 ExpStep(Vector2 prevFilt, Vector2 next, float deltaTime, float timeConstant)
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(Vector2), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector2), Member = "Normalize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector2 ExpStep(Vector2 prevFilt, Vector2 next, float deltaTime, float timeConstant, float maxVel)
	{
		return default(Vector2);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallerCount(Count = 0)]
	public static Vector3 ExpStep(Vector3 prevFilt, Vector3 next, float deltaTime, float timeConstant)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public static Vector3 ExpStep(Vector3 prevFilt, Vector3 next, float deltaTime, float timeConstant, float maxVel)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerClimbRope), Member = "UpdatePosition")]
	[CallsUnknownMethods(Count = 1)]
	public static Quaternion ExpStep(Quaternion prevFilt, Quaternion next, float deltaTime, float timeConstant)
	{
		return default(Quaternion);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
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
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightAtPosition")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
	[CalledBy(Type = typeof(DebugUtils), Member = "ShowHermitePatch")]
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
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Utils), Member = "GetPatchHeightTangentAtPosition")]
	public static float CalcHermiteTangent(float p0, float m0, float p1, float m1, float t)
	{
		return default(float);
	}

	[Calls(Type = typeof(UnityEngine.Random), Member = "get_insideUnitCircle")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(Utils), Member = "ComputeSqrDistanceToNearest")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector2 GeneratePoissonSample(List<Vector2> samples, int maxCandidates)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CalledBy(Type = typeof(Utils), Member = "GeneratePoissonSample")]
	[CallsUnknownMethods(Count = 7)]
	public static float ComputeSqrDistanceToNearest(List<Vector2> samples, Vector2 candidate)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Map), Member = "DoNearbyDetailsCheck")]
	public static float DistanceSqr(Vector2 a, Vector2 b)
	{
		return default(float);
	}

	[CallerCount(Count = 67)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static float DistanceSqr(Vector3 a, Vector3 b)
	{
		return default(float);
	}

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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeAddToLostAndFound")]
	[Calls(Type = typeof(Utils), Member = "TestAabbAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "TestAabbAxis")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "TestAabbAxis")]
	public static bool AabbOverlap(Bounds a, Bounds b, out Vector3 axis, out float distance)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref axis) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref distance) = null;
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(Utils), Member = "AabbOverlap")]
	[CalledBy(Type = typeof(Utils), Member = "AabbOverlap")]
	[CalledBy(Type = typeof(Utils), Member = "AabbOverlap")]
	public static bool TestAabbAxis(Vector3 axis, Bounds a, Bounds b, ref Vector3 minimumTranslationAxis, ref float minimumTranslationDistanceSqr)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SpotLightController), Member = "UpdateTarget")]
	[CalledBy(Type = typeof(BipedMoveAgent), Member = "MoveToWeight")]
	[Calls(Type = typeof(Mathf), Member = "MoveTowards")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	public static float MoveToValue(float currentValue, float desiredValue, float speed)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Action_MissionMarkComplete), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateTexture), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateDesc), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionUpdateTimer), Member = "get_info")]
	[CalledBy(Type = typeof(Action_MissionAddNew), Member = "get_info")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Action_MissionUpdateName), Member = "get_info")]
	public static bool MissionIDExists(string missionID)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Condition_ObjectiveCompleted), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveCompleteMain), Member = "get_info")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Action_ObjectiveUpdateTimer), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveUpdateDesc), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "get_info")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(Transform), Member = "get_childCount")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	public static bool ObjectiveIDExists(string objectiveID)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Action_RevealMapLocation), Member = "get_info")]
	[CalledBy(Type = typeof(Action_RemoveMissionMarkerFromMap), Member = "get_info")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "get_info")]
	[CallerCount(Count = 3)]
	public static bool MissionMapMarkerIDExists(string markerID)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[Calls(Type = typeof(GameManager), Member = "IsStoryMode")]
	[CalledBy(Type = typeof(Lock), Member = "Start")]
	[CalledBy(Type = typeof(Container), Member = "PopulateWithScriptedGear")]
	[CallsUnknownMethods(Count = 7)]
	public static bool PassesGameModeFilter(GameModeFilter mode)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(Elevator), Member = "GetInteractedDoor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static bool RaycastNearest(Vector3 origin, Vector3 direction, out RaycastHit hit, float maxDistance, int layerMask)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hit) = null;
		return default(bool);
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void ProfilerStart(string sampleName)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void ProfilerEnd(string sampleName)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void ProfilerNext(string sampleName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixelBilinear")]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel")]
	[Calls(Type = typeof(Texture2D), Member = "Apply")]
	[CallsUnknownMethods(Count = 10)]
	public static Texture2D GetBilinearScaledTexture(Texture2D source, int targetWidth, int targetHeight)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventHide")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(CinematicAssets), Member = "LoadTransientProp")]
	public static void DisableRenderers(GameObject parent)
	{
	}

	[CalledBy(Type = typeof(AnimationEvents), Member = "DoEnableObject")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventShow")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Renderer), Member = "set_enabled")]
	public static void EnableRenderers(GameObject parent)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetAmbientLightScaled")]
	[CalledBy(Type = typeof(TodAmbientLight), Member = "SetAmbientLightValue")]
	[CalledBy(Type = typeof(UniStormWeatherSystem), Member = "Update")]
	public static void SetAmbientLight(Color ambientColor)
	{
	}

	[Calls(Type = typeof(Color), Member = "get_linear")]
	[CalledBy(Type = typeof(Utils), Member = "SetAmbientLight")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(RenderSettings), Member = "get_ambientProbe")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	public static void SetAmbientLightScaled(Color ambientColor, float probeScalar)
	{
	}

	[Calls(Type = typeof(Graphics), Member = "SetRenderTarget")]
	[Calls(Type = typeof(Material), Member = "set_color")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 24)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static void ClearWithFullScreenQuad(RenderTexture target, Color clearColor)
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsUnknownMethods(Count = 30)]
	[CalledBy(Type = typeof(SnowPatch), Member = "Initialize")]
	[CalledBy(Type = typeof(SnowImprintCustom), Member = "Reposition")]
	[Calls(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[Calls(Type = typeof(Utils), Member = "RaycastForTag")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[CalledBy(Type = typeof(SnowPatch), Member = "GeneratePatchCoefficients")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "RaycastForTag")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	public static void GeneratePatchCoefficients(Transform transform, Vector3 minPos, Vector3 maxPos, string tag, ref Vector3[] hermiteCoefficients, out Vector3 heightInfo)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref heightInfo) = null;
	}

	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[CalledBy(Type = typeof(SnowPatch), Member = "GetPatchHeightAtPosition")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 52)]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	public static float GetPatchHeightAtPosition(Vector3 p, Vector3[] hermiteCoefficients)
	{
		return default(float);
	}

	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 52)]
	[CalledBy(Type = typeof(SnowPatch), Member = "GetPatchHeightTangentAtPosition")]
	[CalledBy(Type = typeof(SnowPatch), Member = "AddImprint")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[Calls(Type = typeof(Utils), Member = "CalcHermiteTangent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public static float GetPatchHeightTangentAtPosition(Vector3 p, Vector3[] hermiteCoefficients)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Utils), Member = "GenerateGridMeshQuadrantSet")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "Start")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public static Mesh BuildGridMeshXZ(Vector2 dims, int vertsX, int vertsY, float uvMin = 0f, float uvMax = 1f)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "BuildGridMeshXZ")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Utils), Member = "BuildMeshForGridQuadrantSubset")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 18)]
	public static Mesh[] GenerateGridMeshQuadrantSet(Vector3 dims, int edgeVerts, int textureRes, float boundsYSize)
	{
		return null;
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_shadows")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_enable_shadows")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyShadows")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Debug), Member = "ApplyShadows")]
	public static void EnableShadows(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 161)]
	[CalledBy(Type = typeof(Utils), Member = "GenerateGridMeshQuadrantSet")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(KeyNotFoundException), Member = ".ctor")]
	[Calls(Type = typeof(Mesh), Member = "set_triangles")]
	[Calls(Type = typeof(Mesh), Member = "set_uv")]
	[Calls(Type = typeof(Mesh), Member = "set_vertices")]
	[Calls(Type = typeof(Mesh), Member = ".ctor")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Mesh), Member = "get_uv")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Mesh), Member = "get_triangles")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mesh), Member = "get_triangles")]
	private static Mesh BuildMeshForGridQuadrantSubset(int mask, Mesh refMesh, float minUV)
	{
		return null;
	}

	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CalledBy(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Component), Member = "CompareTag")]
	private static bool RaycastForTag(string tag, Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		System.Runtime.CompilerServices.Unsafe.As<RaycastHit, @null>(ref hitInfo) = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[Calls(Type = typeof(Utils), Member = "CheckHeightAgainstCoords")]
	[CalledBy(Type = typeof(Utils), Member = "GeneratePatchCoefficients")]
	[CallsUnknownMethods(Count = 23)]
	private static void ClampPatchCoefficients(float centerY, float maxDelta)
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Utils), Member = "ClampPatchCoefficients")]
	private static float CheckHeightAgainstCoords(float py, float maxDelta, int x, int z)
	{
		return default(float);
	}

	[CallerCount(Count = 341)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FastJson), Member = "Serialize")]
	public static string SerializeObject(object obj)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 422)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static T DeserializeObject<T>(string text, ParseErrorLevel parseErrorLevel = ParseErrorLevel.Error)
	{
		return (T)null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FastSpline), Member = "Allocate")]
	[CallsUnknownMethods(Count = 1)]
	public static FastSpline CreateFastSpline(Spline spline, NativeArray<double> matrix)
	{
		return default(FastSpline);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SplineManager.FastSplineJob), Member = "Execute")]
	[Calls(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
	public static float GetClosestPointParamOnSpline(Vector3 position, ref FastSpline spline)
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetPositionOnSpline")]
	[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSpline")]
	[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSpline")]
	private static float GetClosestPointParamOnSegmentIntern(Vector3 point, float start, float end, float step, ref FastSpline spline)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Utils), Member = "GetClosestPointParamOnSegmentIntern")]
	[CalledBy(Type = typeof(SplineManager.FastSplineJob), Member = "Execute")]
	[Calls(Type = typeof(FastSpline), Member = "GetPositionInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "RecalculateParameter")]
	public static Vector3 GetPositionOnSpline(ref FastSpline spline, float param)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(FastSpline), Member = "Allocate")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SplineAudioClip), Member = "Awake")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static int GetValidNodesCount(Spline spline)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Utils), Member = "GetPositionOnSpline")]
	private static SegmentParameter RecalculateParameter(double param, ref FastSpline spline)
	{
		return default(SegmentParameter);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	public static uint ParseSubtitles(string filename, ref Subtitle[] subtitles)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(MoviePlayer), Member = "PlayMovieFromFullPath")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	public static uint ParseSubtitles(string filename, ref Subtitle[] subtitles, ref long frameRate)
	{
		return default(uint);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "OnCinematicPlay")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "EventDisplaySubtitles")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "LoadCinematicAsync")]
	public static uint ParseSubtitles(TextAsset asset, ref Subtitle[] subtitles)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringReader), Member = ".ctor")]
	public static uint ParseSubtitles(TextAsset asset, ref Subtitle[] subtitles, ref long frameRate)
	{
		return default(uint);
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[CalledBy(Type = typeof(Utils), Member = "ParseSubtitles")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.Number), Member = "TryParseUInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(System.Number), Member = "TryParseUInt32")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt64")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static uint ParseSubtitles(TextReader reader, ref Subtitle[] subtitles, ref long frameRate, string errorName)
	{
		return default(uint);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public static uint GetNextEndOrStartFrame(uint frame, Subtitle[] subtitles, uint numSubtitles)
	{
		return default(uint);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CalledBy(Type = typeof(MoviePlayer), Member = "UpdatePlayback")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[Calls(Type = typeof(Panel_Subtitles), Member = "ShowSubtitles")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Subtitles), Member = "HideSubtitles")]
	public static void UpdateSubtitles(uint frame, Subtitle[] subtitles, uint numSubtitles)
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "GetDebugDialogueText")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "DoUpdate")]
	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(Utils), Member = "GetNextSkipTime")]
	public static uint GetSubtitleFrame(float currentTimeSeconds, long frameRate = 24L)
	{
		return default(uint);
	}

	[CalledBy(Type = typeof(CinematicTrack), Member = "UpdatePlaying")]
	[CalledBy(Type = typeof(DialogueModeRigFP), Member = "Update_DialogueModeStatePlayCinematic")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetSubtitleFrame")]
	[CallerCount(Count = 2)]
	public static float GetNextSkipTime(float currentTimeSeconds, Subtitle[] subtitles, uint numSubtitles, long frameRate = 24L)
	{
		return default(float);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CalledBy(Type = typeof(Panel_ChallengeComplete), Member = "AddSavesOfTypeToMenu")]
	[CalledBy(Type = typeof(Panel_ChooseStory), Member = "AddSavesOfTypeToMenu")]
	public static string GetTimeSinceText(TimeSpan timeSince)
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_ForceCustomLoadScreen), Member = "get_info")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_QueueLoadScreenHint), Member = "get_info")]
	[CalledBy(Type = typeof(Action_ForceCustomLoadScreen), Member = "get_info")]
	[CalledBy(Type = typeof(Action_QueueLoadScreenHint), Member = "get_info")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Action_QueueLoadScreenHint), Member = "get_info")]
	public static string LocKeyPreview(string myKey, bool stripLineBreaks, int clampLength)
	{
		return null;
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(TLD_SetControllerStateTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_SayTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_AudioTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_AnimationTrack), Member = "DoDynamicBinding")]
	[CalledBy(Type = typeof(TLD_ActivationTrack), Member = "DoDynamicBinding")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(TLD_TimelineDirector), Member = "GetGameObjectOverride")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
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

	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.EnumerateFilesOperation), Member = "WebRequestEnumerateFiles")]
	[CalledBy(Type = typeof(WebUtils), Member = "DownloadData")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "SetBackground")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "RetrieveNotificationsFromServer")]
	public static IEnumerator WebRequest(string url, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.UploadOperation), Member = "WebRequestBeginUploadData")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.DeleteOperation), Member = "WebRequestDeleteData")]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.UploadOperation), Member = "WebRequestCommitUpload")]
	[CallerCount(Count = 3)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static IEnumerator WebRequest(string url, WWWForm form, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(WebUtils.SteamCloudManager.UploadOperation), Member = "WebRequestUploadData")]
	[CallsUnknownMethods(Count = 7)]
	public static IEnumerator WebRequestPut(string url, byte[] data, Dictionary<string, string> httpHeaders, Action<UnityWebRequest> onSuccess, Action<UnityWebRequest> onFailure = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(_003CWebRequest_003Ed__239), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(_003CWebRequest_003Ed__238), Member = "MoveNext")]
	[CalledBy(Type = typeof(_003CWebRequestPut_003Ed__240), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 3)]
	private static bool PreValidatRequest(ref string url)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "InitAssetBundles")]
	[CallerCount(Count = 0)]
	public static void Init()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Guid), Member = "NewGuid")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[CalledBy(Type = typeof(LoadScene), Member = "Start")]
	[CalledBy(Type = typeof(LoadSceneParent), Member = "Start")]
	[CalledBy(Type = typeof(LoadingZone), Member = "Start")]
	[CalledBy(Type = typeof(InputManager), Member = "TakeScreenshot")]
	public static string GetGuid()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "GetValue")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Enum), Member = "GetValues")]
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

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
	[Calls(Type = typeof(Utils), Member = "GetExpandedDurationString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	public static string GetTimeSurvivedString(float time)
	{
		return null;
	}

	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(Campfire), Member = "GetHoverText")]
	[CalledBy(Type = typeof(WoodStove), Member = "GetHoverText")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "RefreshFireDurationLabel")]
	[CalledBy(Type = typeof(Panel_FireStart), Member = "RefreshEstimatedDurationLabel")]
	[CalledBy(Type = typeof(Panel_Map), Member = "RefreshHoverIconText")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "RefreshDescriptionPage")]
	[CalledBy(Type = typeof(Panel_Repair), Member = "RefreshChanceSuccessLabel")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(SpecialEvent), Member = "SetDailyTimerLabel")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(ThreeDaysOfNight), Member = "SetDailyTimerLabel")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateTimerObjectiveUI")]
	[CalledBy(Type = typeof(JumpData), Member = "ToString")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public static string GetDurationString(int durationMinutes)
	{
		return null;
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsUnknownMethods(Count = 82)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static string GetExpandedDurationString(int durationMinutes)
	{
		return null;
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public static string GetDurationStringRounded(int durationMinutes)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PlayableBehaviourChangeTOD), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(PlayableBehaviourChangeTOD), Member = "OnBehaviourPlay")]
	[CalledBy(Type = typeof(StartSettings), Member = "SetLockedTime")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_set_time")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_lighting_preview")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_force_sleep_length")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	public static bool TryParseTOD(string todString, out float normalizedTOD)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref normalizedTOD) = null;
		return default(bool);
	}

	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Utils), Member = "GetCurrentRegion")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "CreateFromSandbox")]
	[CalledBy(Type = typeof(RegionManager), Member = "GetCurrentRegion")]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindStartRegionFromFileData")]
	[CalledBy(Type = typeof(PlayerManager), Member = "FindStartRegion")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetRegionForScene")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForHardcodedLocation")]
	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	public static string GetHardcodedRegionForLocation(string location)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Exists")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CalledBy(Type = typeof(Panel_TutorialPopup), Member = "ShowTutorialPopupRequest")]
	public static string GetTitleString(string locID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Panel_Map), Member = "GetIndexOfCurrentScene")]
	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[CalledBy(Type = typeof(Weather), Member = "MaybeLoadOverrideForIndoors")]
	[CalledBy(Type = typeof(RegionManager), Member = "GetCurrentRegion")]
	[Calls(Type = typeof(LoadScene), Member = "GetSceneToLoad")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Weather), Member = "InitializeWeatherSetsForScene")]
	public static string InferOutdoorSceneName(bool considerForceNextSceneLoadTrigger = false)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "RollRandomNumToSpawn")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	public static string GetFullObjectName(GameObject go)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 50)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GameObject GetChildGameObject(GameObject fromGameObject, string withName, bool includeInactive = false)
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectWithNameContaining")]
	[CalledBy(Type = typeof(Utils), Member = "GetChildGameObjectWithNameContaining")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "FindTransform")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	public static GameObject GetChildGameObjectWithNameContaining(GameObject fromGameObject, string withName, bool includeInactive = false)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObjectByTag")]
	public static GameObject GetChildGameObjectByTag(GameObject fromGameObject, string tag, bool includeInactive = false)
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CalledBy(Type = typeof(Utils), Member = "GetChildGameObject")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static GameObject GetChildGameObject(GameObject fromGameObject, string withName1, string withName2, bool includeInactive = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(KeroseneLampItem), Member = "PlayerSparkParticlesOnSpecific")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "PlayerSparkParticlesOnSpecific")]
	[CalledBy(Type = typeof(KeroseneLampItem), Member = "PlayerSparkParticlesOnSpecific")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetChildGameObject")]
	public static GameObject ForceGetChildGameObject(GameObject fromGameObject, string withName)
	{
		return null;
	}

	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ProcessInspectablePickupItem")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public static bool IsChildOfParent(GameObject child, GameObject parent)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static GameObject FindTopParentWithCollider(GameObject child)
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectUnderCrosshairs")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 6)]
	public static GameObject GetTopParentWithLayer(GameObject child, int childLayer)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[DeduplicatedMethod]
	public static T GetComponentOnSelfOrParent<T>(GameObject obj) where T : UnityEngine.Component
	{
		return null;
	}

	[Calls(Type = typeof(Scene), Member = "GetRootGameObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static List<T> FindObjectsOfTypeInScene<T>(Scene scene, bool includeInactive = false) where T : UnityEngine.Component
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceOverlapsWithObjectsThatBlockPlacement")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CallsUnknownMethods(Count = 4)]
	public static bool AreCollidersActiveAndEnabled(List<Collider> cs)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "LeanToNotOnGroundSnow")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "ObjectToPlaceIsOnBrokenIce")]
	[CalledBy(Type = typeof(PlayerManager), Member = "BedrollOnIce")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SnowShelterNotOnGroundSnow")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "MaybeFallIntoWater")]
	public static Collider GetColliderUnderPosition(Vector3 pos)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Inventory), Member = "PositionAndRotateScatteredItem")]
	[CalledBy(Type = typeof(FootStepSounds), Member = "AddMoveDistance")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnLandFromFall")]
	[CalledBy(Type = typeof(GearItem), Member = "StickToGroundAndOrientOnSlope")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeUpdateStandingOnMaterialTag")]
	[CalledBy(Type = typeof(PlayerManager), Member = "CalculateGhostedMeshValidPosition")]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider")]
	[Calls(Type = typeof(PhysicsScene), Member = "SphereCast")]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "GetMaterialTagForObjectAtPosition")]
	public static string GetMaterialTagUnderPosition(Vector3 pos)
	{
		return null;
	}

	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(Utils), Member = "GetMaterialTagUnderPosition")]
	[CalledBy(Type = typeof(PlayerManager), Member = "DoPositionCheck")]
	[CalledBy(Type = typeof(StoneItem), Member = "OnCollisionEnter")]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(FlareGunRoundItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(ArrowItem), Member = "HandleCollisionWithObject")]
	[CalledBy(Type = typeof(NoiseMakerEffects), Member = "LeaveScorchMark")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(vp_Bullet), Member = "SpawnImpactEffects")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(BreakableIce), Member = "IsIceBroken")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string GetMaterialTagForObjectAtPosition(GameObject obj, Vector3 pos)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(TorchItem), Member = "DisableRendering")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "DisableRendering")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(FlareItem), Member = "DisableRendering")]
	public static void DisableRendering(GameObject go)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(FlareItem), Member = "Update")]
	[CalledBy(Type = typeof(NoiseMakerItem), Member = "Update")]
	[CalledBy(Type = typeof(TorchItem), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 3)]
	public static void EnableRendering(GameObject go)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_save_view")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Utils), Member = "GetFileStream")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static void SaveView(string name)
	{
	}

	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_restore_view")]
	[Calls(Type = typeof(FlyMode), Member = "Warp")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(File), Member = "Exists")]
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

	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityString")]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static float DistanceToMainCamera(Vector3 pos)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowLiquidFractionalStack")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowLiquidFractionalStack")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowLiquid")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Dysentery), Member = "UpdateRemedyItems")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[Calls(Type = typeof(Utils), Member = "GallonsToOunces")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetLiquidQuantityStringWithUnits(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[CalledBy(Type = typeof(Utils), Member = "GetWeightOneDecimalPlaceWithUnitsString")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public static string ToStringOneDigitFloor(float value)
	{
		return null;
	}

	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[CalledBy(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[Calls(Type = typeof(string), Member = "Remove")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CalledBy(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnits")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	public static string ToStringTwoDigitFloor(float value)
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 57)]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	public static string GetLiquidQuantityStringWithUnitsNoOunces(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GallonsToOunces")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	public static string GetLiquidQuantityString(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "RefreshRefuelPanel")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateWaterRemedyUI")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public static string GetLiquidQuantityStringNoOunces(MeasurementUnits units, float liters)
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "OnCook")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnDrinkWaterComplete")]
	public static string GetLiquidQualityString(LiquidQuality quality)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public static string GetFormattedDistance(MeasurementUnits units, float meters)
	{
		return null;
	}

	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateDebugCompass")]
	[CallsUnknownMethods(Count = 1)]
	public static string GetCompassBearingAndDistance(Vector3 start, Vector3 end, out float angle, out float distance)
	{
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref angle) = null;
		System.Runtime.CompilerServices.Unsafe.As<float, @null>(ref distance) = null;
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public static string GetTemperatureString(float temperatureCelsius, bool deltaTemperature, bool roundToNearestDegree, bool showPlusSign)
	{
		return null;
	}

	[CallerCount(Count = 63)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public static bool RollChance(float percent)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "UpdateWeightAndConditionLabels")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "TransferMeatFromCarcassToInventory")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(MissionsProgressBar), Member = "Refresh")]
	[CalledBy(Type = typeof(ContainerMissionHoverText), Member = "GetHoverText")]
	[Calls(Type = typeof(Utils), Member = "ToStringOneDigitFloor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ToStringOneDigitFloor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(MissionObjectiveEntry), Member = "MaybeUpdateCounterUI")]
	public static string GetWeightOneDecimalPlaceWithUnitsString(MeasurementUnits units, float weightKG)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "UpdateSelectedGear")]
	[CalledBy(Type = typeof(Panel_Cooking), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "RefreshSelectedBlueprint")]
	[CalledBy(Type = typeof(GearItem), Member = "GetTextToDisplayWhenSelected")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "HarvestSuccessful")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(StartFireSelectionRow), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateGearItemDescription")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowPowder")]
	[CalledBy(Type = typeof(HarvestRepairMaterial), Member = "ShowPowder")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "ToStringTwoDigitFloor")]
	[CalledBy(Type = typeof(ItemDescriptionPage), Member = "UpdateWeightDisplay")]
	[CallerCount(Count = 16)]
	public static string GetWeightTwoDecimalPlacesWithUnitsString(MeasurementUnits units, float weightKG)
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_SpawnObjectOnPlayer), Member = "MaybeSpawnProp")]
	[CalledBy(Type = typeof(BreakDown), Member = "StickSurfaceObjectsToGround")]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeAddSpawnedPropToInventory")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(UIPopupList), Member = "Show")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(AnimatedInteraction), Member = "MaybeSpawnProp")]
	public static void SetObjectAndChildrenLayer(GameObject go, int layer, int preserveLayer)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(BreakDown), Member = "ProcessRaycastResults")]
	[CallsUnknownMethods(Count = 6)]
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
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CalledBy(Type = typeof(FirstPersonWeapon), Member = "SpawnReloadBulletPrefab")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CalledBy(Type = typeof(Inventory), Member = "HideInventoryItem")]
	[CalledBy(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CookingPotItem), Member = "StartCooking")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InstantiateCopyOfThrownObject")]
	[CalledBy(Type = typeof(BowItem), Member = "OnDequip")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	[CalledBy(Type = typeof(BowItem), Member = "ShootArrow")]
	[CallerCount(Count = 16)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[CalledBy(Type = typeof(BowItem), Member = "MaybeSpawnArrow")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "set_tag")]
	[Calls(Type = typeof(GameObject), Member = "set_tag")]
	[Calls(Type = typeof(GameObject), Member = "set_layer")]
	[Calls(Type = typeof(GameObject), Member = "get_tag")]
	public static void ChangeLayersForGearItem(GameObject gameObject, int newLayer)
	{
	}

	[CalledBy(Type = typeof(SpawnRegion), Member = "RemoveActiveSpawns")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	[CalledBy(Type = typeof(ArrowItem), Member = "LateUpdate")]
	[CalledBy(Type = typeof(SpawnRegion), Member = "SpawnPositionOnScreenTooClose")]
	[CalledBy(Type = typeof(BaseAi), Member = "GetSpeedFromMecanimBone")]
	[CalledBy(Type = typeof(BaseAi), Member = "MaybeImposter")]
	[CalledBy(Type = typeof(BaseAi), Member = "ProcessFlee")]
	[CalledBy(Type = typeof(BearEncounter), Member = "SpawnObjectAttempt")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	public static bool PositionIsOnscreen(Vector3 pos)
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
	[CallsDeduplicatedMethods(Count = 2)]
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
	[Calls(Type = typeof(AiUtils), Member = "PositionVisible")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Utils), Member = "GetPlayerEyePosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public static bool PositionIsInLOSOfPlayer(Vector3 pos)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetCapacityString")]
	[CalledBy(Type = typeof(Encumber), Member = "GetCapacityString")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[CalledBy(Type = typeof(Encumber), Member = "GetCapacityString")]
	[CalledBy(Type = typeof(Panel_SelectExperience), Member = "AddMenuItem")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshStatusLabels")]
	[CalledBy(Type = typeof(CookingPotItem), Member = "GetHoverText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(string), Member = "Concat")]
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
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public static Texture2D GetGearCoverflowTexture(GearItem gi)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetClothingUnfoldedTexture")]
	[CallsUnknownMethods(Count = 1)]
	public static Texture2D GetGearCoverflowDamageTexture(GearItem gi)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetClothingUnfoldedTexture")]
	public static Texture2D GetGearCoverflowBlendTexture(GearItem gi)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static Texture2D GetInventoryIconTexture(GearItem gi)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshCheckmarks")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "UpdateRemedyUI")]
	[CalledBy(Type = typeof(GearMessage), Member = "ShowNextMessageInQueue")]
	[CalledBy(Type = typeof(GearSelectCoverflow), Member = "SetGearItemIcon")]
	[CalledBy(Type = typeof(GearSelectCoverflow), Member = "SetGearItem")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(string), Member = "EndsWith")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(string), Member = "Substring")]
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

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string GetGuidFromGameObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(BodyHarvestManager), Member = "Deserialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "Set")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BaseAiManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "spawn_common")]
	[CalledBy(Type = typeof(RockCache), Member = "Activate")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawnFromSaveData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(SpawnRegion), Member = "InstantiateSpawn")]
	public static void SetGuidForGameObject(GameObject go, string guid)
	{
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public static bool ToolCanCraftItem(ToolsItem ti, BlueprintItem bpi)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Transform), Member = "GetChild")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 61)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 6)]
	public static TType GetComponentInChildren<TType>(GameObject objRoot) where TType : UnityEngine.Component
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Utils), Member = "GetInspectModePivot")]
	[CalledBy(Type = typeof(Utils), Member = "FindChildRecursive")]
	[CalledBy(Type = typeof(Utils), Member = "FindTimelineDynamicBinding")]
	[CalledBy(Type = typeof(PlayableBehaviourSyncTransform), Member = "FindTransform")]
	[CalledBy(Type = typeof(PlayableBehaviourSetFPAnchor), Member = "FindAnchor")]
	[CalledBy(Type = typeof(Panel_SnowShelterInteract), Member = "CameraPan")]
	[CalledBy(Type = typeof(Panel_SnowShelterBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateFeatMarkerSprites")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Panel_LeanToBuild), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "CameraPan")]
	[CalledBy(Type = typeof(Weather), Member = "Start")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "CameraPan")]
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

	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Scene), Member = "GetRootGameObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(TLD_CameraAnimationTrack), Member = "CreateAnimatedCamera")]
	[CallsUnknownMethods(Count = 46)]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Transform), Member = "GetEnumerator")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public static GameObject CreateOrFindGameObjectFromPath(string path, Transform root)
	{
		return null;
	}

	[CalledBy(Type = typeof(Utils), Member = "GetLowestConditionGearThatMatchesName")]
	[CalledBy(Type = typeof(Utils), Member = "GearInInventoryAtCondition")]
	[CalledBy(Type = typeof(Utils), Member = "GearInInventory")]
	[CalledBy(Type = typeof(Utils), Member = "GetNonRuinedItem")]
	[CalledBy(Type = typeof(Utils), Member = "GetBestGearItemWithName")]
	[CalledBy(Type = typeof(Utils), Member = "NumGearInList")]
	[CalledBy(Type = typeof(Utils), Member = "GetMeasurableTotalByTypeInList")]
	[CalledBy(Type = typeof(Utils), Member = "GetHighestConditionGearThatMatchesName")]
	[CalledBy(Type = typeof(Utils), Member = "GearInList")]
	[CalledBy(Type = typeof(GearItemObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(GearItem), Member = "RefreshName")]
	[CalledBy(Type = typeof(BlueprintItemUnlock), Member = "Unlock")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "TrimEnd")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(GearManager), Member = "Deserialize")]
	public static string SanitizePrefabName(string prefabName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(BreakDown), Member = "SpawnYieldObjectsAndStickToGround")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(PhysicsScene), Member = "Raycast")]
	[CalledBy(Type = typeof(BreakDown), Member = "SpawnYieldObjectsAndStickToGround")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_down")]
	public static float StickItemToGroundAtLocation(GameObject go, Vector3 location, float randomRadius = 1f)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Utils), Member = "SaveView")]
	[Calls(Type = typeof(System.IO.__Error), Member = "WinIOError")]
	[Calls(Type = typeof(FileSystemInfo), Member = "set_Attributes")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(FileInfo), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FileSystemInfo), Member = "Refresh")]
	public static StreamWriter GetFileStream(string path)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ApplyFOV")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "ResetGameSettingsToNormal")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraReturnToStart")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashGetupDelayCamera")]
	[CalledBy(Type = typeof(PlayerStruggle), Member = "BashCameraInterpolateToPartner")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "SnapZoom")]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "Start")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "HidePrevious")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Camera), Member = "set_fieldOfView")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "UpdateZoom")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SnapZoom")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "UpdateZoom")]
	public static void SetCameraFOVSafe(Camera cam, float fov)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ShouldIgnoreNavigationInput")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "MaybeFlagMovmentPressedOnEnable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Navigate")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "MaybeFlagMovmentPressedOnEnable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "ShouldIgnoreNavigationInput")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	public static bool GetMovementPressed(MonoBehaviour context, bool useSecondary)
	{
		return default(bool);
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[CallsUnknownMethods(Count = 3)]
	public static float GetMenuMovementHorizontal(MonoBehaviour context, bool useSecondary = true, bool useTimer = true)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationSecondary")]
	[Calls(Type = typeof(InputManager), Member = "GetMenuNavigationPrimary")]
	[CallerCount(Count = 37)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static float GetMenuMovementVertical(MonoBehaviour context, bool useSecondary = true, bool useTimer = true)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "UpdateScrollInput")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MissionsStory), Member = "UpdateGamepadControls")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsStats")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoScrollListScrolLRight")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CalledBy(Type = typeof(Panel_List<, >), Member = "HandleInput")]
	[Calls(Type = typeof(Utils), Member = "AdjustVerticalMoveWithTimer")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "UpdateCollectibleNote")]
	public static float GetMenuMovementVerticalRightStick(MonoBehaviour context, bool useTimer = true, bool useTimerForCameraMouse = false)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Utils), Member = "GetMenuMovementVerticalRightStick")]
	[CallsUnknownMethods(Count = 2)]
	public static float AdjustVerticalMoveWithTimer(float movement)
	{
		return default(float);
	}

	[Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup")]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementGamepad")]
	[CalledBy(Type = typeof(Panel_Log), Member = "DoControlsTrustList")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "IsSteamControllerActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetCameraMovementMouse")]
	public static float GetMenuMovementHorizontalRightStick(MonoBehaviour context, bool useTimer = true)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterLeftPressed")]
	[CallsUnknownMethods(Count = 2)]
	public static bool GetMenuMovementFilterLeft(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryFilterRightPressed")]
	[CallsUnknownMethods(Count = 2)]
	public static bool GetMenuMovementFilterRight(MonoBehaviour context)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool GetMenuMovementAllowed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateMenuMovementDelay()
	{
	}

	[CalledBy(Type = typeof(BootUpdate), Member = "Start")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(Panel_Loading), Member = "Update")]
	[CalledBy(Type = typeof(BootUpdate), Member = "Update")]
	public static string GetPressAnyKeyString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static bool ShouldDestroyWornOutGear(GearItem gi)
	{
		return default(bool);
	}

	[CallerCount(Count = 206)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsGamepadActive()
	{
		return default(bool);
	}

	[CallerCount(Count = 62)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsMouseActive()
	{
		return default(bool);
	}

	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[CalledBy(Type = typeof(PlayerManager), Member = "RotateCurrentPlaceable")]
	[CalledBy(Type = typeof(Panel_LeanToInteract), Member = "RotatePlaceMesh")]
	[Calls(Type = typeof(InputManager), Member = "GetRadialButtonHeldDown")]
	[Calls(Type = typeof(InputManager), Member = "GetSprintDown")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(InputManager), Member = "HasContext")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(InputManager), Member = "GetAxisScrollWheel")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystemRewired), Member = "GetButton")]
	public static float InputControlRotate(MonoBehaviour context, float rotationDegreesPerSecond, float mouseWheelRotationDegrees)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateItemInHands")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	public static void LightPositionFixUp(Transform lightT, float lightLift)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 387)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void SetActive(GameObject go, bool active)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitializeObjectToPlace")]
	[CallsUnknownMethods(Count = 17)]
	public static Collider GetLargestCollider(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SetObjectToSpawnBoundingRadius")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(MapDetailManager), Member = "UnlockMapDetailObjectsNearPosition")]
	[CalledBy(Type = typeof(RadialObjectSpawner), Member = "SpawnObjectAttempt")]
	[Calls(Type = typeof(Vector3), Member = "get_magnitude")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(BearEncounter), Member = "Awake")]
	public static Renderer GetLargestBoundsRenderer(GameObject go)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector2 GetVector2WithDeadzone(Vector2 input, float deadzone)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Vector2 GetVector2WithZerodSmallAxis(Vector2 input)
	{
		return default(Vector2);
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateExamineCollectible")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "EnterInspectGearMode")]
	[CallsUnknownMethods(Count = 40)]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "InspectPrevGearItem")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "UpdateTransformFromInspectAndCamera")]
	[Calls(Type = typeof(GearItem), Member = "DisablePhysics")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "UpdateDamageShader")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeEnableInspectModeMesh")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	public static void ShowInspectForGearItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateCrafting")]
	[CalledBy(Type = typeof(Panel_BodyHarvest), Member = "MaybeHandleGearItemPlacement")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Refresh")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "ExecuteCook")]
	[CalledBy(Type = typeof(Panel_Log), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(Panel_Inventory_Examine), Member = "ExitInspectGearMode")]
	[CalledBy(Type = typeof(Panel_Log), Member = "OnBack")]
	[CallsUnknownMethods(Count = 43)]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnterState")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "UpdateDisplayText")]
	[CalledBy(Type = typeof(Panel_FeedFire), Member = "UpdateGearItem")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "DoCraftItem")]
	[CallsDeduplicatedMethods(Count = 22)]
	[Calls(Type = typeof(SnareItem), Member = "SetState")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "Enable")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "ChangeLayersForGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Inventory), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Renderer), Member = "set_shadowCastingMode")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeDisableInspectModeMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public static void ExitInspectForGearItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(InspectGearController), Member = "Update")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UpdateGearTransformForInspection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "FindChildRecursive")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool GetInspectModePivot(Inspect inspect, out Vector3 pivot)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref pivot) = null;
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "GetStartRegionSpriteName")]
	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static string GetRegionSpriteNameFromSaveSlotInfo(string saveSlotLocation)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[CalledBy(Type = typeof(Log), Member = "AddCurrentRegion")]
	[CalledBy(Type = typeof(Log), Member = "AddLocation")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(Action_SpawnHuntedChallengeBear), Member = "SpawnChallengeBearNearPlayer")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static bool SceneIsTransition(string sceneName)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
	[CalledBy(Type = typeof(UtilsPanelChoose), Member = "RefreshDetails")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static string GetLocalizedExperienceMode(ExperienceModeType mode)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string GetSpriteNameForExperienceMode(ExperienceModeType mode)
	{
		return null;
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public static string GetLocalizedRegion(GameRegion region)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string GetRegionLocID(GameRegion region)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(HUDManager), Member = "MaybeShowLocationReveal")]
	[Calls(Type = typeof(InterfaceManager), Member = "GetNameForScene")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CalledBy(Type = typeof(Panel_Debug), Member = "GenerateLocationList")]
	[Calls(Type = typeof(Utils), Member = "GetHardcodedRegionForLocation")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static string GetCurrentRegion()
	{
		return null;
	}

	[CalledBy(Type = typeof(ToxicFogManager), Member = "Reset")]
	[CalledBy(Type = typeof(SceneMusicManager), Member = "Awake")]
	[CalledBy(Type = typeof(InvisibleEntityManager), Member = "Reset")]
	[CalledBy(Type = typeof(HUDManager), Member = "Deserialize")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(BodyHarvest), Member = "MaybeDestroyAfterDeserialize")]
	public static bool IsSceneTransition()
	{
		return default(bool);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 23)]
	[CalledBy(Type = typeof(Action_DestroySelectedPlayerItems), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_GiveBackPlayerItems), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_WhiteoutGearRequirements), Member = "OnUpdate")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Container), Member = "GetWaterSupply")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 3)]
	public static GearItem[] GetGearItemsStoredInSceneByPlayer(bool includeContainers = true)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 8)]
	public static float GetNumCaloriesInGearItems(GearItem[] gearItems)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Utils), Member = "ColorToHex")]
	[CalledBy(Type = typeof(Utils), Member = "ColorToHex")]
	[CalledBy(Type = typeof(Utils), Member = "ColorToHex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	private static byte ToByte(float f)
	{
		return default(byte);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "ToByte")]
	[Calls(Type = typeof(Utils), Member = "ToByte")]
	[Calls(Type = typeof(Utils), Member = "ToByte")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "FormatSubtitleText")]
	[CalledBy(Type = typeof(Panel_Subtitles), Member = "FormatSubtitleText")]
	[CalledBy(Type = typeof(SandboxRecord), Member = "GetSurvivalRecordSummaryText")]
	public static string ColorToHex(Color color)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportHoursOfBlizzardForDay")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(WeatherSet), Member = "ReportHoursOfBlizzardForDay")]
	public static float GetFirstDayLengthInHours()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 2)]
	public static bool DisableGUIPanCamera()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public static bool XPModeIsSandbox(ExperienceModeType type)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(SaveGameSlots), Member = "SendAnalytics")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Log), Member = "EnableFromRadial")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(EmptyScene), Member = "UpdateNewGame")]
	public static bool XPModeIsChallenge(ExperienceModeType type)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Transform), Member = "Translate")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Utils), Member = "ShowInspectForGearItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "SetGearTransformForInspection")]
	[Calls(Type = typeof(Transform), Member = "Rotate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Random), Member = "Range")]
	public static void UpdateTransformFromInspectAndCamera(Transform transform, vp_FPSCamera camera, Inspect inspect, Vector3 originalScale)
	{
	}

	[CalledBy(Type = typeof(WintersEmbrace), Member = "CheckSaveSlotForMissedBadges")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "UpdateSlotGameMode")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CalledBy(Type = typeof(SaveGameSlots), Member = "PrepareSaveSlotForLoad")]
	[CallerCount(Count = 3)]
	public static bool StringAllNullTerminators(string s)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(Panel_Log), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GetStringForNeed")]
	[CalledBy(Type = typeof(NPC_NeedTracker), Member = "GetStringForNeed")]
	[CallsUnknownMethods(Count = 2)]
	public static string GetGearDisplayName(string gearPrefabName)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private static void CreateStreamWriter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private static void CloseStreamWriter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void Log(string line)
	{
	}

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[Calls(Type = typeof(Rigidbody), Member = "set_collisionDetectionMode")]
	[Calls(Type = typeof(Rigidbody), Member = "set_collisionDetectionMode")]
	[Calls(Type = typeof(Rigidbody), Member = "set_isKinematic")]
	[Calls(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	[CallsUnknownMethods(Count = 3)]
	public static void SetIsKinematic(Rigidbody rb, bool enable)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerAnimation), Member = "EnableEquipped")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(MatchTransform), Member = "EnableCollidersForAllActive")]
	public static void UseHigherPrecisionTimestep(bool enable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void DebugBulletHit(Vector3 p1, Vector3 p2)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void EnableDebugProjectiles(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	public static bool IsVector3NaN(Vector3 v)
	{
		return default(bool);
	}

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern int GetSystemMetrics(SystemMetrics smIndex);

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool IsDevelopmentBuild()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static GearItem GetGearItemFromObject(GameObject go)
	{
		return null;
	}

	[CalledBy(Type = typeof(FPSLogger.LogData), Member = "FormatForWrite")]
	[CalledBy(Type = typeof(FPSLogger.LogData), Member = "FormatForWrite")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(FPSLogger.LogData), Member = "FormatForWrite")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(FPSLogger.LogData), Member = "FormatForWrite")]
	public static string GetFormattedBytes(double bytes)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(DetailedStatsView), Member = "Start")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Log), Member = "BuildWhatIKnowList")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CalledBy(Type = typeof(Panel_Log), Member = "UpdateScrollbarThumbSize")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(ContainerUI), Member = "Initialize")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "Start")]
	[Calls(Type = typeof(GenericSimpleScrollbarSpawner), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(ContainerUI), Member = "Initialize")]
	public static UISlider GetSliderForScrollbar(GameObject scrollbar)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Milling), Member = "RefreshSelected")]
	[CalledBy(Type = typeof(CraftingRequirementTime), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "RefreshCraftingTimeDisplay")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "TrimEnd")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	public static string FormatDisplayTimeMinutes(int minutes, bool includeUnits)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "ProcessPrivacyMenu")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "OnViewPrivacyPolicy")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "OnClickTellMeMore")]
	[CalledBy(Type = typeof(Panel_Notifications), Member = "Update")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "UpdateHinterlandMailingListWidget")]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "OnClickHinterlandMailingListWidget")]
	[Calls(Type = typeof(Application), Member = "OpenURL")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(SteamFriends), Member = "ActivateGameOverlayToWebPage")]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static void OpenURL(string url)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(FastJson), Member = "_SerializeObject")]
	[Calls(Type = typeof(Quaternion), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static bool IsDefaultType(object value, Type type)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Utils()
	{
	}
}
