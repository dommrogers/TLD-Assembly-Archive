using System;
using Cpp2ILInjected.CallAnalysis;

namespace Rewired;

public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
{
	public static readonly Guid typeGuid;

	public const int elementId_leftStickX = 0;

	public const int elementId_leftStickY = 1;

	public const int elementId_rightStickX = 2;

	public const int elementId_rightStickY = 3;

	public const int elementId_actionBottomRow1 = 4;

	public const int elementId_a = 4;

	public const int elementId_actionBottomRow2 = 5;

	public const int elementId_b = 5;

	public const int elementId_actionBottomRow3 = 6;

	public const int elementId_c = 6;

	public const int elementId_actionTopRow1 = 7;

	public const int elementId_x = 7;

	public const int elementId_actionTopRow2 = 8;

	public const int elementId_y = 8;

	public const int elementId_actionTopRow3 = 9;

	public const int elementId_z = 9;

	public const int elementId_leftShoulder1 = 10;

	public const int elementId_leftBumper = 10;

	public const int elementId_leftShoulder2 = 11;

	public const int elementId_leftTrigger = 11;

	public const int elementId_rightShoulder1 = 12;

	public const int elementId_rightBumper = 12;

	public const int elementId_rightShoulder2 = 13;

	public const int elementId_rightTrigger = 13;

	public const int elementId_center1 = 14;

	public const int elementId_back = 14;

	public const int elementId_center2 = 15;

	public const int elementId_start = 15;

	public const int elementId_center3 = 16;

	public const int elementId_guide = 16;

	public const int elementId_leftStickButton = 17;

	public const int elementId_rightStickButton = 18;

	public const int elementId_dPadUp = 19;

	public const int elementId_dPadRight = 20;

	public const int elementId_dPadDown = 21;

	public const int elementId_dPadLeft = 22;

	public const int elementId_leftStick = 23;

	public const int elementId_rightStick = 24;

	public const int elementId_dPad = 25;

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionBottomRow1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ea
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionBottomRow2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Eb
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionBottomRow3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ec
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionTopRow1
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ex
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionTopRow2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ey
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EactionTopRow3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ez
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EleftShoulder1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002EleftBumper
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIGamepadTemplate_002EleftShoulder2
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIGamepadTemplate_002EleftTrigger
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002ErightShoulder1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002ErightBumper
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIGamepadTemplate_002ErightShoulder2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateAxis Rewired_002EIGamepadTemplate_002ErightTrigger
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ecenter1
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Eback
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ecenter2
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Estart
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Ecenter3
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateButton Rewired_002EIGamepadTemplate_002Eguide
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThumbStick Rewired_002EIGamepadTemplate_002EleftStick
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateThumbStick Rewired_002EIGamepadTemplate_002ErightStick
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	private IControllerTemplateDPad Rewired_002EIGamepadTemplate_002EdPad
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ControllerTemplate), Member = ".ctor")]
	public GamepadTemplate(object payload)
		: base(null)
	{
	}
}
