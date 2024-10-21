// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using System;
using UnityEngine;

namespace Depra.Pause
{
	public abstract class ScenePauseInput : MonoBehaviour, IPauseInputSource
	{
		public abstract event Action PauseTriggered;
		public abstract event Action ResumeTriggered;

		public abstract void Initialize(IPauseState state);
	}
}