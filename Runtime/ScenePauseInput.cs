// SPDX-License-Identifier: Apache-2.0
// © 2023-2024 Nikolay Melnikov <n.melnikov@depra.org>

using System;
using UnityEngine;

namespace Depra.Pause
{
	public abstract class ScenePauseInput : MonoBehaviour, IPauseInput
	{
		public abstract event Action Pause;
		public abstract event Action Resume;
	}
}