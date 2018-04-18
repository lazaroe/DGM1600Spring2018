﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject {

	public int PowerLevel;
	public Movement MovePatternTransfer;
	public Movement Transfer()
	{
		return MovePatternTransfer;
	}
}
