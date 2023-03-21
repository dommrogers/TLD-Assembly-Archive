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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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
		[CalledBy(Type = typeof(Task), Member = "StopCoroutine")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "OnExecute")]
		[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
		[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
		[CalledBy(Type = typeof(ActionTask), Member = "ExecuteAction")]
		[CalledBy(Type = typeof(Node), Member = "StopCoroutine")]
		[CalledBy(Type = typeof(Node), Member = "StartCoroutine")]
		[CalledBy(Type = typeof(Graph), Member = "Pause")]
		[CalledBy(Type = typeof(Task), Member = "StartCoroutine")]
		[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
		[CalledBy(Type = typeof(Graph), Member = "Stop")]
		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(Panel_Container._003CUpdateObjectiveUI_003Ed__115), Member = "MoveNext")]
		[Calls(Type = typeof(GameObject), Member = ".ctor")]
		[CalledBy(Type = typeof(MessageRouter), Member = "Dispatch")]
		[CalledBy(Type = typeof(MonoManager), Member = "Create")]
		[CalledBy(Type = typeof(Threader), Member = "Begin")]
		[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
		[CalledBy(Type = typeof(WaitForFullFSMUpdate), Member = ".ctor")]
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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		remove
		{
		}
	}

	public event Action onFixedUpdate
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
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

	public event Action<bool> onApplicationPause
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	public static void Create()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(MonoManager), Member = "Update")]
	[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
	[CalledBy(Type = typeof(MonoManager), Member = "GetYeldReturnFrameCount")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Panel_Container._003CUpdateObjectiveUI_003Ed__115), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(WaitForFullFSMUpdate), Member = ".ctor")]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	protected void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(MonoManager), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(MonoManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(MonoManager), Member = "Update")]
	public bool CanUpdateGraph()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterForUpdate(Action update, Action<float> setAccumulatedDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	public void UnRegisterForUpdate(Action update, Action<float> setAccumulatedDeltaTime)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	public void UpdateAll()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
	[Calls(Type = typeof(MonoManager), Member = "StaggeredUpdatedEnabled")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public MonoManager()
	{
	}
}
