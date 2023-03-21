using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;
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
		[CallerCount(Count = 6)]
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
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static MonoManager current
	{
		[CalledBy(Type = typeof(Graph), Member = "Pause")]
		[CallsUnknownMethods(Count = 6)]
		[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "OnExecute")]
		[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(Task), Member = "StopCoroutine")]
		[CalledBy(Type = typeof(Task), Member = "StartCoroutine")]
		[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
		[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
		[CalledBy(Type = typeof(ActionTask), Member = "ExecuteAction")]
		[CalledBy(Type = typeof(Node), Member = "StopCoroutine")]
		[CalledBy(Type = typeof(Node), Member = "StartCoroutine")]
		[CalledBy(Type = typeof(Graph), Member = "Stop")]
		[CalledBy(Type = typeof(WaitForFullFSMUpdate), Member = ".ctor")]
		[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(GameObject), Member = ".ctor")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(MessageRouter), Member = "Dispatch")]
		[CalledBy(Type = typeof(MonoManager), Member = "Create")]
		[CalledBy(Type = typeof(Threader), Member = "Begin")]
		[CalledBy(Type = typeof(Panel_Container._003CUpdateObjectiveUI_003Ed__115), Member = "MoveNext")]
		get
		{
			return null;
		}
	}

	public event Action onLateUpdate
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
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

	public event Action onFixedUpdate
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event Action onApplicationQuit
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event Action<bool> onApplicationPause
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 2)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	public static void Create()
	{
	}

	[CalledBy(Type = typeof(MonoManager), Member = "Update")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
	[CalledBy(Type = typeof(MonoManager), Member = "GetYeldReturnFrameCount")]
	[CalledBy(Type = typeof(WaitForFullFSMUpdate), Member = ".ctor")]
	[CalledBy(Type = typeof(Panel_Container._003CUpdateObjectiveUI_003Ed__115), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 5)]
	public bool StaggeredUpdatedEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "StaggeredUpdatedEnabled")]
	[CallsUnknownMethods(Count = 1)]
	public int GetYeldReturnFrameCount()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnApplicationQuit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnApplicationPause(bool isPause)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	protected void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(MonoManager), Member = "FixedUpdate")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
	[CalledBy(Type = typeof(MonoManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MonoManager), Member = "Update")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public bool CanUpdateGraph()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CallsUnknownMethods(Count = 7)]
	public void RegisterForUpdate(Action update, Action<float> setAccumulatedDeltaTime)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Graph), Member = "Pause")]
	[CalledBy(Type = typeof(Graph), Member = "Stop")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public void UnRegisterForUpdate(Action update, Action<float> setAccumulatedDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateAll()
	{
	}

	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(MonoManager), Member = "StaggeredUpdatedEnabled")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
	protected void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
	protected void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
	protected void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public MonoManager()
	{
	}
}
