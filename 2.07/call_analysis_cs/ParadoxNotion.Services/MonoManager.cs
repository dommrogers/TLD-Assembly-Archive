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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public static MonoManager current
	{
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "OnExecute")]
		[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(Task), Member = "StopCoroutine")]
		[CalledBy(Type = typeof(Task), Member = "StartCoroutine")]
		[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
		[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
		[CalledBy(Type = typeof(ActionTask), Member = "ExecuteAction")]
		[CalledBy(Type = typeof(Node), Member = "StopCoroutine")]
		[CalledBy(Type = typeof(Graph), Member = "Pause")]
		[CalledBy(Type = typeof(Node), Member = "StartCoroutine")]
		[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
		[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
		[CalledBy(Type = typeof(Threader), Member = "Begin")]
		[CalledBy(Type = typeof(MonoManager), Member = "Create")]
		[CalledBy(Type = typeof(MessageRouter), Member = "Dispatch")]
		[CalledBy(Type = typeof(WaitForFullFSMUpdate), Member = ".ctor")]
		[CalledBy(Type = typeof(Panel_Container._003CUpdateObjectiveUI_003Ed__115), Member = "MoveNext")]
		[Calls(Type = typeof(GameObject), Member = ".ctor")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 18)]
		[CalledBy(Type = typeof(Graph), Member = "Stop")]
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
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
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
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	public event Action<bool> onApplicationPause
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[CallerCount(Count = 0)]
	public static void Create()
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container._003CUpdateObjectiveUI_003Ed__115), Member = "MoveNext")]
	[CalledBy(Type = typeof(WaitForFullFSMUpdate), Member = ".ctor")]
	[CalledBy(Type = typeof(MonoManager), Member = "GetYeldReturnFrameCount")]
	[CalledBy(Type = typeof(MonoManager), Member = "Update")]
	[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 2)]
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected void OnApplicationQuit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnApplicationPause(bool isPause)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallsUnknownMethods(Count = 4)]
	protected void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ConditionTask._003CFlip_003Ed__13), Member = "MoveNext")]
	[CalledBy(Type = typeof(MonoManager), Member = "FixedUpdate")]
	[CalledBy(Type = typeof(MonoManager), Member = "LateUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
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

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(MonoManager), Member = "StaggeredUpdatedEnabled")]
	[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public MonoManager()
	{
	}
}
