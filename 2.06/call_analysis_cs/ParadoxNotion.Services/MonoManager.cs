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
			return false;
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		private set
		{
		}
	}

	public static MonoManager current
	{
		[CalledBy(TypeFullName = "Panel_Container.<UpdateObjectiveUI>d__115", Member = "MoveNext")]
		[CalledBy(Type = typeof(WaitForFullFSMUpdate), Member = ".ctor")]
		[CalledBy(Type = typeof(MessageRouter), Member = "Dispatch")]
		[CalledBy(Type = typeof(MonoManager), Member = "Create")]
		[CalledBy(Type = typeof(Threader), Member = "Begin")]
		[CalledBy(Type = typeof(ActionListPlayer), Member = "Play")]
		[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
		[CalledBy(Type = typeof(Graph), Member = "Stop")]
		[CalledBy(Type = typeof(Graph), Member = "Pause")]
		[CalledBy(Type = typeof(Node), Member = "StartCoroutine")]
		[CalledBy(Type = typeof(Node), Member = "StopCoroutine")]
		[CalledBy(Type = typeof(ActionTask), Member = "ExecuteAction")]
		[CalledBy(TypeFullName = "NodeCanvas.Framework.ConditionTask.<Flip>d__13", Member = "MoveNext")]
		[CalledBy(Type = typeof(Task), Member = "StartCoroutine")]
		[CalledBy(Type = typeof(Task), Member = "StopCoroutine")]
		[CalledBy(Type = typeof(ParlayChooseResponseNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "OnExecute")]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectOfType")]
		[Calls(Type = typeof(GameObject), Member = ".ctor")]
		[Calls(Type = typeof(GameObject), Member = "AddComponent")]
		[CallsUnknownMethods(Count = 6)]
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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(TypeFullName = "Panel_Container.<UpdateObjectiveUI>d__115", Member = "MoveNext")]
	[CalledBy(Type = typeof(WaitForFullFSMUpdate), Member = ".ctor")]
	[CalledBy(Type = typeof(MonoManager), Member = "GetYeldReturnFrameCount")]
	[CalledBy(Type = typeof(MonoManager), Member = "Update")]
	[CalledBy(TypeFullName = "NodeCanvas.Framework.ConditionTask.<Flip>d__13", Member = "MoveNext")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool StaggeredUpdatedEnabled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "StaggeredUpdatedEnabled")]
	[CallsUnknownMethods(Count = 1)]
	public int GetYeldReturnFrameCount()
	{
		return 0;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	protected void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(MonoManager), Member = "Update")]
	[CalledBy(Type = typeof(MonoManager), Member = "LateUpdate")]
	[CalledBy(Type = typeof(MonoManager), Member = "FixedUpdate")]
	[CalledBy(TypeFullName = "NodeCanvas.Framework.ConditionTask.<Flip>d__13", Member = "MoveNext")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[CallsUnknownMethods(Count = 1)]
	public bool CanUpdateGraph()
	{
		return false;
	}

	[CalledBy(Type = typeof(Graph), Member = "StartGraph")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void RegisterForUpdate(Action update, Action<float> setAccumulatedDeltaTime)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "Stop")]
	[CalledBy(Type = typeof(Graph), Member = "Pause")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "RemoveAt")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void UnRegisterForUpdate(Action update, Action<float> setAccumulatedDeltaTime)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void UpdateAll()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
	[Calls(Type = typeof(MonoManager), Member = "StaggeredUpdatedEnabled")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	protected void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "CanUpdateGraph")]
	[CallsDeduplicatedMethods(Count = 1)]
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
