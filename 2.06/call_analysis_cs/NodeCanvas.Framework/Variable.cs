using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
public abstract class Variable
{
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public Variable _003C_003E4__this;

		public Func<object, object> converter;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal object _003CGetGetConverter_003Eb__0()
		{
			return null;
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal object _003CGetGetConverter_003Eb__1()
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public Variable _003C_003E4__this;

		public Func<object, object> converter;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal void _003CGetSetConverter_003Eb__0(object x)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CGetSetConverter_003Eb__1(object x)
		{
		}
	}

	private string _name;

	private string _id;

	private bool _protected;

	public string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 98)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		set
		{
		}
	}

	public string ID
	{
		[Calls(Type = typeof(Guid), Member = "ToString")]
		[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public object value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool isProtected
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	protected abstract object objectValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		set;
	}

	public abstract Type varType
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	public abstract bool hasBinding
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	public abstract string propertyPath
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		set;
	}

	public event Action<string> onNameChanged
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

	public event Action<string, object> onValueChanged
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
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
	[DeduplicatedMethod]
	protected bool HasValueChangeEvent()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void OnValueChanged(string name, object value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Variable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	public abstract void BindProperty(MemberInfo prop, GameObject target = null);

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	public abstract void UnBindProperty();

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	public abstract void InitializePropertyBinding(GameObject go, bool callSetter = false);

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
	public bool CanConvertTo(Type toType)
	{
		return default(bool);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TypeConverter), Member = "Get")]
	[CalledBy(Type = typeof(BBParameter<>), Member = "BindGetter")]
	[CalledBy(Type = typeof(Variable), Member = "CanConvertTo")]
	[CalledBy(Type = typeof(BlackboardSource._003C_003Ec__DisplayClass30_0), Member = "<GetVariableNames>b__0")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CallsUnknownMethods(Count = 16)]
	public Func<object> GetGetConverter(Type toType)
	{
		return null;
	}

	[Calls(Type = typeof(Variable), Member = "GetSetConverter")]
	[CallerCount(Count = 0)]
	public bool CanConvertFrom(Type fromType)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TypeConverter), Member = "Get")]
	[CalledBy(Type = typeof(BBParameter<>), Member = "BindSetter")]
	[CalledBy(Type = typeof(Variable), Member = "CanConvertFrom")]
	[CallsUnknownMethods(Count = 16)]
	public Action<object> GetSetConverter(Type fromType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 98)]
	public override string ToString()
	{
		return null;
	}
}
[Serializable]
public class Variable<T> : Variable
{
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public Variable<T> _003C_003E4__this;

		public GameObject go;

		public FieldInfo field;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		internal T _003CInitializePropertyBinding_003Eb__1()
		{
			return (T)null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CInitializePropertyBinding_003Eb__3(T o)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_1
	{
		public MethodInfo getMethod;

		public Component instance;

		public MethodInfo setMethod;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass22_1()
		{
		}

		[CallsUnknownMethods(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal T _003CInitializePropertyBinding_003Eb__0()
		{
			return (T)null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "SingleTempArgsArray")]
		[CallsUnknownMethods(Count = 2)]
		internal void _003CInitializePropertyBinding_003Eb__2(T o)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_2
	{
		public Component instance;

		public _003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals1;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass22_2()
		{
		}

		[CallsUnknownMethods(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal T _003CInitializePropertyBinding_003Eb__4()
		{
			return (T)null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
		[CallsUnknownMethods(Count = 2)]
		internal void _003CInitializePropertyBinding_003Eb__5(T o)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_3
	{
		public T value;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass22_3()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		internal T _003CInitializePropertyBinding_003Eb__6()
		{
			return (T)null;
		}
	}

	private T _value;

	private string _propertyPath;

	private Func<T> getter;

	private Action<T> setter;

	public override string propertyPath
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
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

	public override bool hasBinding
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	protected override object objectValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 3)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public override Type varType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	public new T value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return (T)null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 4)]
		set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Variable()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public T GetValue()
	{
		return (T)null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetValue(T newValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	public override void BindProperty(MemberInfo prop, GameObject target = null)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override void UnBindProperty()
	{
	}

	[CallsUnknownMethods(Count = 101)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(ReflectionTools), Member = "IsConstant")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetProperty")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	public override void InitializePropertyBinding(GameObject go, bool callSetter = false)
	{
	}
}
