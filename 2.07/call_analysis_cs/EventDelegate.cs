using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class EventDelegate
{
	[Serializable]
	public class Parameter
	{
		public UnityEngine.Object obj;

		public string field;

		[NonSerialized]
		private object mValue;

		[NonSerialized]
		public Type expectedType;

		[NonSerialized]
		public bool cached;

		[NonSerialized]
		public PropertyInfo propInfo;

		[NonSerialized]
		public FieldInfo fieldInfo;

		public object value
		{
			[CallerCount(Count = 1)]
			[CallsDeduplicatedMethods(Count = 5)]
			[Calls(Type = typeof(Convert), Member = "ChangeType")]
			[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
			[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
			[CallsUnknownMethods(Count = 8)]
			get
			{
				return null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 55)]
			set
			{
			}
		}

		public Type type
		{
			[CallsUnknownMethods(Count = 1)]
			[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
			[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
			[CallerCount(Count = 2)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		public Parameter()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		public Parameter(UnityEngine.Object obj, string field)
		{
		}

		[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
		public Parameter(object val)
		{
		}
	}

	public delegate void Callback();

	private MonoBehaviour mTarget;

	private string mMethodName;

	private Parameter[] mParameters;

	public bool oneShot;

	[NonSerialized]
	private Callback mCachedCallback;

	[NonSerialized]
	private bool mRawDelegate;

	[NonSerialized]
	private bool mCached;

	[NonSerialized]
	private MethodInfo mMethod;

	[NonSerialized]
	private ParameterInfo[] mParameterInfos;

	[NonSerialized]
	private object[] mArgs;

	private static int s_Hash;

	public MonoBehaviour target
	{
		[CallerCount(Count = 80)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string methodName
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Parameter[] parameters
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventDelegate), Member = "Cache")]
		get
		{
			return null;
		}
	}

	public bool isValid
	{
		[CalledBy(Type = typeof(EventDelegate), Member = "IsValid")]
		[CalledBy(Type = typeof(EventDelegate), Member = "Equals")]
		[Calls(Type = typeof(EventDelegate), Member = "Cache")]
		[CallerCount(Count = 2)]
		get
		{
			return default(bool);
		}
	}

	public bool isEnabled
	{
		[Calls(Type = typeof(EventDelegate), Member = "Cache")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public EventDelegate()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[CallerCount(Count = 0)]
	public EventDelegate(Callback call)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EventDelegate), Member = "Clear")]
	public EventDelegate(MonoBehaviour target, string methodName)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static string GetMethodName(Callback callback)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static bool IsValid(Callback callback)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(EventDelegate), Member = "get_isValid")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(EventDelegate), Member = "Clear")]
	[CalledBy(Type = typeof(EventDelegate), Member = ".ctor")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UITweener), Member = "SetOnFinished")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Set")]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowNewLocationDiscovered")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Add")]
	private void Set(Callback call)
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Clear")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void Set(MonoBehaviour target, string methodName)
	{
	}

	[Calls(Type = typeof(Delegate), Member = "CreateDelegate")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(EventDelegate), Member = "get_isEnabled")]
	[CalledBy(Type = typeof(EventDelegate), Member = "get_isValid")]
	[CalledBy(Type = typeof(EventDelegate), Member = "get_parameters")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private void Cache()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Parameter), Member = "get_type")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Parameter), Member = "get_type")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(DoubleClickButton), Member = "OnClick")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(DoubleClickButton), Member = "OnClick")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(EventDelegate), Member = "Cache")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Parameter), Member = "get_value")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 3)]
	public bool Execute()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(EventDelegate), Member = "Set")]
	[CalledBy(Type = typeof(EventDelegate), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(EventDelegate), Member = "Set")]
	public void Clear()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public override string ToString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 32)]
	public static void Execute(List<EventDelegate> list)
	{
	}

	[CalledBy(Type = typeof(UIToggle), Member = "Start")]
	[CalledBy(Type = typeof(ActiveAnimation), Member = "Start")]
	[CalledBy(Type = typeof(UIInput), Member = "ExecuteOnChange")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnIncrease")]
	[CalledBy(Type = typeof(UIProgressBar), Member = "set_value")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "UpdateMenuNavigationGeneric")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDragFinished")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDecrease")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Awake")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Awake")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(EventDelegate), Member = "get_isValid")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
	public static bool IsValid(List<EventDelegate> list)
	{
		return default(bool);
	}

	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public static EventDelegate Set(List<EventDelegate> list, Callback callback)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	public static void Set(List<EventDelegate> list, EventDelegate del)
	{
	}

	[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionItemInstantiated")]
	[CalledBy(Type = typeof(SelectRegionItem), Member = "AttachEventHandler")]
	[CalledBy(Type = typeof(UISavedOption), Member = "OnEnable")]
	[CallerCount(Count = 4)]
	public static EventDelegate Add(List<EventDelegate> list, Callback callback)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 76)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[CallsUnknownMethods(Count = 3)]
	public static EventDelegate Add(List<EventDelegate> list, Callback callback, bool oneShot)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Add(List<EventDelegate> list, EventDelegate ev)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CalledBy(Type = typeof(UITweener), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnDisable")]
	[CalledBy(Type = typeof(UISavedOption), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 3)]
	public static bool Remove(List<EventDelegate> list, Callback callback)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	public static bool Remove(List<EventDelegate> list, EventDelegate ev)
	{
		return default(bool);
	}
}
