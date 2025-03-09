// SPDX-License-Identifier: Apache-2.0
// © 2023-2025 Depra <n.melnikov@depra.org>

using System;
using UnityEngine;

namespace Depra.Pause
{
	public abstract class ScenePauseInput : MonoBehaviour, IPauseInputSource
	{
		public abstract event Action PauseTriggered;
		public abstract event Action ResumeTriggered;

		protected IPauseState State { get; private set; }

		public void Initialize(IPauseState state) => State = state;
	}
}