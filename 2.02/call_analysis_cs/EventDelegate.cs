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
			[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
			[Calls(Type = typeof(Convert), Member = "ChangeType")]
			[Calls(Type = typeof(Type), Member = "GetProperty")]
			[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
			[CallsDeduplicatedMethods(Count = 5)]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
			[CallsUnknownMethods(Count = 9)]
			get
			{
				return null;
			}
			[CallerCount(Count = 41)]
			[DeduplicatedMethod]
			set
			{
			}
		}

		public Type type
		{
			[CallsUnknownMethods(Count = 1)]
			[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
			[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
			[CallerCount(Count = 2)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		public Parameter()
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		public Parameter(UnityEngine.Object obj, string field)
		{
		}

		[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
		[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
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
		[CallerCount(Count = 52)]
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
		[CallerCount(Count = 29)]
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
		[CalledBy(Type = typeof(EventDelegate), Member = "Equals")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(EventDelegate), Member = "Cache")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(EventDelegate), Member = "IsValid")]
		get
		{
			return default(bool);
		}
	}

	public bool isEnabled
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EventDelegate), Member = "Cache")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public EventDelegate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	public EventDelegate(Callback call)
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Clear")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public EventDelegate(MonoBehaviour target, string methodName)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(EventDelegate), Member = "Equals")]
	[CallsUnknownMethods(Count = 1)]
	private static string GetMethodName(Callback callback)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	private static bool IsValid(Callback callback)
	{
		return default(bool);
	}

	[Calls(Type = typeof(EventDelegate), Member = "GetMethodName")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(EventDelegate), Member = "get_isValid")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(EventDelegate), Member = "Set")]
	[CalledBy(Type = typeof(EventDelegate), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(EventDelegate), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_MainMenu), Member = "InitializeHinterlandMailingListWidget")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Add")]
	[CallsUnknownMethods(Count = 5)]
	private void Set(Callback call)
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(EventDelegate), Member = "Clear")]
	[CallerCount(Count = 3)]
	public void Set(MonoBehaviour target, string methodName)
	{
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate")]
	[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(EventDelegate), Member = "get_parameters")]
	[CalledBy(Type = typeof(EventDelegate), Member = "get_isValid")]
	[CalledBy(Type = typeof(EventDelegate), Member = "get_isEnabled")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
	[CalledBy(Type = typeof(BasicMenu), Member = "InstantiateMenuItems")]
	[CallsUnknownMethods(Count = 57)]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	private void Cache()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Parameter), Member = "get_type")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Parameter), Member = "get_type")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Execute")]
	[CalledBy(Type = typeof(DoubleClickButton), Member = "OnClick")]
	[CalledBy(Type = typeof(DoubleClickButton), Member = "OnClick")]
	[CallsUnknownMethods(Count = 71)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Parameter), Member = "get_value")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(EventDelegate), Member = "Cache")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public bool Execute()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(EventDelegate), Member = ".ctor")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(EventDelegate), Member = "Set")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Set")]
	public void Clear()
	{
	}

	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 31)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void Execute(List<EventDelegate> list)
	{
	}

	[CalledBy(Type = typeof(ActiveAnimation), Member = "Start")]
	[CalledBy(Type = typeof(UIProgressBar), Member = "set_value")]
	[CalledBy(Type = typeof(UIPopupList), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIToggle), Member = "Set")]
	[CalledBy(Type = typeof(UIInput), Member = "ExecuteOnChange")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnIncrease")]
	[CalledBy(Type = typeof(ConsoleComboBox), Member = "OnDecrease")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDragFinished")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnIncrease")]
	[CalledBy(Type = typeof(ConsoleSlider), Member = "OnDecrease")]
	[CalledBy(Type = typeof(Panel_OptionsMenu), Member = "RefreshSliderLabel")]
	[CalledBy(Type = typeof(UIPopupList), Member = "TriggerCallbacks")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Awake")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(EventDelegate), Member = "get_isValid")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 14)]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Awake")]
	public static bool IsValid(List<EventDelegate> list)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_HUD), Member = "ShowNewLocationDiscovered")]
	[CalledBy(Type = typeof(UITweener), Member = "SetOnFinished")]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public static EventDelegate Set(List<EventDelegate> list, Callback callback)
	{
		return null;
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Set(List<EventDelegate> list, EventDelegate del)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 71)]
	public static EventDelegate Add(List<EventDelegate> list, Callback callback)
	{
		return null;
	}

	[CalledBy(Type = typeof(UIPlayAnimation), Member = "Play")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(EventDelegate), Member = "Set")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[CalledBy(Type = typeof(EventDelegate), Member = "Add")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "Play")]
	[CallsUnknownMethods(Count = 8)]
	public static EventDelegate Add(List<EventDelegate> list, Callback callback, bool oneShot)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static void Add(List<EventDelegate> list, EventDelegate ev)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UITweener), Member = "Update")]
	[CalledBy(Type = typeof(UITweener), Member = "AddOnFinished")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static void Add(List<EventDelegate> list, EventDelegate ev, bool oneShot)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(UIPlayTween), Member = "OnDisable")]
	[CalledBy(Type = typeof(UISavedOption), Member = "OnDisable")]
	[CalledBy(Type = typeof(UIPlayAnimation), Member = "OnDisable")]
	public static bool Remove(List<EventDelegate> list, Callback callback)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public static bool Remove(List<EventDelegate> list, EventDelegate ev)
	{
		return default(bool);
	}
}
