// SPDX-License-Identifier: Apache-2.0
// © 2023-2025 Depra <n.melnikov@depra.org>

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Depra.Pause.Input")]

namespace Depra.Pause
{
	internal static class Module
	{
		public const int DEFAULT_ORDER = 52;
		public const string MENU_PATH = nameof(Depra) + "/" + nameof(Pause) + "/";
	}
}