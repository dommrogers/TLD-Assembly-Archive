using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.Framework;
using UnityEngine;

namespace ParadoxNotion.Services;

public class MonoManager : MonoBehaviour
{
	private class UpdateGraphInfo
	{
		public Action m_OnUpdate;

		public Action<float> m_SetAccumulatedDeltaTime;

		public float m_AccumulatedDeltaTime;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public UpdateGraphInfo()
		{
		}
	}

	private static bool _003CisQuiting_003Ek__BackingField;

	private static MonoManager _current;

	private int m_CurrentGraphUpdated;

	private List<UpdateGraphInfo> m_UpdateGraphInfoList;

	public static bool s_StaggeredUpdateEnabled;

	public static bool isQuiting
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private set
		{
		}
	}

	public static MonoManager current
	{
		[CalledBy(Type = typeof(Node), Member = "StopCoroutine")]
		[CalledBy(Type = typeof(Threader), Member = "Begin")]
		[CalledBy(Type = typeof(MonoManager), Member = "Create")]
		[CalledBy(Type = typeof(MessageRouter), Member = "Dispatch")]
		[CalledBy(Type = typeof(Task), Member = "StopCoroutine")]
		[CalledBy(Type = typeof(Task), Member = "StartCoroutine")]
		[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
		[CallsUnknownMethods(Count = 10)]
		[CalledBy(Type = typeof(ActionTask), Member = "ExecuteAction")]
		[CalledBy(Type = typeof(Node), Member = "StartCoroutine")]
		[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
		[CalledBy(Type = typeof(Graph), Member = "Stop")]
		[CalledBy(Type = typeof(Graph), Member = "Pause")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 4)]
		[CalledBy(Type = typeof(Panel_Container._003CUpdateObjectiveUI_003Ed__111), Member = "MoveNext")]
		[CalledBy(Type = typeof(WaitForFullFSMUpdate), Member = ".ctor")]
		[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
		[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
		[Calls(Type = typeof(GameObject), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public event Action onLateUpdate
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event Action onFixedUpdate
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event Action onApplicationQuit
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	public event Action<bool> onApplicationPause
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	public static void Create()
	{
	}

	[CalledBy(Type = typeof(MonoManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MonoManager), Member = "GetYeldReturnFrameCount")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool StaggeredUpdatedEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoManager), Member = "StaggeredUpdatedEnabled")]
	[CalledBy(Type = typeof(Panel_Container._003CUpdateObjectiveUI_003Ed__111), Member = "MoveNext")]
	[CalledBy(Type = typeof(WaitForFullFSMUpdate), Member = ".ctor")]
	[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	public int GetYeldReturnFrameCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	protected void OnApplicationQuit()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected void OnApplicationPause(bool isPause)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallsUnknownMethods(Count = 3)]
	protected void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(MonoManager), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MonoManager), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(MonoManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public bool CanUpdateGraph()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CallsUnknownMethods(Count = 9)]
	public void RegisterForUpdate(Action update, Action<float> setAccumulatedDeltaTime)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Graph), Member = "Stop")]
	[CalledBy(Type = typeof(Graph), Member = "Pause")]
	[CallsUnknownMethods(Count = 6)]
	public void UnRegisterForUpdate(Action update, Action<float> setAccumulatedDeltaTime)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallerCount(Count = 0)]
	public void UpdateAll()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
	[Calls(Type = typeof(MonoManager), Member = "StaggeredUpdatedEnabled")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	protected void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
	protected void LateUpdate()
	{
	}

	[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public MonoManager()
	{
	}
}
